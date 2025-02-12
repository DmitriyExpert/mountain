﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                MessageBox.Show(table.Rows.Count.ToString());
                DataRow row = table.Rows[0];
                string roleName = row["role_name"]?.ToString() ?? "Роль не определена";
                labelProff.Text = roleName;
            }
            else
            {
                labelProff.Text = "Ошибка";
            }

<<<<<<< HEAD
            fioUser.Text = CurrentUser.LastName + " " + CurrentUser.FirsName + " " + CurrentUser.MiddleName;
=======
            fioUser.Text = CurrentUser.LastName + " " + CurrentUser.FirstName + " " + CurrentUser.MiddleName;
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
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
<<<<<<< HEAD
                            using (MySqlCommand commandNameField = new MySqlCommand("UPDATE mountain.users SET `firs_name` = @fn WHERE `id` = @cuID", connection))
=======
                            using (MySqlCommand commandNameField = new MySqlCommand("UPDATE mountain.users SET `first_name` = @fn WHERE `id` = @cuID", connection))
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
                            {
                                commandNameField.Parameters.AddWithValue("@fn", firstNameEditField.Text);
                                commandNameField.Parameters.AddWithValue("@cuID", _curruser.Id);
                                commandNameField.ExecuteNonQuery();
                            }
<<<<<<< HEAD
                            _curruser.FirsName = firstNameEditField.Text;
=======
                            _curruser.FirstName = firstNameEditField.Text;
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
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
<<<<<<< HEAD
                            if(repassEditField.Text != "" && repassEditField.Text == passwordEditField.Text)
                            {
                                using (MySqlCommand commandLastNameField = new MySqlCommand("UPDATE mountain.users SET `pass` = @p WHERE `id` = @cuID", connection))
                                {
                                    commandLastNameField.Parameters.AddWithValue("@p", passwordEditField.Text);
                                    commandLastNameField.Parameters.AddWithValue("@cuID", _curruser.Id);
                                    commandLastNameField.ExecuteNonQuery();
                                }
            
                            } else
=======
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
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
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

        private void backtomenu_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(_curruser);
            this.Close();
            cabinet.Show();
        }
<<<<<<< HEAD
=======

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
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
    }
}
