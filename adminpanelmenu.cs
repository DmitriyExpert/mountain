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
    public partial class adminpanelmenu : Form
    {
        public AuthUser CurrentUser { get; set; }
        public adminpanelmenu(AuthUser currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminpanelmenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toClient_Click(object sender, EventArgs e)
        {
            menu menu = new menu(CurrentUser);
            this.Close();
            menu.Show();
        }

        private void toRedacUsers_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            redacUsers redUser = new redacUsers(CurrentUser);  
            redUser.Show();
            this.Close();
        }
=======
            redacUsers redUser = new redacUsers(CurrentUser);
            redUser.Show();
            this.Close();
        }

        private void toRedacRoles_Click(object sender, EventArgs e)
        {
            redacRoles redRoles = new redacRoles(CurrentUser);
            redRoles.Show();
            this.Close();
        }

        private void linktoredacRolesMain_Click(object sender, EventArgs e)
        {
            redacRolesMain redacRolesMain = new redacRolesMain(CurrentUser);
            redacRolesMain.Show();
            this.Close();
        }
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
    }
}
