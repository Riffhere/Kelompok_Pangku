namespace Pangkuu_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            NamaPengguna = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            KataSandi = new Label();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            LupaKataSandi = new Label();
            btnHide = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnHide).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 32);
            label1.Name = "label1";
            label1.Size = new Size(185, 33);
            label1.TabIndex = 1;
            label1.Text = "Selamat datang";
            label1.Click += label1_Click_1;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.BorderRadius = 6;
            LoginButton.CustomizableEdges = customizableEdges13;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.SteelBlue;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(262, 443);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges14;
            LoginButton.Size = new Size(341, 52);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "LOGIN";
            LoginButton.Click += guna2Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(129, 82);
            label2.Name = "label2";
            label2.Size = new Size(575, 23);
            label2.TabIndex = 3;
            label2.Text = "Silahkan pilih role anda dan masukkan username dan passwoard";
            label2.Click += label2_Click;
            // 
            // NamaPengguna
            // 
            NamaPengguna.AutoSize = true;
            NamaPengguna.BackColor = Color.White;
            NamaPengguna.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaPengguna.Location = new Point(180, 221);
            NamaPengguna.Name = "NamaPengguna";
            NamaPengguna.Size = new Size(110, 21);
            NamaPengguna.TabIndex = 6;
            NamaPengguna.Text = "Ussername";
            NamaPengguna.Click += NamaPengguna_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderRadius = 10;
            txtUsername.CustomizableEdges = customizableEdges15;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(180, 259);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "masukkan ussername";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtUsername.Size = new Size(513, 44);
            txtUsername.TabIndex = 7;
            // 
            // KataSandi
            // 
            KataSandi.AutoSize = true;
            KataSandi.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KataSandi.Location = new Point(180, 331);
            KataSandi.Name = "KataSandi";
            KataSandi.Size = new Size(96, 21);
            KataSandi.TabIndex = 8;
            KataSandi.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges17;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(180, 366);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "masukkan Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtPassword.Size = new Size(513, 44);
            txtPassword.TabIndex = 9;
            // 
            // LupaKataSandi
            // 
            LupaKataSandi.AutoSize = true;
            LupaKataSandi.BackColor = Color.Transparent;
            LupaKataSandi.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LupaKataSandi.ForeColor = Color.SteelBlue;
            LupaKataSandi.Location = new Point(489, 331);
            LupaKataSandi.Name = "LupaKataSandi";
            LupaKataSandi.Size = new Size(204, 21);
            LupaKataSandi.TabIndex = 10;
            LupaKataSandi.Text = "Lupa kata sandi anda?";
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.Transparent;
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.Location = new Point(654, 375);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(25, 26);
            btnHide.SizeMode = PictureBoxSizeMode.Zoom;
            btnHide.TabIndex = 13;
            btnHide.TabStop = false;
            btnHide.Click += btnHide_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(180, 127);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 14;
            label3.Text = "Role";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 507);
            Controls.Add(label3);
            Controls.Add(btnHide);
            Controls.Add(LupaKataSandi);
            Controls.Add(txtPassword);
            Controls.Add(KataSandi);
            Controls.Add(txtUsername);
            Controls.Add(NamaPengguna);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Label label2;
        private Label NamaPengguna;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label KataSandi;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label LupaKataSandi;
        private PictureBox btnHide;
        private Label label3;
    }
}
