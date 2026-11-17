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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            NamaPengguna = new Label();
            txtpengguna = new Guna.UI2.WinForms.Guna2TextBox();
            KataSandi = new Label();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            LupaKataSandi = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 38);
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
            LoginButton.CustomizableEdges = customizableEdges1;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.SteelBlue;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(265, 354);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            label2.Location = new Point(165, 82);
            label2.Name = "label2";
            label2.Size = new Size(459, 23);
            label2.TabIndex = 3;
            label2.Text = "Silahkan masukkan username dan passwoard anda";
            // 
            // NamaPengguna
            // 
            NamaPengguna.AutoSize = true;
            NamaPengguna.BackColor = Color.White;
            NamaPengguna.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaPengguna.Location = new Point(165, 137);
            NamaPengguna.Name = "NamaPengguna";
            NamaPengguna.Size = new Size(153, 21);
            NamaPengguna.TabIndex = 6;
            NamaPengguna.Text = "Nama Pengguna";
            // 
            // txtpengguna
            // 
            txtpengguna.BackColor = Color.Transparent;
            txtpengguna.BorderRadius = 10;
            txtpengguna.CustomizableEdges = customizableEdges3;
            txtpengguna.DefaultText = "";
            txtpengguna.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpengguna.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpengguna.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpengguna.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpengguna.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpengguna.Font = new Font("Segoe UI", 9F);
            txtpengguna.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpengguna.Location = new Point(165, 173);
            txtpengguna.Margin = new Padding(3, 4, 3, 4);
            txtpengguna.Name = "txtpengguna";
            txtpengguna.PlaceholderText = "masukkan nama pengguna";
            txtpengguna.SelectedText = "";
            txtpengguna.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtpengguna.Size = new Size(513, 44);
            txtpengguna.TabIndex = 7;
            // 
            // KataSandi
            // 
            KataSandi.AutoSize = true;
            KataSandi.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KataSandi.Location = new Point(165, 245);
            KataSandi.Name = "KataSandi";
            KataSandi.Size = new Size(103, 21);
            KataSandi.TabIndex = 8;
            KataSandi.Text = "Kata Sandi";
            // 
            // txtpassword
            // 
            txtpassword.BorderRadius = 10;
            txtpassword.CustomizableEdges = customizableEdges5;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe UI", 9F);
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Location = new Point(165, 280);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "masukkan kata sandi";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtpassword.Size = new Size(513, 44);
            txtpassword.TabIndex = 9;
            // 
            // LupaKataSandi
            // 
            LupaKataSandi.AutoSize = true;
            LupaKataSandi.BackColor = Color.Transparent;
            LupaKataSandi.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LupaKataSandi.ForeColor = Color.SteelBlue;
            LupaKataSandi.Location = new Point(474, 245);
            LupaKataSandi.Name = "LupaKataSandi";
            LupaKataSandi.Size = new Size(204, 21);
            LupaKataSandi.TabIndex = 10;
            LupaKataSandi.Text = "Lupa kata sandi anda?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(297, 425);
            label5.Name = "label5";
            label5.Size = new Size(162, 19);
            label5.TabIndex = 11;
            label5.Text = "belum punya akun?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(456, 425);
            label6.Name = "label6";
            label6.Size = new Size(103, 19);
            label6.TabIndex = 12;
            label6.Text = "Daftar disini";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 477);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LupaKataSandi);
            Controls.Add(txtpassword);
            Controls.Add(KataSandi);
            Controls.Add(txtpengguna);
            Controls.Add(NamaPengguna);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Label label2;
        private Label NamaPengguna;
        private Guna.UI2.WinForms.Guna2TextBox txtpengguna;
        private Label KataSandi;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Label LupaKataSandi;
        private Label label5;
        private Label label6;
    }
}
