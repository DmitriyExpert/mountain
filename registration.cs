﻿using MySql.Data.MySqlClient;
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
<<<<<<< HEAD
=======
using System.Text.RegularExpressions;
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141

namespace WinFormsApp1
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            passwordtextBox.UseSystemPasswordChar = true;
            repasswordtextBox3.UseSystemPasswordChar=true;
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
        }



        private void closeBtnRegister_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toAuth_Click(object sender, EventArgs e)
        {
            var authForm = new auth();
            this.Close();
            authForm.Show();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
<<<<<<< HEAD
=======
            if (nameTextbox.Text.Length < 2)
            {
                MessageBox.Show("Имя не должно быть из 1 символа");
                return;
            }
            if(lastnameTextbox.Text.Length < 2)
            {
                MessageBox.Show("Фамилия не может состоять из 1 символа"); return;
            }
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            if (lastnameTextbox.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
<<<<<<< HEAD
=======
            if (lastnameTextbox.Text.Length < 2)
            {
                MessageBox.Show("Фамилия не может состоять из 1 символа"); return;
            }
            if (functions.ContainsDigit(lastnameTextbox.Text))
            {
                MessageBox.Show("В фамилии не могут быть цифры");
                return;
            }
            if (functions.ContainsDigit(nameTextbox.Text))
            {
                MessageBox.Show("Имя не может состоять из цифр");
                return;
            }
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
<<<<<<< HEAD
=======
            if(passwordtextBox.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов");
                return;
            }
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            if (repasswordtextBox3.Text == "")
            {
                MessageBox.Show("Введите повторный пароль");
                return;
            }

            if (passwordtextBox.Text != repasswordtextBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают");
<<<<<<< HEAD
                return;
            }

=======
                passwordtextBox.Text = "";
                repasswordtextBox3.Text = "";
                return;
            }

            


>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            if (isUserExists())
            {
                return;
            }



            DBConnection db = new DBConnection();
<<<<<<< HEAD
            MySqlCommand command = new MySqlCommand("INSERT INTO `mountain`.`users` (`firs_name`, `middle_name`, `last_name`, `login`, `pass`, `role_id`) VALUES (@firstName, @middleName, @lastName, @uL, @uP, 1);", db.getConnection());
=======
            MySqlCommand command = new MySqlCommand("INSERT INTO `mountain`.`users` (`first_name`, `middle_name`, `last_name`, `login`, `pass`, `role_id`) VALUES (@firstName, @middleName, @lastName, @uL, @uP, 1);", db.getConnection());
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = nameTextbox.Text;
            if (middleNametextBox.Text == "")
            {
                command.Parameters.Add("@middleName", MySqlDbType.VarChar).Value = middleNametextBox.Text;
            }
            else
            {
                command.Parameters.Add("@middleName", MySqlDbType.VarChar).Value = middleNametextBox.Text;
            }

            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastnameTextbox.Text;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logintextBox.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Class1.hashPassword(passwordtextBox.Text);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");
                auth authForm = new auth();
                this.Close();
                authForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }


            db.closeConnection();

        }

        public Boolean isUserExists()
        {
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM mountain.users WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logintextBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void repasswordtextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
