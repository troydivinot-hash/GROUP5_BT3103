namespace EventDriven.Project.UI
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
            registrarbtn = new Button();
            passwordtxt = new TextBox();
            username = new Label();
            label2 = new Label();
            cashierbtn = new Button();
            adminbtn = new Button();
            usernametxt = new TextBox();
            label3 = new Label();
            password = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registrarbtn
            // 
            registrarbtn.BackColor = SystemColors.ActiveBorder;
            registrarbtn.ForeColor = SystemColors.ActiveCaptionText;
            registrarbtn.Location = new Point(610, 535);
            registrarbtn.Name = "registrarbtn";
            registrarbtn.Size = new Size(94, 29);
            registrarbtn.TabIndex = 0;
            registrarbtn.Text = "Registrar";
            registrarbtn.UseVisualStyleBackColor = false;
            registrarbtn.Click += button1_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(373, 462);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(234, 27);
            passwordtxt.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.ForeColor = Color.FromArgb(30, 58, 138);
            username.Location = new Point(292, 413);
            username.Name = "username";
            username.Size = new Size(75, 20);
            username.TabIndex = 2;
            username.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(297, 469);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // cashierbtn
            // 
            cashierbtn.BackColor = SystemColors.ActiveBorder;
            cashierbtn.ForeColor = SystemColors.ActiveCaptionText;
            cashierbtn.Location = new Point(447, 535);
            cashierbtn.Name = "cashierbtn";
            cashierbtn.Size = new Size(94, 29);
            cashierbtn.TabIndex = 4;
            cashierbtn.Text = "Cashier";
            cashierbtn.UseVisualStyleBackColor = false;
            // 
            // adminbtn
            // 
            adminbtn.BackColor = SystemColors.ActiveBorder;
            adminbtn.ForeColor = SystemColors.ActiveCaptionText;
            adminbtn.Location = new Point(273, 535);
            adminbtn.Name = "adminbtn";
            adminbtn.Size = new Size(94, 29);
            adminbtn.TabIndex = 5;
            adminbtn.Text = "Admin";
            adminbtn.UseVisualStyleBackColor = false;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(373, 410);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(234, 27);
            usernametxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.FromArgb(30, 58, 138);
            label3.Location = new Point(208, 346);
            label3.Name = "label3";
            label3.Size = new Size(548, 37);
            label3.TabIndex = 7;
            label3.Text = "Lumina Crest High School Enrollment System";
            // 
            // password
            // 
            password.AutoSize = true;
            password.ForeColor = Color.FromArgb(30, 58, 138);
            password.Location = new Point(292, 465);
            password.Name = "password";
            password.Size = new Size(70, 20);
            password.TabIndex = 8;
            password.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.peksur;
            pictureBox1.Location = new Point(353, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 753);
            Controls.Add(pictureBox1);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(usernametxt);
            Controls.Add(adminbtn);
            Controls.Add(cashierbtn);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(passwordtxt);
            Controls.Add(registrarbtn);
            ForeColor = Color.DeepSkyBlue;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "text";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarbtn;
        private TextBox passwordtxt;
        private Label username;
        private Label label2;
        private Button cashierbtn;
        private Button adminbtn;
        private TextBox usernametxt;
        private Label label3;
        private Label password;
        private PictureBox pictureBox1;
    }
}
