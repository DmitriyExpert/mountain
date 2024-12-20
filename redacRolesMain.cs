using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class redacRolesMain : Form
    {
        public AuthUser CurrentUser { get; set; }
        public redacRolesMain(AuthUser currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void redacRolesMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            comboBoxForDeleteRoles.Items.Clear();
            try
            {
                DBConnection db = new DBConnection(); // Соединение создаётся один раз
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT role_name FROM Roles";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxForDeleteRoles.Items.Add(reader["role_name"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void addRoleToDataBase_Click(object sender, EventArgs e)
        {
            if (fieldForNameNewRole.Text != "" && switcherCanEditShedule.Text != "")
            {
                string sqlSearchIdRole = "SELECT id FROM mountain.roles WHERE role_name = @rn";
                string sqlAddRolesToDataBase = "INSERT INTO mountain.roles (role_name, can_edit_schedule) VALUES (@rnNew, @statusEdit)";
                int canEditFlag = 0;
                if (switcherCanEditShedule.Text == "Да")
                {
                    canEditFlag = 1;
                }

                try
                {
                    DBConnection db = new DBConnection(); // Соединение создаётся один раз
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    using (MySqlConnection connection = db.getConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlSearchIdRole, connection))
                        {
                            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = fieldForNameNewRole.Text;
                            adapter.SelectCommand = command;
                            adapter.Fill(table);
                            if (fieldForNameNewRole.Text.EndsWith(" "))
                            {
                                MessageBox.Show("В названии роли не должно быть пробела в конце!");
                                return;
                            }
                            else
                            {
                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show("Внимание: данная роль уже есть в базе данных! Удалите!");
                                    return;
                                }
                                else
                                {
                                    using (MySqlCommand command2 = new MySqlCommand(sqlAddRolesToDataBase, connection))
                                    {
                                        command2.Parameters.Add("@rnNew", MySqlDbType.VarChar).Value = fieldForNameNewRole.Text;
                                        command2.Parameters.Add("@statusEdit", MySqlDbType.VarChar).Value = canEditFlag.ToString();
                                        int rowsAffected = command2.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Роль успешно добавлена");
                                            fieldForNameNewRole.Text = "";
                                            canEditFlag = 0;

                                        }
                                        else
                                        {
                                            MessageBox.Show("Не удалось добавить роль");
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        connection.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
        }

        private void buttonForDeleteRoles_Click(object sender, EventArgs e)
        {
            string sqlSearchIdRole = "SELECT id FROM mountain.roles WHERE role_name = @rn";
            string sqlDeleteRole = "DELETE FROM mountain.roles WHERE id = @idRole";
            string sqlQuery = "SELECT role_name FROM Roles";
            // Сюда добавить удаление расписаний
            string sqlDeleteShifts = "DELETE FROM mountain.shifts WHERE role_id = @idRoleShifts";
            if(comboBoxForDeleteRoles.Text != "")
            {
                try
                {
                    
                    DBConnection db = new DBConnection();
                    string idSelectedRole = "";
                    using (MySqlConnection connection = db.getConnection())
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(sqlSearchIdRole, connection))
                        {
                            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = comboBoxForDeleteRoles.Text;
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idSelectedRole = reader.GetInt32(0).ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Роль не найдена.");
                                    return;
                                }
                            }
                        }
                        using (MySqlCommand command2 = new MySqlCommand(sqlDeleteShifts, connection))
                        {
                            command2.Parameters.Add("@idRoleShifts", MySqlDbType.VarChar).Value = idSelectedRole;
                            int rowsAffected = command2.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Удаление автосмен...");

                            }
                            else
                            {
                                MessageBox.Show("У данной роли нет автосмен!");
                                
                            }

                        }

                        using (MySqlCommand command3 = new MySqlCommand(sqlDeleteRole, connection))
                        {
                            command3.Parameters.Add("@idRole", MySqlDbType.VarChar).Value = idSelectedRole;
                            int rowsAffected = command3.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Роль удалилась успешно!");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить роль!");
                                return;
                            }

                        }

                        // Обновление списка ролей для удаления
                        comboBoxForDeleteRoles.Items.Clear();
                        using (MySqlCommand command4 = new MySqlCommand(sqlQuery, connection))
                        {
                            using (MySqlDataReader reader = command4.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comboBoxForDeleteRoles.Items.Add(reader["role_name"].ToString());
                                }
                            }
                        }


                        connection.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
        }
    }
}
