namespace EventDriven.Project.UI.UserControlForms
{
    partial class UCStudentPayment
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label7 = new Label();
            btnprint = new Button();
            btnpay = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 119);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 1;
            label1.Text = "Payment Information:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 220);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 4;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 184);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnprint);
            panel2.Controls.Add(btnpay);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(112, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 499);
            panel2.TabIndex = 5;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 270);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 11;
            label7.Text = "Payment Status:";
            // 
            // btnprint
            // 
            btnprint.Location = new Point(376, 413);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(112, 34);
            btnprint.TabIndex = 10;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            // 
            // btnpay
            // 
            btnpay.Location = new Point(146, 413);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(112, 34);
            btnpay.TabIndex = 9;
            btnpay.Text = "Pay";
            btnpay.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 31);
            textBox2.TabIndex = 4;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 155);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 5;
            label5.Text = "Change:";
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
            // UCStudentPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCStudentPayment";
            Size = new Size(882, 1024);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private Button btnprint;
        private Button btnpay;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
