﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinFormsApp1
{
    public partial class cabinet : Form
    {
        public AuthUser _currUser { get; set; }
        private Label labelVisible;
        public cabinet(AuthUser CurrentUser)
        {
            InitializeComponent();
            if(CurrentUser.RoleId == 2)
            {
                panel.Visible = true;
            } else
            {
                panel.Visible = false;
            }
            DBConnection db = new DBConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role_name FROM mountain.roles where `id` = @parseId", db.getConnection());
            command.Parameters.Add("@parseId", MySqlDbType.VarChar).Value = Convert.ToString(CurrentUser.RoleId);
            

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(table.Rows.Count.ToString());
                DataRow row = table.Rows[0];
                string roleName = row["role_name"]?.ToString() ?? "Роль не определена";
                labelProff.Text = roleName;
            }
            else
            {
                labelProff.Text = CurrentUser.Id.ToString();
            }

            fioUser.Text = CurrentUser.LastName + " " + CurrentUser.FirsName + " " + CurrentUser.MiddleName;
            identifyUser.Text = CurrentUser.Id.ToString() + ' ' + "-";

            _currUser = CurrentUser;
            labelVisible = this.panel;
            functions.SetCurrentUser(_currUser);
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

        private void pictureToCabinet_Click(object sender, EventArgs e)
        {

        }

        private void backtomenu_Click(object sender, EventArgs e)
        {

            menu newmenu = new menu(_currUser);
            this.Close();
            newmenu.Show();
        }

        private void cabinet_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toRedact_Click(object sender, EventArgs e)
        {
            editme editme = new editme(_currUser);
            this.Close();
            editme.Show();
        }
    }
}
