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
    public partial class whowithme : Form
    {

        public AuthUser _currUser { get; set; }
        public whowithme(AuthUser currUser)
        {
            InitializeComponent();
            _currUser = currUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void whowithme_Load(object sender, EventArgs e)
        {
            comboBoxDays.Items.Clear();
            try
            {
                DBConnection db = new DBConnection(); // Соединение создаётся один раз
                using (MySqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sqlQuery = "SELECT dateOfPeriod FROM mountain.autoschedule WHERE user_id = @id";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.Add("@id", MySqlDbType.Int32).Value = _currUser.Id; // Используйте Int32 для id
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // 1. Получаем дату из reader, как DateTime, с проверкой на DBNull
                                if (reader["dateOfPeriod"] != DBNull.Value)
                                {
                                    DateTime date = Convert.ToDateTime(reader["dateOfPeriod"]);
                                    // 2. Форматируем дату в строку YYYY-MM-DD
                                    comboBoxDays.Items.Add(date.ToString("dd-MM-yyyy"));
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

        private void buttonSearchUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchUsers_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonSearchUsers_Click_2(object sender, EventArgs e)
        {
            if (comboBoxDays.Text != "")
            {
                try
                {
                    DBConnection db = new DBConnection();
                    using (MySqlConnection connection = db.getConnection())
                    {
                        connection.Open();


                        string sqlQuery = "SELECT last_name as 'Фамилия', first_name as 'Имя', middle_name as 'Отчество' FROM mountain.users INNER JOIN mountain.roles ON users.role_id = roles.id INNER JOIN mountain.autoschedule ON users.id = autoschedule.user_id INNER JOIN mountain.shifts ON autoschedule.shift_id = shifts.id WHERE roles.id = @rd AND users.id in (SELECT user_id FROM mountain.autoschedule) AND dateOfPeriod = @dofper";


                        using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add("@rd", MySqlDbType.Int32).Value = _currUser.RoleId;  // Используйте Int32
                                                                                                        // 1. Парсим строку из comboBoxDays в DateTime
                            DateTime date = DateTime.Parse(comboBoxDays.Text);
                            // 2. Добавляем параметр @dofper с типом MySqlDbType.Date, передавая DateTime
                            command.Parameters.Add("@dofper", MySqlDbType.Date).Value = date;

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                                if (table.Rows.Count > 0)
                                {
                                    dataGridViewForUsers.DataSource = table;

                                }
                                else
                                {
                                    MessageBox.Show("Пользователи не найдены!");
                                    return;
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
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка формата даты: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали дату!");
                return;
            }
        }
    }
}
