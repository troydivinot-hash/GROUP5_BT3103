namespace EventDriven.Project.UI
{
    partial class Admin_Assessment
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
            backbtn = new Button();
            Deletebtn = new Button();
            Editbtn = new Button();
            textBox1 = new TextBox();
            Addbtn = new Button();
            search = new Button();
            SuspendLayout();
            // 
            // backbtn
            // 
            backbtn.Location = new Point(76, 10);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(112, 34);
            backbtn.TabIndex = 13;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(1676, 83);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(112, 34);
            Deletebtn.TabIndex = 12;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Editbtn
            // 
            Editbtn.Location = new Point(1540, 82);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(112, 34);
            Editbtn.TabIndex = 11;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 10;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(1399, 83);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(112, 34);
            Addbtn.TabIndex = 9;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Location = new Point(170, 79);
            search.Name = "search";
            search.Size = new Size(112, 34);
            search.TabIndex = 8;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // Admin_Assessment
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
            Name = "Admin_Assessment";
            Text = "Admin_Assessment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backbtn;
        private Button Deletebtn;
        private Button Editbtn;
        private TextBox textBox1;
        private Button Addbtn;
        private Button search;
    }
}