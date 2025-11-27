namespace demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "admin" && txtUserName.Text == "admin")
            {
                MessageBox.Show("login successful");
            }
        }
    }
}
