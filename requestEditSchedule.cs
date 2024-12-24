using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class requestEditSchedule : Form
    {

        public AuthUser _currUser { get; set; }
        public requestEditSchedule(AuthUser currUser)
        {
            InitializeComponent();
            _currUser = currUser;
        }

        private void requestEditSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT dateOfPeriod FROM mountain.autoschedule WHERE user_id = @id";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = _currUser.Id;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["dateOfPeriod"] != DBNull.Value)
                                {
                                    DateTime date = Convert.ToDateTime(reader["dateOfPeriod"]);
                                    comboBoxSelectedDate.Items.Add(date.ToString("dd-M-yyyy"));
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

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxSelectedDate.Text = "";
            textBoxForNewTimeEnd.Text = "";
            textBoxForNewTimeStart.Text = "";
            richTextBoxForRequest.Text = "";
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectedDate.SelectedItem == null)
            {
                MessageBox.Show("Выберите дату!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxForNewTimeStart.Text) || string.IsNullOrWhiteSpace(textBoxForNewTimeEnd.Text))
            {
                MessageBox.Show("Заполните время начала и конца смены!");
                return;
            }

            DateTime newTimeStart;
            if (!DateTime.TryParseExact(textBoxForNewTimeStart.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out newTimeStart))
            {
                MessageBox.Show("Неверный формат начала смены, используйте HH:mm");
                return;
            }

            DateTime newTimeEnd;
            if (!DateTime.TryParseExact(textBoxForNewTimeEnd.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out newTimeEnd))
            {
                MessageBox.Show("Неверный формат окончания смены, используйте HH:mm");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxForRequest.Text))
            {
                MessageBox.Show("Пожалуйста, заполните комментарий!");
                return;
            }

            if (string.IsNullOrWhiteSpace(newTypeshift_field.Text))
            {
                MessageBox.Show("Пожалуйста, укажите желаемый тип смены!");
                return;
            }

            try
            {
                DBConnection db = new DBConnection();
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    // 1. Получение id типа смены из таблицы shifttypes
                    int newTypeShiftId = -1;
                    string selectShiftTypeQuery = "SELECT id FROM mountain.shiftstypes WHERE shiftType_name = @typeName";
                    using (MySqlCommand command = new MySqlCommand(selectShiftTypeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@typeName", newTypeshift_field.Text);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            newTypeShiftId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Тип смены не найден в справочнике!");
                            return;
                        }

                    }
                    // 2. Вставка данных в таблицу request_of_schedule
                    string insertQuery = "INSERT INTO mountain.request_of_schedule (user_id, request_comment, datesSelected, status_id, new_time_start, new_time_end, new_typeShift_id) VALUES (@user_id, @request_comment, @datesSelected, @status_id, @new_time_start, @new_time_end, @new_typeShift_id)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = _currUser.Id;
                        command.Parameters.Add("@request_comment", MySqlDbType.VarChar).Value = richTextBoxForRequest.Text;
                        command.Parameters.Add("@datesSelected", MySqlDbType.Date).Value = DateTime.Parse(comboBoxSelectedDate.SelectedItem.ToString());
                        command.Parameters.Add("@status_id", MySqlDbType.Int32).Value = 3;
                        command.Parameters.Add("@new_time_start", MySqlDbType.Time).Value = newTimeStart.TimeOfDay;
                        command.Parameters.Add("@new_time_end", MySqlDbType.Time).Value = newTimeEnd.TimeOfDay;
                        command.Parameters.Add("@new_typeShift_id", MySqlDbType.Int32).Value = newTypeShiftId;

                        command.ExecuteNonQuery();
                        MessageBox.Show("Запрос отправлен!");
                        this.Close();
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
