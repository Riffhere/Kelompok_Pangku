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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Login Berhasil", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 menu = new Form2();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
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
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnHide.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnHide.Text = "Show";
            }
        }


        private void btnhide(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnHide.Text = "Show";
        }

        private void btnhide_Click(object sender, EventArgs e)
        {

        }

        private void NamaPengguna_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

