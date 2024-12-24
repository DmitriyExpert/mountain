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
    public partial class toRedacSchedule : Form
    {
        public AuthUser CurrentUser { get; set; }
        public toRedacSchedule(AuthUser currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            adminpanelmenu adminpanelmenu = new adminpanelmenu(CurrentUser);
            adminpanelmenu.Show();
        }

        private void toRedacSchedule_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            usersNames.Items.Clear();
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT last_name, first_name, middle_name FROM mountain.users";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usersNames.Items.Add($"{reader["last_name"]} {reader["first_name"]} {reader["middle_name"]}");
                            }
                        }
                    }

                    string sqlQuery2 = "SELECT shiftType_name FROM mountain.shiftstypes";
                    using (MySqlCommand command2 = new MySqlCommand(sqlQuery2, connection))
                    {
                        using (MySqlDataReader reader = command2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                newTypeShift.Items.Add(reader["shiftType_name"].ToString());
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
        private void usersNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            daysInSchedule.Items.Clear();
            daysInSchedule.Text = "";// Сбрасываем выбранный элемент
            if (usersNames.SelectedItem == null) return;

            string selectedUserName = usersNames.SelectedItem.ToString();

            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT dateOfPeriod FROM mountain.autoschedule WHERE user_id = (SELECT id FROM mountain.users WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @userName)";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = selectedUserName;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["dateOfPeriod"] != DBNull.Value)
                                {
                                    daysInSchedule.Items.Add(Convert.ToDateTime(reader["dateOfPeriod"]).ToString("yyyy-MM-dd"));
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

        private void daysInSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            newTypeShift.Items.Clear();
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT shiftType_name FROM mountain.shiftstypes";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                newTypeShift.Items.Add(reader["shiftType_name"].ToString());
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

        private void newTypeShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            newTimePeriods.Items.Clear();
            newTimePeriods.Text = ""; // Сбрасываем выбранный элемент
            if (newTypeShift.SelectedItem == null || usersNames.SelectedItem == null) return;

            string selectedShiftType = newTypeShift.SelectedItem.ToString();
            string selectedUserName = usersNames.SelectedItem.ToString();
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = @"SELECT s.time_start, s.time_end FROM mountain.shifts s
                                   INNER JOIN mountain.users u ON s.role_id = u.role_id
                                   WHERE u.id = (SELECT id FROM mountain.users WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @userName)";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = selectedUserName;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["time_start"] != DBNull.Value && reader["time_end"] != DBNull.Value)
                                {
                                    TimeSpan timeStart = (TimeSpan)reader["time_start"];
                                    TimeSpan timeEnd = (TimeSpan)reader["time_end"];
                                    newTimePeriods.Items.Add($"{timeStart:hh\\:mm} - {timeEnd:hh\\:mm}");
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

        private void saveSchedule_Click(object sender, EventArgs e)
        {
            if (usersNames.SelectedItem == null || daysInSchedule.SelectedItem == null ||
               newTimePeriods.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите все параметры!");
                return;
            }
            string selectedUserName = usersNames.SelectedItem.ToString();
            DateTime selectedDate = Convert.ToDateTime(daysInSchedule.SelectedItem);
            string selectedTimePeriod = newTimePeriods.SelectedItem.ToString();

            string[] timeParts = selectedTimePeriod.Split('-');
            if (timeParts.Length != 2)
            {
                MessageBox.Show("Неверный формат времени!");
                return;
            }
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    // 1. Получаем role_id, time_start, time_end из строки
                    TimeSpan timeStart = TimeSpan.Parse(timeParts[0].Trim());
                    TimeSpan timeEnd = TimeSpan.Parse(timeParts[1].Trim());
                    string sqlQuery1 = @"SELECT id, role_id FROM mountain.shifts
                                      WHERE time_start = @timeStart AND time_end = @timeEnd 
                                      AND role_id = (SELECT role_id FROM mountain.users WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @userName)";
                    int shiftId = 0;
                    using (MySqlCommand command1 = new MySqlCommand(sqlQuery1, connection))
                    {
                        command1.Parameters.Add("@userName", MySqlDbType.VarChar).Value = selectedUserName;
                        command1.Parameters.Add("@timeStart", MySqlDbType.Time).Value = timeStart;
                        command1.Parameters.Add("@timeEnd", MySqlDbType.Time).Value = timeEnd;
                        using (MySqlDataReader reader = command1.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                shiftId = Convert.ToInt32(reader["id"]);
                            }
                            else
                            {
                                MessageBox.Show("Запись не найдена в таблице `shifts`!");
                                return;
                            }
                        }
                    }
                    
                    // 2. Обновляем запись в autoschedule
                    string sqlQuery2 = "UPDATE mountain.autoschedule SET shift_id = @shiftId WHERE user_id = (SELECT id FROM mountain.users WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @userName) AND dateOfPeriod = @dateOfPeriod";
                    using (MySqlCommand command2 = new MySqlCommand(sqlQuery2, connection))
                    {
                        command2.Parameters.Add("@userName", MySqlDbType.VarChar).Value = selectedUserName;
                        command2.Parameters.Add("@shiftId", MySqlDbType.Int32).Value = shiftId;
                        command2.Parameters.Add("@dateOfPeriod", MySqlDbType.Date).Value = selectedDate;
                        command2.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Расписание сохранено!");
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

        private void deleteSchedule_Click(object sender, EventArgs e)
        {
            if (usersNames.SelectedItem == null || daysInSchedule.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя и дату для удаления!");
                return;
            }
            string selectedUserName = usersNames.SelectedItem.ToString();
            DateTime selectedDate = Convert.ToDateTime(daysInSchedule.SelectedItem);
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM mountain.autoschedule WHERE user_id = (SELECT id FROM mountain.users WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @userName) AND dateOfPeriod = @dateOfPeriod";

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = selectedUserName;
                        command.Parameters.Add("@dateOfPeriod", MySqlDbType.Date).Value = selectedDate;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Запись расписания удалена!");
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

        private void toClient_Click(object sender, EventArgs e)
        {
            menu cabinet = new menu(CurrentUser);
            cabinet.Show();
            this.Close();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            adminpanelmenu adminpanelmenu = new adminpanelmenu(CurrentUser);
            adminpanelmenu.Show();
            this.Close();
        }
    }
}
