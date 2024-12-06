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
                MessageBox.Show($"Ошибка при получении ID типа смены: {ex.Message}");
                // Или throw new Exception(...);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuerySearchRole = "SELECT id FROM roles WHERE role_name = @rn";
                string sqlQuerySearchTypeShift = "SELECT id FROM shiftstypes WHERE shiftType_name = @stn";
                string sqlQueryIntoToShifts = "INSERT INTO shifts (typeShift_id, time_start, time_end, role_id) VALUES (@shiftTid, @start, @end, @roleId)";
            }
            catch(MySqlException ex)
            {
                MessageBox.Show($"Ошибка сохранения {ex.Message}");
            }
        }
    }
}
