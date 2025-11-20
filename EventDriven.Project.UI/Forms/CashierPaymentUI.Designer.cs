namespace EventDriven.Project.UI
{
    partial class CashierPaymentUI
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 31);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(59, 88);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(893, 724);
            dataGridView1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(1741, 37);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 104);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 140);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(97, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 499);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 39);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 4;
            label4.Text = "Payment Received:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 155);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 5;
            label5.Text = "Change:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 200);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 6;
            label6.Text = "Remaining Balance:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 31);
            textBox2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(146, 413);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Pay";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(376, 413);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 10;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 270);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 11;
            label7.Text = "Payment Status:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(146, 330);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 29);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Full Payment";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(349, 330);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(157, 29);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Partial Payment";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(201, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 79);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 22);
            label1.Name = "label1";
            label1.Size = new Size(239, 30);
            label1.TabIndex = 0;
            label1.Text = "Payment Information:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1022, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 724);
            panel1.TabIndex = 7;
            // 
            // CashierPaymentUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CashierPaymentUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierPaymentUI";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private Label label1;
        private Panel panel1;
    }
}