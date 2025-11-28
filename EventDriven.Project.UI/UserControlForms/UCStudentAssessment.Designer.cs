namespace EventDriven.Project.UI.UserControlForms
{
    partial class UCStudentAssessment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblName = new Label();
            lz = new Label();
            lblId = new Label();
            lblNames = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1561, 89);
            panel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Location = new Point(507, 319);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 85;
            // 
            // lz
            // 
            lz.AutoSize = true;
            lz.Location = new Point(119, 186);
            lz.Name = "lz";
            lz.Size = new Size(32, 25);
            lz.TabIndex = 75;
            lz.Text = "Id:";
            lz.Click += lz_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(206, 186);
            lblId.Name = "lblId";
            lblId.Size = new Size(81, 25);
            lblId.TabIndex = 79;
            lblId.Text = "Address:";
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.Location = new Point(206, 136);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(81, 25);
            lblNames.TabIndex = 78;
            lblNames.Text = "Address:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 80;
            // 
            // button1
            // 
            button1.Location = new Point(322, 234);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 81;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(119, 292);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 154);
            listBox1.TabIndex = 84;
            // 
            // button2
            // 
            button2.Location = new Point(119, 491);
            button2.Name = "button2";
            button2.Size = new Size(315, 34);
            button2.TabIndex = 83;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UCStudentAssessment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(lblId);
            Controls.Add(lblNames);
            Controls.Add(lz);
            Controls.Add(lblName);
            Controls.Add(panel1);
            Name = "UCStudentAssessment";
            Size = new Size(1561, 1024);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Label lz;
        private Label lblId;
        private Label lblNames;
        private ComboBox comboBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
    }
}
