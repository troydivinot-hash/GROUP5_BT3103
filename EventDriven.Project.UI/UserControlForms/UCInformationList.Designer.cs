namespace EventDriven.Project.UI.UserControlForms
{
    partial class UCInformationList
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // ucButtons1
            // 
            ucButtons1.BackColor = Color.Transparent;
            ucButtons1.Location = new Point(423, 3);
            ucButtons1.Name = "ucButtons1";
            ucButtons1.Size = new Size(256, 70);
            ucButtons1.TabIndex = 11;
            ucButtons1.Load += ucButtons1_Load;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(146, 29);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(258, 31);
            txtsearch.TabIndex = 5;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(37, 27);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(93, 34);
            btnsearch.TabIndex = 4;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 935);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(679, 935);
            dataGridView1.TabIndex = 1;
            // 
            // UCInformationList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCInformationList";
            Size = new Size(679, 1024);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private Button btnsearch;
        private Buttons.UCButtons ucButtons1;
    }
}
