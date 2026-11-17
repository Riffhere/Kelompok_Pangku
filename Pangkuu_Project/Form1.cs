namespace Pangkuu_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool passwordVisible = false;

        private void picPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                txtpassword.PasswordChar = '\0';
                btnHide.Text = "Hide";
            }
            else
            {
                txtpassword.PasswordChar = '*';
                btnHide.Text = "Show";
            }
        }


private void btnhide (object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            btnHide.Text = "Show";
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
        
        }

    }
}

