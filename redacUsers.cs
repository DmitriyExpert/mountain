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
    public partial class redacUsers : Form
    {
        public AuthUser CurrentUser { get; set; }
        public redacUsers(AuthUser currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
<<<<<<< HEAD
=======
            rolesComboBox.Text = "Выберите роль, на которую хотите поменять текущую";
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141

            DBConnection db = new DBConnection();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT role_name FROM mountain.roles", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                roleSearchField.Items.Add(row["role_name"].ToString());
<<<<<<< HEAD
=======
                rolesComboBox.Items.Add(row["role_name"].ToString());
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            }
            db.closeConnection();
        }

        private void redacUsers_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
<<<<<<< HEAD
=======
            roleSearchField.Text = "Выберите роль";
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);

            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT u.id, u.first_name, u.last_name, u.login, r.role_name FROM mountain.users u INNER JOIN mountain.roles r ON u.role_id = r.id", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                dataGridViewUsers.DataSource = table;
            } else
            {
                MessageBox.Show("В базе данных нет пользователей");
            }
            db.closeConnection();
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toClient_Click(object sender, EventArgs e)
        {
            menu menu = new menu(CurrentUser);
            menu.Show();
            this.Close();
        }

<<<<<<< HEAD
        
    }
=======
        private void buttonRoleSearch_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id FROM mountain.roles where role_name = @rn", db.getConnection());
            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = roleSearchField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                int id = Convert.ToInt32(row["id"]);
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                MySqlCommand command2 = new MySqlCommand("SELECT u.id, u.first_name, u.last_name, u.login, r.role_name FROM mountain.users u INNER JOIN mountain.roles r ON u.role_id = r.id WHERE u.role_id = @RoleId", db.getConnection());
                command2.Parameters.AddWithValue("@RoleId", id.ToString());
                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);
                if (table2.Rows.Count > 0)
                {
                    dataGridViewUsers.DataSource = table2;
                }
                else
                {
                    roleSearchField.Text = "Пользователей с такой ролью нет!";
                }
            }
            else
            {
                roleSearchField.Text = "Ошибка: Выберите роль из списка";
            }
            db.closeConnection();
        }



        private void buttonIdSearch_Click_1(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT u.id, u.first_name, u.last_name, u.login, r.role_name FROM mountain.users u INNER JOIN mountain.roles r ON u.role_id = r.id WHERE u.id = @Id", db.getConnection());
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = idSearchField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridViewUsers.DataSource = table;
            }
            else
            {
                idSearchField.Text = "Пользователь с таким id не найден";
            }
            db.closeConnection();
        }
        string firstName = "";
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получаем строку по индексу
                DataGridViewRow clickedRow = dataGridViewUsers.Rows[e.RowIndex];

                // Обрабатываем данные выбранной строки
                string firstName = clickedRow.Cells["first_name"].Value?.ToString();  // Используем ?. для безопасного доступа
                int id = Convert.ToInt32(clickedRow.Cells["id"].Value); // Используем Convert.ToInt32, обрабатываем исключение ниже

                try
                {
                    idishnik.Visible = true;
                    idishnik.Text = id.ToString();
                    changedRoles.Visible = true;
                    deleteUser.Visible = true;
                    label5.Visible = true;
                    passAdmText.Visible = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка преобразования типа: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
        }
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            // Проверяем, есть ли выделенные строки
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Получаем первую выделенную строку (предполагаем, что пользователь выделяет только одну строку)
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];

                // Проверяем, полностью ли выделена строка
                if (selectedRow.Selected)
                {
                    string firstName = selectedRow.Cells["first_name"].Value?.ToString();
                    int id = -1;

                    // Безопасное преобразование id
                    if (int.TryParse(selectedRow.Cells["id"].Value?.ToString(), out int parsedId))
                    {
                        id = parsedId;
                    }
                    else
                    {
                        MessageBox.Show("Не удалось преобразовать ID в число.");
                        return; // Выходим из функции, если преобразование не удалось
                    }

                    idishnik.Visible = true;
                    changedRoles.Visible = true;
                    deleteUser.Visible = true;
                    label5.Visible = true;
                    passAdmText.Visible = true;
                    idishnik.Text = id.ToString();
                }
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (passAdmText.Text == "123")
            {
                try
                {
                    DBConnection db = new DBConnection();
                    db.openConnection();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("DELETE FROM mountain.users u where u.id = @idishnik", db.getConnection());
                    command.Parameters.Add("@idishnik", MySqlDbType.VarChar).Value = idishnik.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MessageBox.Show("Пользователь удален");
                    db.closeConnection();
                    passAdmText.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Введен не верный пароль администратора, или не введен вообще");
            }
        }

        private void changedRoles_Click(object sender, EventArgs e)
        {
            if (passAdmText.Text == "123")
            {
                rolesComboBox.Visible = true;
                buttonChangeRoles.Visible = true;
            }
            else
            {
                MessageBox.Show("Введен не верный пароль администратора, или не введен вообще");
            }
        }

        private void rolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonChangeRoles_Click(object sender, EventArgs e)
        {
            if (rolesComboBox.Text != "")
            {
                DBConnection db = new DBConnection();
                try
                {
                    db.openConnection();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT id FROM mountain.roles WHERE role_name = @rname", db.getConnection());
                    command.Parameters.Add("@rname", MySqlDbType.VarChar).Value = rolesComboBox.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        int roleId = Convert.ToInt32(row["id"]); // Преобразуем в Int32

                        
                        MySqlCommand command2 = new MySqlCommand("UPDATE mountain.users SET role_id = @iden WHERE id = @idishnik", db.getConnection());
                        command2.Parameters.Add("@iden", MySqlDbType.Int32).Value = roleId; 
                        command2.Parameters.Add("@idishnik", MySqlDbType.Int32).Value = Convert.ToInt32(idishnik.Text); //Преобразуем в Int32

                        int rowsAffected = command2.ExecuteNonQuery(); // Выполняем обновление и получаем кол-во затронутых строк

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Роль успешно изменена!");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления роли. Возможно, пользователь с таким ID не найден.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Роль не найдена!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
                finally
                {
                    db.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Выберите роль!");
            }
        }
    }

>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
}
