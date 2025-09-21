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
            adminstinfo = new Button();
            adminlogout = new Button();
            adminreports = new Button();
            adminassess = new Button();
            adminstureg = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // adminstinfo
            // 
            adminstinfo.BackColor = SystemColors.Control;
            adminstinfo.Location = new Point(34, 208);
            adminstinfo.Margin = new Padding(4);
            adminstinfo.Name = "adminstinfo";
            adminstinfo.Size = new Size(195, 46);
            adminstinfo.TabIndex = 120;
            adminstinfo.Text = "Student Information";
            adminstinfo.UseVisualStyleBackColor = false;
            // 
            // adminlogout
            // 
            adminlogout.BackColor = SystemColors.Control;
            adminlogout.Location = new Point(34, 654);
            adminlogout.Margin = new Padding(4);
            adminlogout.Name = "adminlogout";
            adminlogout.Size = new Size(195, 44);
            adminlogout.TabIndex = 119;
            adminlogout.Text = "LogOut";
            adminlogout.UseVisualStyleBackColor = false;
            // 
            // adminreports
            // 
            adminreports.BackColor = SystemColors.Control;
            adminreports.Location = new Point(34, 425);
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
            adminassess.Location = new Point(34, 278);
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
            adminstureg.Location = new Point(34, 351);
            adminstureg.Margin = new Padding(4);
            adminstureg.Name = "adminstureg";
            adminstureg.Size = new Size(195, 49);
            adminstureg.TabIndex = 116;
            adminstureg.Text = "Student Registration";
            adminstureg.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(-8, -41);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 793);
            textBox1.TabIndex = 115;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(320, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 653);
            panel1.TabIndex = 122;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngtree_school_classroom_with_chalkboard_and_desk_in_3d_rendering_image_3850971;
            pictureBox2.Location = new Point(0, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(736, 594);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 123;
            pictureBox2.TabStop = false;
            // 
            // Registrar_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 712);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(adminstinfo);
            Controls.Add(adminlogout);
            Controls.Add(adminreports);
            Controls.Add(adminassess);
            Controls.Add(adminstureg);
            Controls.Add(textBox1);
            Name = "Registrar_Dashboard";
            Text = "Registrar_Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button adminstinfo;
        private Button adminlogout;
        private Button adminreports;
        private Button adminassess;
        private Button adminstureg;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}