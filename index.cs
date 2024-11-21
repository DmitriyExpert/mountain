namespace WinFormsApp1
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconimg_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toAuth_Click(object sender, EventArgs e)
        {
            var authForm = new auth();
            this.Hide();
            authForm.Show();
        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            var regForm = new registration();
            this.Hide();
            regForm.Show();
        }
    }
}
