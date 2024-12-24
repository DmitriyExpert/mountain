using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class requestsinadmin : Form
    {
        public AuthUser CurrentUser { get; set; }
        public requestsinadmin(AuthUser currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            adminpanelmenu adminpanelmenu = new adminpanelmenu(CurrentUser);
            adminpanelmenu.Show();
            this.Close();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toClient_Click(object sender, EventArgs e)
        {
            menu menu = new menu(CurrentUser);
            menu.Show();
            this.Close();
        }

        private void requestsinadmin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LoadRequests();
        }
        private void LoadRequests()
        {
            comboBoxWithRequest.Items.Clear();
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    // SQL-запрос для получения ID и формирования строки в comboBox
                    string sqlQuery = "SELECT id FROM mountain.request_of_schedule WHERE status_id = 3";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxWithRequest.Items.Add(reader["id"]);

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
        private void buttonReaderInfo_Click(object sender, EventArgs e)
        {
            if (comboBoxWithRequest.Text != "")
            {
                string idRequest = comboBoxWithRequest.Text;
                try
                {
                    DBConnection db = new DBConnection();
                    using (MySqlConnection connection = db.getConnection())
                    {
                        connection.Open();
                        string sqlQuery = @"SELECT r.datesSelected, r.new_time_start, r.new_time_end, r.request_comment, r.user_id,
                                    u.last_name, u.first_name, u.middle_name
                                         FROM mountain.request_of_schedule r
                                         INNER JOIN mountain.users u ON r.user_id = u.id
                                         WHERE r.id = @requestId";
                        using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add("@requestId", MySqlDbType.Int32).Value = idRequest;
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // 1. Получаем ФИО пользователя
                                    if (reader["last_name"] != DBNull.Value && reader["first_name"] != DBNull.Value && reader["middle_name"] != DBNull.Value)
                                    {
                                        labelFio.Text = $"ФИО: {reader["last_name"]} {reader["first_name"]} {reader["middle_name"]}";
                                    }
                                    else
                                    {
                                        labelFio.Text = "ФИО: ";
                                    }

                                    // 2. Получаем выбранную дату
                                    if (reader["datesSelected"] != DBNull.Value)
                                    {
                                        DateTime datesSelected = Convert.ToDateTime(reader["datesSelected"]);
                                        labelDateSelected.Text = $"Выбранная дата: {datesSelected.ToString("yyyy-MM-dd")}";
                                    }
                                    else
                                    {
                                        labelDateSelected.Text = "Выбранная дата: ";
                                    }

                                    // 3. Получаем новое время
                                    if (reader["new_time_start"] != DBNull.Value && reader["new_time_end"] != DBNull.Value)
                                    {
                                        TimeSpan newTimeStart = (TimeSpan)reader["new_time_start"];
                                        TimeSpan newTimeEnd = (TimeSpan)reader["new_time_end"];
                                        labelNewTime.Text = $"Новое время: {newTimeStart:hh\\:mm} - {newTimeEnd:hh\\:mm}";
                                    }
                                    else
                                    {
                                        labelNewTime.Text = "Новое время: ";
                                    }

                                    // 4. Получаем текст запроса
                                    if (reader["request_comment"] != DBNull.Value)
                                    {
                                        richTextBox1.Text = reader["request_comment"].ToString();
                                    }
                                    else
                                    {
                                        richTextBox1.Text = "";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Запрос не найден!");
                                    labelFio.Text = "ФИО: ";
                                    labelDateSelected.Text = "Выбранная дата: ";
                                    labelNewTime.Text = "Новое время: ";
                                    richTextBox1.Text = "";
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
        private void pushButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                DateTime datesSelected = DateTime.MinValue;
                int userId = 0;
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string updateRequestQuery = "UPDATE mountain.request_of_schedule SET status_id = 1 WHERE id = @requestId";
                    using (MySqlCommand updateRequestCommand = new MySqlCommand(updateRequestQuery, connection))
                    {
                        updateRequestCommand.Parameters.Add("@requestId", MySqlDbType.Int32).Value = comboBoxWithRequest.Text;
                        updateRequestCommand.ExecuteNonQuery();
                    }
                    string upt = "SELECT datesSelected, user_id FROM mountain.request_of_schedule WHERE id = @requestId";

                    using (MySqlCommand searchDataCommand = new MySqlCommand(upt, connection))
                    {
                        searchDataCommand.Parameters.Add("@requestId", MySqlDbType.Int32).Value = comboBoxWithRequest.Text;
                        using (MySqlDataReader reader = searchDataCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                datesSelected = Convert.ToDateTime(reader["datesSelected"]);
                                userId = Convert.ToInt32(reader["user_id"]);
                            }
                        }

                    }
                    string updateAutoScheduleQuery = "UPDATE mountain.autoschedule SET request_id = @requestId WHERE user_id = @userId AND dateOfPeriod = @dateOfPeriod";
                    using (MySqlCommand updateAutoScheduleCommand = new MySqlCommand(updateAutoScheduleQuery, connection))
                    {
                        updateAutoScheduleCommand.Parameters.Add("@requestId", MySqlDbType.Int32).Value = comboBoxWithRequest.Text;
                        updateAutoScheduleCommand.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;
                        updateAutoScheduleCommand.Parameters.Add("@dateOfPeriod", MySqlDbType.Date).Value = datesSelected;
                        updateAutoScheduleCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Статус запроса изменен, в расписание добавлен новый id request");
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                int userId = 0;
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string updateRequestQuery = "UPDATE mountain.request_of_schedule SET status_id = 2 WHERE id = @requestId";
                    using (MySqlCommand updateRequestCommand = new MySqlCommand(updateRequestQuery, connection))
                    {
                        updateRequestCommand.Parameters.Add("@requestId", MySqlDbType.Int32).Value = comboBoxWithRequest.Text;
                        updateRequestCommand.ExecuteNonQuery();
                    }



                    MessageBox.Show("Статус запроса изменен на отклонено");
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

        private void backtomenu_Click(object sender, EventArgs e)
        {
            adminpanelmenu adminpanelmenu = new adminpanelmenu(CurrentUser);
            adminpanelmenu.Show();
            this.Close();
        }
    }
}
