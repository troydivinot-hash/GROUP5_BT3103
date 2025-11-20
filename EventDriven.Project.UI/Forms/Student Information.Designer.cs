namespace EventDriven.Project.UI
{
    partial class Student_Information
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
            dataGridView1 = new DataGridView();
            search = new Button();
            Addbtn = new Button();
            textBox1 = new TextBox();
            Editbtn = new Button();
            Deletebtn = new Button();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1675, 868);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search
            // 
            search.Location = new Point(139, 98);
            search.Name = "search";
            search.Size = new Size(112, 34);
            search.TabIndex = 1;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(1368, 102);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(112, 34);
            Addbtn.TabIndex = 2;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 3;
            // 
            // Editbtn
            // 
            Editbtn.Location = new Point(1509, 101);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(112, 34);
            Editbtn.TabIndex = 4;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(1645, 102);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(112, 34);
            Deletebtn.TabIndex = 5;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(45, 29);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(112, 34);
            backbtn.TabIndex = 6;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Student_Information
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(backbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Editbtn);
            Controls.Add(textBox1);
            Controls.Add(Addbtn);
            Controls.Add(search);
            Controls.Add(dataGridView1);
            Name = "Student_Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Information";
            WindowState = FormWindowState.Maximized;
            Load += Student_Information_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button search;
        private Button Addbtn;
        private TextBox textBox1;
        private Button Editbtn;
        private Button Deletebtn;
        private Button backbtn;
    }
}