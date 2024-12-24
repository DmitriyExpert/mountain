using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class menu : Form
    {

        public AuthUser CurrentUser { get; set; }
        private Label labelVisible;
        public menu(AuthUser user)
        {
            InitializeComponent();
            CurrentUser = user;
            labelVisible = this.toPanelAdm;
            functions.SetCurrentUser(CurrentUser);
            functions.panelVisible(this, EventArgs.Empty, labelVisible);
        }

        public menu()
        {
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureToCabinet_Click(object sender, EventArgs e)
        {
            cabinet PICTocab = new cabinet(CurrentUser);
            PICTocab.Show();
            this.Close();
        }

        private void toCabinet_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(CurrentUser);
            cabinet.Show();
            this.Close();
        }

        private void toPanelAdm_Click(object sender, EventArgs e)
        {
            adminpanelmenu admMenu = new adminpanelmenu(CurrentUser);
            this.Close();
            admMenu.Show();
        }

        private void toContact_Click(object sender, EventArgs e)
        {
            contacts contacts = new contacts(CurrentUser);
            contacts.Show();
            this.Close();
        }
    }
}
