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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            adminstinfo = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.peksur;
            pictureBox1.Location = new Point(45, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(1, -44);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 1069);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Location = new Point(66, 797);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(195, 46);
            button7.TabIndex = 108;
            button7.Text = "LogOut";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 111;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(adminstinfo);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Location = new Point(66, 355);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(205, 332);
            flowLayoutPanel1.TabIndex = 112;
            // 
            // adminstinfo
            // 
            adminstinfo.BackColor = SystemColors.ButtonFace;
            adminstinfo.Location = new Point(4, 4);
            adminstinfo.Margin = new Padding(4);
            adminstinfo.Name = "adminstinfo";
            adminstinfo.Size = new Size(195, 46);
            adminstinfo.TabIndex = 106;
            adminstinfo.Text = "Student Information";
            adminstinfo.UseVisualStyleBackColor = false;
            adminstinfo.Click += adminstinfo_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(4, 58);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(195, 46);
            button2.TabIndex = 108;
            button2.Text = "Student Registration";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(4, 112);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(195, 46);
            button3.TabIndex = 109;
            button3.Text = "Assesment";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(4, 166);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(195, 46);
            button4.TabIndex = 113;
            button4.Text = "Payment";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(4, 220);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(195, 46);
            button5.TabIndex = 107;
            button5.Text = "Payment History";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Location = new Point(4, 274);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(195, 46);
            button6.TabIndex = 110;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1016, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 1024);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(337, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 1024);
            panel3.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private Button button6;
        private Button button7;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
    }
}