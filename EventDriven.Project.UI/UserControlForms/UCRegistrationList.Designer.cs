namespace EventDriven.Project.UI.UserControlForms
{
    partial class UCRegistrationList
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
            textBox1 = new TextBox();
            search = new Button();
            dataGridView1 = new DataGridView();
            ucButtons1 = new EventDriven.Project.UI.UserControlForms.Buttons.UCButtons();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ucButtons1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(search);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 89);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // search
            // 
            search.Location = new Point(38, 29);
            search.Name = "search";
            search.Size = new Size(99, 34);
            search.TabIndex = 6;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(679, 935);
            dataGridView1.TabIndex = 2;
            // 
            // ucButtons1
            // 
            ucButtons1.BackColor = Color.Transparent;
            ucButtons1.Location = new Point(420, 3);
            ucButtons1.Name = "ucButtons1";
            ucButtons1.Size = new Size(256, 70);
            ucButtons1.TabIndex = 11;
            // 
            // UCRegistrationList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UCRegistrationList";
            Size = new Size(679, 1024);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button search;
        private Buttons.UCButtons ucButtons1;
    }
}
