namespace EventDriven.Project.UI
{
    partial class Registrar_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_Dashboard));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            adminlogout = new Button();
            adminreports = new Button();
            adminassess = new Button();
            adminstureg = new Button();
            adminstinfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(-8, -41);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 1094);
            textBox1.TabIndex = 115;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Location = new Point(264, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1649, 112);
            panel1.TabIndex = 122;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Location = new Point(264, 922);
            panel2.Name = "panel2";
            panel2.Size = new Size(1649, 112);
            panel2.TabIndex = 123;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Location = new Point(1758, -46);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 1099);
            panel3.TabIndex = 124;
            // 
            // adminlogout
            // 
            adminlogout.BackColor = SystemColors.Control;
            adminlogout.Location = new Point(58, 692);
            adminlogout.Margin = new Padding(4);
            adminlogout.Name = "adminlogout";
            adminlogout.Size = new Size(195, 44);
            adminlogout.TabIndex = 119;
            adminlogout.Text = "LogOut";
            adminlogout.UseVisualStyleBackColor = false;
            adminlogout.Click += adminlogout_Click;
            // 
            // adminreports
            // 
            adminreports.BackColor = SystemColors.Control;
            adminreports.Location = new Point(58, 623);
            adminreports.Margin = new Padding(4);
            adminreports.Name = "adminreports";
            adminreports.Size = new Size(195, 42);
            adminreports.TabIndex = 118;
            adminreports.Text = "Reports";
            adminreports.UseVisualStyleBackColor = false;
            // 
            // adminassess
            // 
            adminassess.BackColor = SystemColors.Control;
            adminassess.Location = new Point(58, 550);
            adminassess.Margin = new Padding(4);
            adminassess.Name = "adminassess";
            adminassess.Size = new Size(195, 46);
            adminassess.TabIndex = 117;
            adminassess.Text = "Assessment";
            adminassess.UseVisualStyleBackColor = false;
            // 
            // adminstureg
            // 
            adminstureg.BackColor = SystemColors.ButtonFace;
            adminstureg.Location = new Point(58, 472);
            adminstureg.Margin = new Padding(4);
            adminstureg.Name = "adminstureg";
            adminstureg.Size = new Size(195, 49);
            adminstureg.TabIndex = 116;
            adminstureg.Text = "Student Registration";
            adminstureg.UseVisualStyleBackColor = false;
            adminstureg.Click += adminstureg_Click;
            // 
            // adminstinfo
            // 
            adminstinfo.BackColor = SystemColors.Control;
            adminstinfo.Location = new Point(58, 403);
            adminstinfo.Margin = new Padding(4);
            adminstinfo.Name = "adminstinfo";
            adminstinfo.Size = new Size(195, 46);
            adminstinfo.TabIndex = 120;
            adminstinfo.Text = "Student Information";
            adminstinfo.UseVisualStyleBackColor = false;
            adminstinfo.Click += adminstinfo_Click;
            // 
            // Registrar_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(adminstinfo);
            Controls.Add(adminstureg);
            Controls.Add(panel3);
            Controls.Add(adminassess);
            Controls.Add(panel2);
            Controls.Add(adminreports);
            Controls.Add(adminlogout);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Name = "Registrar_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar_Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button adminlogout;
        private Button adminreports;
        private Button adminassess;
        private Button adminstureg;
        private Button adminstinfo;
    }
}