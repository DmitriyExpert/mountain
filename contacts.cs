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
    public partial class contacts : Form
    {

        public AuthUser _currUser { get; set; }
        private Label labelVisible;
        public contacts(AuthUser currUser)
        {
            InitializeComponent();
            _currUser = currUser;

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

        private void contacts_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void pictureToCabinet_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(_currUser);
            cabinet.Show();
            this.Close();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            adminpanelmenu adminpanelmenu = new adminpanelmenu(_currUser);
            adminpanelmenu.Show();
            this.Close();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            menu menu = new menu(_currUser);
            menu.Show();
            this.Close();
        }

        private void pictureBoxCabinetActive_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(_currUser);
            cabinet.Show();
            this.Close();
        }

        private void cabinetActive_Click(object sender, EventArgs e)
        {
            cabinet cabinet = new cabinet(_currUser);
            cabinet.Show();
            this.Close();
        }
    }
}
