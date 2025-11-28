namespace EventDriven.Project.UI
{
    partial class FormDashboard
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
            btnStudentInfo = new Button();
            BtnStudentRegistration = new Button();
            btnAssessment = new Button();
            btnPayment = new Button();
            btnPaymentHistory = new Button();
            btnReports = new Button();
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
            flowLayoutPanel1.Controls.Add(btnStudentInfo);
            flowLayoutPanel1.Controls.Add(BtnStudentRegistration);
            flowLayoutPanel1.Controls.Add(btnAssessment);
            flowLayoutPanel1.Controls.Add(btnPayment);
            flowLayoutPanel1.Controls.Add(btnPaymentHistory);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Location = new Point(66, 355);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(205, 332);
            flowLayoutPanel1.TabIndex = 112;
            // 
            // btnStudentInfo
            // 
            btnStudentInfo.BackColor = SystemColors.ButtonFace;
            btnStudentInfo.Location = new Point(4, 4);
            btnStudentInfo.Margin = new Padding(4);
            btnStudentInfo.Name = "btnStudentInfo";
            btnStudentInfo.Size = new Size(195, 46);
            btnStudentInfo.TabIndex = 106;
            btnStudentInfo.Text = "Student Information";
            btnStudentInfo.UseVisualStyleBackColor = false;
            btnStudentInfo.Visible = false;
            btnStudentInfo.Click += adminstinfo_Click;
            // 
            // BtnStudentRegistration
            // 
            BtnStudentRegistration.BackColor = SystemColors.ButtonFace;
            BtnStudentRegistration.Location = new Point(4, 58);
            BtnStudentRegistration.Margin = new Padding(4);
            BtnStudentRegistration.Name = "BtnStudentRegistration";
            BtnStudentRegistration.Size = new Size(195, 46);
            BtnStudentRegistration.TabIndex = 108;
            BtnStudentRegistration.Text = "Student Registration";
            BtnStudentRegistration.UseVisualStyleBackColor = false;
            BtnStudentRegistration.Visible = false;
            BtnStudentRegistration.Click += button2_Click;
            // 
            // btnAssessment
            // 
            btnAssessment.BackColor = SystemColors.ButtonFace;
            btnAssessment.Location = new Point(4, 112);
            btnAssessment.Margin = new Padding(4);
            btnAssessment.Name = "btnAssessment";
            btnAssessment.Size = new Size(195, 46);
            btnAssessment.TabIndex = 109;
            btnAssessment.Text = "Assesment";
            btnAssessment.UseVisualStyleBackColor = false;
            btnAssessment.Visible = false;
            btnAssessment.Click += button3_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = SystemColors.ButtonFace;
            btnPayment.Location = new Point(4, 166);
            btnPayment.Margin = new Padding(4);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(195, 46);
            btnPayment.TabIndex = 113;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Visible = false;
            btnPayment.Click += button4_Click;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = SystemColors.ButtonFace;
            btnPaymentHistory.Location = new Point(4, 220);
            btnPaymentHistory.Margin = new Padding(4);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(195, 46);
            btnPaymentHistory.TabIndex = 107;
            btnPaymentHistory.Text = "Payment History";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            btnPaymentHistory.Visible = false;
            btnPaymentHistory.Click += button5_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.ButtonFace;
            btnReports.Location = new Point(4, 274);
            btnReports.Margin = new Padding(4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(195, 46);
            btnReports.TabIndex = 110;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Visible = false;
            btnReports.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(337, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1561, 1024);
            panel3.TabIndex = 3;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
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
        private Button btnStudentInfo;
        private Button btnPaymentHistory;
        private Button btnAssessment;
        private Button BtnStudentRegistration;
        private Button button1;
        private Button btnReports;
        private Button button7;
        private Button btnPayment;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
    }
}