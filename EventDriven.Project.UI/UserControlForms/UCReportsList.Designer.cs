namespace EventDriven.Project.UI.UserControlForms
{
    partial class UCReportsList
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txtsearch = new TextBox();
            btnsearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(795, 644);
            dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(btnsearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 89);
            panel1.TabIndex = 3;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(156, 30);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(249, 31);
            txtsearch.TabIndex = 9;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(29, 28);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(100, 34);
            btnsearch.TabIndex = 8;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // UCReportsList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UCReportsList";
            Size = new Size(795, 733);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtsearch;
        private Button btnsearch;
    }
}
