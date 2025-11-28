namespace EventDriven.Project.UI
{
    partial class Cashier_Login
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
            username = new Label();
            passwordtxt = new TextBox();
            label2 = new Label();
            usernametxt = new TextBox();
            Cashierbtn = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            password = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // usernametxt
            // 
            usernametxt.BackColor = SystemColors.ButtonShadow;
            usernametxt.Location = new Point(348, 57);
            usernametxt.Margin = new Padding(4);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(292, 31);
            usernametxt.TabIndex = 6;
            // 
            // Cashierbtn
            // 
            Cashierbtn.BackColor = SystemColors.ActiveBorder;
            Cashierbtn.ForeColor = SystemColors.ActiveCaptionText;
            Cashierbtn.Location = new Point(422, 159);
            Cashierbtn.Margin = new Padding(4);
            Cashierbtn.Name = "Cashierbtn";
            Cashierbtn.Size = new Size(118, 36);
            Cashierbtn.TabIndex = 5;
            Cashierbtn.Text = "Login";
            Cashierbtn.UseVisualStyleBackColor = false;
            Cashierbtn.Click += Cashierbtn_Click;
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
            label3.Size = new Size(191, 45);
            label3.TabIndex = 7;
            label3.Text = "Hi Cashier! ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Image = Properties.Resources._548607005_1839201253329862_3893103805273494200_n;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(459, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 375);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(passwordtxt);
            panel2.Controls.Add(usernametxt);
            panel2.Controls.Add(Cashierbtn);
            panel2.Location = new Point(22, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 208);
            panel2.TabIndex = 11;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.ActiveBorder;
            backbtn.ForeColor = SystemColors.ActiveCaptionText;
            backbtn.Location = new Point(50, 27);
            backbtn.Margin = new Padding(4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(118, 36);
            backbtn.TabIndex = 12;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Cashier_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(backbtn);
            Controls.Add(panel1);
            Name = "Cashier_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier_Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label username;
        private TextBox passwordtxt;
        private Label label2;
        private TextBox usernametxt;
        private Button Cashierbtn;
        private Label label3;
        private PictureBox pictureBox1;
        private Label password;
        private Panel panel1;
        private Panel panel2;
        private Button backbtn;
    }
}