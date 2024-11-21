using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
            passwordtextBox.UseSystemPasswordChar = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toAuth_Click(object sender, EventArgs e)
        {

        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void registerTextSupForm_Click(object sender, EventArgs e)
        {

        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            var regForm = new registration();
            this.Close();
            regForm.Show();
        }

        private void auth_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String loginUser = logintextBox.Text;
            String passUser = Class1.hashPassword(passwordtextBox.Text);

            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM mountain.users WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация успешна!");


                try
                {
                    DataRow row = table.Rows[0];
                    int id = Convert.ToInt32(row["id"]);
                    int roleId = Convert.ToInt32(row["role_id"]);

                    AuthUser authUser = new AuthUser(
                        id,
                        row["firs_name"]?.ToString() ?? "",
                        row["middle_name"]?.ToString() ?? "",
                        row["last_name"]?.ToString() ?? "",
                        row["login"]?.ToString() ?? "",
                        roleId
                    );

                    MessageBox.Show(authUser.ToString());
                    menu menu = new menu(authUser); // Передаём данные в menu
                    this.Close();
                    menu.Show();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка преобразования типов: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль");
                passwordtextBox.Text = "";
                return;
            }
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
