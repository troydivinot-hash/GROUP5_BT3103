namespace EventDriven.Project.UI
{
    partial class Registrar_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            password = new Label();
            username = new Label();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            Registrarbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            backbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(131, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 375);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(passwordtxt);
            panel2.Controls.Add(usernametxt);
            panel2.Controls.Add(Registrarbtn);
            panel2.Location = new Point(22, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 208);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Image = Properties.Resources._546226130_24550255771293743_5835087672123755509_n;
            pictureBox1.Location = new Point(21, 14);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // password
            // 
            password.AutoSize = true;
            password.ForeColor = Color.FromArgb(30, 58, 138);
            password.Location = new Point(249, 107);
            password.Margin = new Padding(4, 0, 4, 0);
            password.Name = "password";
            password.Size = new Size(91, 25);
            password.TabIndex = 8;
            password.Text = "Password:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.ForeColor = Color.FromArgb(30, 58, 138);
            username.Location = new Point(249, 57);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(95, 25);
            username.TabIndex = 2;
            username.Text = "Username:";
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = SystemColors.ButtonShadow;
            passwordtxt.Location = new Point(348, 108);
            passwordtxt.Margin = new Padding(4);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(292, 31);
            passwordtxt.TabIndex = 1;
            passwordtxt.UseSystemPasswordChar = true;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = SystemColors.ButtonShadow;
            usernametxt.Location = new Point(348, 57);
            usernametxt.Margin = new Padding(4);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(292, 31);
            usernametxt.TabIndex = 6;
            // 
            // Registrarbtn
            // 
            Registrarbtn.BackColor = SystemColors.ActiveBorder;
            Registrarbtn.ForeColor = SystemColors.ActiveCaptionText;
            Registrarbtn.Location = new Point(422, 159);
            Registrarbtn.Margin = new Padding(4);
            Registrarbtn.Name = "Registrarbtn";
            Registrarbtn.Size = new Size(118, 36);
            Registrarbtn.TabIndex = 5;
            Registrarbtn.Text = "Login";
            Registrarbtn.UseVisualStyleBackColor = false;
            Registrarbtn.Click += Registrarbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 58, 138);
            label3.Location = new Point(43, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 45);
            label3.TabIndex = 7;
            label3.Text = "Hi Registrar! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(284, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.ActiveBorder;
            backbtn.ForeColor = SystemColors.ActiveCaptionText;
            backbtn.Location = new Point(57, 30);
            backbtn.Margin = new Padding(4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(118, 36);
            backbtn.TabIndex = 13;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Registrar_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 521);
            Controls.Add(backbtn);
            Controls.Add(panel1);
            Name = "Registrar_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar_Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label password;
        private Label username;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private Button Registrarbtn;
        private Label label3;
        private Label label2;
        private Button backbtn;
    }
}