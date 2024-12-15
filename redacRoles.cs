using Microsoft.Data.SqlClient;
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
    public partial class redacRoles : Form
    {
        public AuthUser CurrentUser { get; set; }
        public redacRoles(AuthUser currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void redacRoles_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

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
                                comboBoxRoles.Items.Add(reader["role_name"].ToString());
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

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxShiftTypes.Items.Clear();

            try
            {
                DBConnection db = new DBConnection(); // Соединение создаётся один раз
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT shiftType_name FROM shiftstypes";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxShiftTypes.Items.Add(reader["shiftType_name"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
                comboBoxShiftTypes.Visible = true;
                labelShiftTypes.Visible = true;
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

        private void comboBoxShiftTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPeriodsTime.Items.Clear();
            if (comboBoxShiftTypes.Text == "Выходной" || comboBoxShiftTypes.Text == "Отпуск")
            {
                comboBoxPeriodsTime.Visible = true;
                labelPeriodsTime.Visible = true;
                button1.Visible = true;
            }
            try
            {
                DBConnection db = new DBConnection(); // Соединение создаётся один раз
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT id FROM mountain.shiftstypes where shiftType_name = @stn";

                    string idTypeShift = "";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@stn", MySqlDbType.VarChar).Value = comboBoxShiftTypes.Text;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idTypeShift = reader.GetInt32(0).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Тип смены не найден в базе данных.");

                            }
                        }
                    }
                    string sqlQuery2 = "SELECT period_time FROM periodstime where shifttypes_id = @ident";
                    using (MySqlCommand command1 = new MySqlCommand(sqlQuery2, connection))
                    {
                        command1.Parameters.Add("@ident", MySqlDbType.VarChar).Value = idTypeShift;
                        using (MySqlDataReader reader1 = command1.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                comboBoxPeriodsTime.Items.Add(reader1["period_time"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
                comboBoxPeriodsTime.Visible = true;
                labelPeriodsTime.Visible = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка при получении типа смены (возможно, не выбран тип): {ex.Message}");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string sqlQuerySearchRole = "SELECT id FROM roles WHERE role_name = @rn";
                string sqlQuerySearchTypeShift = "SELECT id FROM shiftstypes WHERE shiftType_name = @stn";
                string sqlQueryIntoToShifts = "INSERT INTO shifts (typeShift_id, time_start, time_end, role_id) VALUES (@shiftTid, @start, @end, @roleId)";
                if (comboBoxPeriodsTime.Text == "" || comboBoxRoles.Text == "" || comboBoxShiftTypes.Text == "")
                {
                    if (comboBoxPeriodsTime.Text == "")
                    {
                        if (comboBoxShiftTypes.Text == "Выходной" || comboBoxShiftTypes.Text == "Отпуск")
                        {

                        }
                        else
                        {
                            MessageBox.Show("Не выбран период времени");
                            return;
                        }
                    }
                    if (comboBoxRoles.Text == "")
                    {
                        MessageBox.Show("Не выбрана роль");
                        return;
                    }
                    if (comboBoxShiftTypes.Text == "")
                    {
                        MessageBox.Show("Не выбран тип смены");
                        return;
                    }
                }
                string roleNameSelected = comboBoxRoles.Text;
                string typeShiftSelected = comboBoxShiftTypes.Text;
                string timeSelected = comboBoxPeriodsTime.Text;

                DBConnection db = new DBConnection(); // Соединение создаётся один раз
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();

                    // Получение id роли
                    string idRoleSelected = "";
                    using (MySqlCommand command = new MySqlCommand(sqlQuerySearchRole, connection))
                    {

                        command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = roleNameSelected;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idRoleSelected = reader.GetInt32(0).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Роль не найдена в базе данных");
                                return;
                            }
                        }

                    }


                    // Получение id типа смены 
                    string idShiftSelected = "";
                    using (MySqlCommand command1 = new MySqlCommand(sqlQuerySearchTypeShift, connection))
                    {
                        command1.Parameters.Add("@stn", MySqlDbType.VarChar).Value = typeShiftSelected;
                        using (MySqlDataReader reader2 = command1.ExecuteReader())
                        {
                            if (reader2.Read())
                            {
                                idShiftSelected = reader2.GetInt32(0).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Тип смены не найден в базе данных");
                                return;
                            }
                        }
                    }


                    string timeRange = comboBoxPeriodsTime.Text;
                    string startTime;
                    string endTime;

                    // Разделение строку по разделителю ' - '

                    if (comboBoxShiftTypes.Text == "Выходной" || comboBoxShiftTypes.Text == "Отпуск")
                    {
                        startTime = "";
                        endTime = "";
                    }
                    else
                    {
                        string[] parts = timeRange.Split(" - ");

                        if (parts.Length == 2)
                        {
                            startTime = parts[0].Trim() + ":00";
                            endTime = parts[1].Trim() + ":00";
                        }
                        else
                        {
                            MessageBox.Show("Некорректный формат времени");
                            return;
                        }
                    }

                    using (MySqlCommand command2 = new MySqlCommand(sqlQueryIntoToShifts, connection))
                    {
                        //"INSERT INTO shifts (typeShift_id, time_start, time_end, role_id) VALUES (@shiftTid, @start, @end, @roleId)"
                        command2.Parameters.Add("@shiftTid", MySqlDbType.VarChar).Value = idShiftSelected;
                        command2.Parameters.Add("@start", MySqlDbType.VarChar).Value = startTime;
                        command2.Parameters.Add("@end", MySqlDbType.VarChar).Value = endTime;
                        command2.Parameters.Add("@roleId", MySqlDbType.VarChar).Value = idRoleSelected;
                        int rowsAffected = command2.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Смена успешно сохранена");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось сохранить смену.");
                        }
                    }
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка сохранения {ex.Message}");
            }
        }

        private void comboBoxPeriodsTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPeriodsTime.Text != "" && comboBoxRoles.Text != "" && comboBoxShiftTypes.Text != "")
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void comboBoxForDeleteRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuerySearchRole = "SELECT id FROM roles WHERE role_name = @rn";
            string sqlQueryReaderTime = "SELECT id, time_start, time_end FROM mountain.shifts WHERE role_id = @idRole AND typeShift_id != 3 AND typeShift_id != 4";
            comboBoxDeleteForPeriodsTime.Items.Clear();
            try
            {
                DBConnection db = new DBConnection();

                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string idRoles = "";
                    using (MySqlCommand command = new MySqlCommand(sqlQuerySearchRole, connection))
                    {
                        command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = comboBoxForDeleteRoles.Text;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idRoles = reader.GetInt32(0).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Роль не найдена");
                                return;
                            }
                        }
                    }

                    using (MySqlCommand command2 = new MySqlCommand(sqlQueryReaderTime, connection))
                    {
                        command2.Parameters.Add("@idRole", MySqlDbType.VarChar).Value = idRoles;
                        using (MySqlDataReader reader2 = command2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                comboBoxDeleteForPeriodsTime.Items.Add(reader2["time_start"] + " - " + reader2["time_end"] + " - " + reader2["id"]);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка сохранения {ex.Message}");
            }

        }

        /*
         
                    string timeRange = comboBoxPeriodsTime.Text;
                    string startTime;
                    string endTime;

                    // Разделение строку по разделителю ' - '

                    if (comboBoxShiftTypes.Text == "Выходной" || comboBoxShiftTypes.Text == "Отпуск")
                    {
                        startTime = "";
                        endTime = "";
                    }
                    else
                    {
                        string[] parts = timeRange.Split(" - ");

                        if (parts.Length == 2)
                        {
                            startTime = parts[0].Trim() + ":00";
                            endTime = parts[1].Trim() + ":00";
                        }
                        else
                        {
                            MessageBox.Show("Некорректный формат времени");
                            return;
                        }
                    }

         */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // SQL запрос для удаления автосмены
            string sqlQueryDeleteShifts = "DELETE FROM mountain.shifts WHERE id = @tsi";


            if (comboBoxForDeleteRoles.Text != "" && comboBoxDeleteForPeriodsTime.Text != "")
            {
                string partsTime = comboBoxDeleteForPeriodsTime.Text;
                string idShifts = "";

                string[] parts = partsTime.Split(" - ");
                if(parts.Length == 3)
                {
                    idShifts = parts[2];
                    MessageBox.Show(idShifts);
                } else
                {
                    MessageBox.Show("Не верный формат даты");
                }
                try
                {
                    DBConnection db = new DBConnection();

                    using (MySqlConnection connection = db.getConnection())
                    {
                        connection.Open();
                        
                        using (MySqlCommand command = new MySqlCommand(sqlQueryDeleteShifts, connection))
                        {
                            command.Parameters.Add("@tsi", MySqlDbType.VarChar).Value = idShifts;
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Запись о смене успешно удалена");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить запись о смене");
                            }
                        }

                        
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка Удаления {ex.Message}");
                }

            } else
            {
                if(comboBoxForDeleteRoles.Text == "")
                {
                    MessageBox.Show("Роль не выбрана!");
                }
                if(comboBoxDeleteForPeriodsTime.Text == "")
                {
                    MessageBox.Show("Временной интервал не выбран");
                }
                return;
            }

        }
    }
}
