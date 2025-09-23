namespace EventDriven.Project.UI
{
    partial class AdminDashboard
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            adminstinfo = new Button();
            button4 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.peksur;
            pictureBox1.Location = new Point(24, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(adminstinfo);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -44);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 810);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Location = new Point(45, 712);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(195, 46);
            button7.TabIndex = 108;
            button7.Text = "LogOut";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Location = new Point(45, 562);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(195, 46);
            button6.TabIndex = 110;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(45, 491);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(195, 46);
            button5.TabIndex = 107;
            button5.Text = "Payment History";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(45, 296);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(195, 46);
            button3.TabIndex = 109;
            button3.Text = "Assesment";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(45, 363);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(195, 46);
            button2.TabIndex = 108;
            button2.Text = "Student Registration";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(45, 426);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(195, 46);
            button1.TabIndex = 107;
            button1.Text = "Payment";
            button1.UseVisualStyleBackColor = false;
            // 
            // adminstinfo
            // 
            adminstinfo.BackColor = SystemColors.ButtonFace;
            adminstinfo.Location = new Point(45, 229);
            adminstinfo.Margin = new Padding(4);
            adminstinfo.Name = "adminstinfo";
            adminstinfo.Size = new Size(195, 46);
            adminstinfo.TabIndex = 106;
            adminstinfo.Text = "Student Information";
            adminstinfo.UseVisualStyleBackColor = false;
            adminstinfo.Click += adminstinfo_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(392, 349);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(195, 46);
            button4.TabIndex = 106;
            button4.Text = "Student Information";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(331, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 663);
            panel2.TabIndex = 123;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngtree_school_classroom_with_chalkboard_and_desk_in_3d_rendering_image_3850971;
            pictureBox2.Location = new Point(0, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(736, 594);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 740);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button adminstinfo;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button6;
        private Button button7;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}