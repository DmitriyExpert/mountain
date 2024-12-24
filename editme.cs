using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class editme : Form
    {
        public AuthUser _curruser { get; set; }
        private Label labelVisible;
        public editme(AuthUser CurrentUser)
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role_name FROM mountain.roles where `id` = @parseId", db.getConnection());
            command.Parameters.Add("@parseId", MySqlDbType.VarChar).Value = Convert.ToString(CurrentUser.RoleId);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                DataRow row = table.Rows[0];
                string roleName = row["role_name"]?.ToString() ?? "Роль не определена";
                labelProff.Text = roleName;
            }
            else
            {
                labelProff.Text = "Ошибка";
            }

            fioUser.Text = CurrentUser.LastName + " " + CurrentUser.FirstName + " " + CurrentUser.MiddleName;
            identifyUser.Text = CurrentUser.Id.ToString() + ' ' + "-";
            _curruser = CurrentUser;
            labelVisible = this.panel;
            functions.SetCurrentUser(_curruser);
            functions.panelVisible(this, EventArgs.Empty, labelVisible);
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void editme_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            string firstName = firstNameEditField.Text.Trim();
            string lastName = lastNameEditField.Text.Trim();
            string middleName = middleNameEditField.Text.Trim();
            string password = passwordEditField.Text.Trim();

            bool isValid = true;
            if (!ValidateName(firstName, "Имя", firstNameEditField)) isValid = false;
            if (!ValidateName(lastName, "Фамилия", lastNameEditField)) isValid = false;
            if (!ValidateName(middleName, "Отчество", middleNameEditField)) isValid = false;
            if (!ValidatePassword(password))
            {
                passwordEditField.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show("Пароль должен содержать минимум 8 символов!");
                isValid = false;
            }
            if (!isValid) return;

            if (firstNameEditField.Text != "" || lastNameEditField.Text != "" || middleNameEditField.Text != "" || passwordEditField.Text != "")
            {
                try
                {
                    DBConnection db = new DBConnection(); // Соединение создаётся один раз
                    using (MySqlConnection connection = db.getConnection()) // Соединение создаётся один раз
                    {
                        connection.Open();

                        if (firstNameEditField.Text != "")
                        {
                            using (MySqlCommand commandNameField = new MySqlCommand("UPDATE mountain.users SET `first_name` = @fn WHERE `id` = @cuID", connection))
                            {
                                commandNameField.Parameters.AddWithValue("@fn", firstNameEditField.Text);
                                commandNameField.Parameters.AddWithValue("@cuID", _curruser.Id);
                                commandNameField.ExecuteNonQuery();
                            }
                            _curruser.FirstName = firstNameEditField.Text;
                        }

                        if (lastNameEditField.Text != "")
                        {
                            using (MySqlCommand commandLastNameField = new MySqlCommand("UPDATE mountain.users SET `last_name` = @ln WHERE `id` = @cuID", connection))
                            {
                                commandLastNameField.Parameters.AddWithValue("@ln", lastNameEditField.Text);
                                commandLastNameField.Parameters.AddWithValue("@cuID", _curruser.Id);
                                commandLastNameField.ExecuteNonQuery();
                            }
                            _curruser.LastName = lastNameEditField.Text;
                        }

                        if (middleNameEditField.Text != "")
                        {
                            using (MySqlCommand commandLastNameField = new MySqlCommand("UPDATE mountain.users SET `middle_name` = @mn WHERE `id` = @cuID", connection))
                            {
                                commandLastNameField.Parameters.AddWithValue("@mn", middleNameEditField.Text);
                                commandLastNameField.Parameters.AddWithValue("@cuID", _curruser.Id);
                                commandLastNameField.ExecuteNonQuery();
                            }
                            _curruser.MiddleName = middleNameEditField.Text;
                        }

                        if (passwordEditField.Text != "")
                        {
                            if (repassEditField.Text != "" && repassEditField.Text == passwordEditField.Text)
                            {
                                using (MySqlCommand commandLastNameField = new MySqlCommand("UPDATE mountain.users SET `pass` = @p WHERE `id` = @cuID", connection))
                                {
                                    commandLastNameField.Parameters.AddWithValue("@p", Class1.hashPassword(passwordEditField.Text));
                                    commandLastNameField.Parameters.AddWithValue("@cuID", _curruser.Id);
                                    commandLastNameField.ExecuteNonQuery();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Введите пароль повторно, в поле для повторного ввода");
                                return;
                            }
                        }

                        //Аналогично для middleName и password (если реализована обработка паролей)

                        MessageBox.Show("Данные успешно изменены");
                        firstNameEditField.Text = "";
                        lastNameEditField.Text = "";
                        middleNameEditField.Text = "";
                        passwordEditField.Text = "";
                        repassEditField.Text = "";
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

        private bool ValidateName(string name, string fieldName, TextBox textBox)
        {

            if (name.Length < 2 && name.Length != 0)
            {
                textBox.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show($"{fieldName} должно содержать минимум 2 символа!");
                return false;
            }
            if (Regex.IsMatch(name, @"\d"))
            {
                textBox.BackColor = System.Drawing.Color.Salmon;
                MessageBox.Show($"{fieldName} не должно содержать цифры!");
                return false;
            }
            return true;
        }
        private bool ValidatePassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 8;
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(_curruser);
            this.Close();
            cabinet.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            contacts contacts = new contacts(_curruser); contacts.Show(); this.Close();
        }

        private void toContact_Click(object sender, EventArgs e)
        {
            contacts contacts = new contacts(_curruser); contacts.Show(); this.Close();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            adminpanelmenu adminpanelmenu = new adminpanelmenu(_curruser);
            adminpanelmenu.Show();
            this.Close();
        }

        private void pictureToCabinet_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(_curruser);
            this.Close();
            cabinet.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
