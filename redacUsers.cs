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
            }
            db.closeConnection();
        }

        private void redacUsers_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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

        private void buttonRoleSearch_Click(object sender, EventArgs e)
        {
            if(roleSearchField.Text != "")
            {
                try
                {
                    DBConnection db = new DBConnection(); // Соединение создаётся один раз
                    using (MySqlConnection connection = db.getConnection()) // Соединение создаётся один раз
                    {
                        connection.Open();
                            
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


