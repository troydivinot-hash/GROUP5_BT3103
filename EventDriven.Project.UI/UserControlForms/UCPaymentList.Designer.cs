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
            txtsearch = new TextBox();
            btnsearch = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label11 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            btnprint = new Button();
            btnpay = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(btnsearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1561, 89);
            panel1.TabIndex = 1;
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
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(880, 935);
            dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnprint);
            panel2.Controls.Add(btnpay);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(880, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 710);
            panel2.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 224);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 16;
            label11.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 179);
            label9.Name = "label9";
            label9.Size = new Size(46, 25);
            label9.TabIndex = 15;
            label9.Text = "0.00";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Full Payment", "Partial Payment" });
            comboBox1.Location = new Point(156, 334);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(363, 33);
            comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 294);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 11;
            label7.Text = "Payment Status:";
            // 
            // btnprint
            // 
            btnprint.Location = new Point(268, 533);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(164, 34);
            btnprint.TabIndex = 10;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            // 
            // btnpay
            // 
            btnpay.Location = new Point(268, 469);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(164, 34);
            btnpay.TabIndex = 9;
            btnpay.Text = "Pay";
            btnpay.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 31);
            textBox2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 224);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 6;
            label6.Text = "Remaining Balance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 179);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 5;
            label5.Text = "Change:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 63);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 4;
            label4.Text = "Payment Received:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(918, 250);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 11;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(918, 214);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 10;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1055, 127);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 9;
            label1.Text = "Payment Information:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(995, 250);
            label10.Name = "label10";
            label10.Size = new Size(34, 25);
            label10.TabIndex = 14;
            label10.Text = "(...)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(995, 214);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 13;
            label8.Text = "(Name)";
            // 
            // UCPaymentList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UCPaymentList";
            Size = new Size(1561, 1024);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private Button btnsearch;
        private Panel panel2;
        private Label label11;
        private Label label9;
        private ComboBox comboBox1;
        private Label label7;
        private Button btnprint;
        private Button btnpay;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label8;
        //private Buttons.UCButtons ucButtons1;
    }
}
