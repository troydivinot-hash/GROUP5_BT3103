namespace EventDriven.Project.UI.UserControlForms
{
    partial class UCPaymentList
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
            ucButtons1 = new EventDriven.Project.UI.UserControlForms.Buttons.UCButtons();
            txtsearch = new TextBox();
            btnsearch = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ucButtons1);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(btnsearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 89);
            panel1.TabIndex = 1;
            // 
            // ucButtons1
            // 
            ucButtons1.BackColor = Color.Transparent;
            ucButtons1.Location = new Point(417, 10);
            ucButtons1.Name = "ucButtons1";
            ucButtons1.Size = new Size(256, 70);
            ucButtons1.TabIndex = 10;
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
            // UCPaymentList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UCPaymentList";
            Size = new Size(679, 1024);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private Button btnsearch;
        private Buttons.UCButtons ucButtons1;
    }
}
