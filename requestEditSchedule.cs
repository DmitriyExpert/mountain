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
    public partial class requestEditSchedule : Form
    {

        public AuthUser _currUser { get; set; }
        public requestEditSchedule(AuthUser currUser)
        {
            InitializeComponent();
            _currUser = currUser;
        }

        private void requestEditSchedule_Load(object sender, EventArgs e)
        {

        }

        private void closeBtnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
