namespace EventDriven.Project.UI
{
    partial class Cashier_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Dashboard));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            cashierpayment = new Button();
            cashierlogout = new Button();
            cashierreports = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(41, 313);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(195, 46);
            button1.TabIndex = 128;
            button1.Text = "Payment History";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 127;
            pictureBox1.TabStop = false;
            // 
            // cashierpayment
            // 
            cashierpayment.BackColor = SystemColors.Control;
            cashierpayment.Location = new Point(41, 241);
            cashierpayment.Margin = new Padding(4);
            cashierpayment.Name = "cashierpayment";
            cashierpayment.Size = new Size(195, 46);
            cashierpayment.TabIndex = 126;
            cashierpayment.Text = "Payment";
            cashierpayment.UseVisualStyleBackColor = false;
            // 
            // cashierlogout
            // 
            cashierlogout.BackColor = SystemColors.Control;
            cashierlogout.Location = new Point(11, 466);
            cashierlogout.Margin = new Padding(4);
            cashierlogout.Name = "cashierlogout";
            cashierlogout.Size = new Size(249, 44);
            cashierlogout.TabIndex = 125;
            cashierlogout.Text = "LogOut";
            cashierlogout.UseVisualStyleBackColor = false;
            // 
            // cashierreports
            // 
            cashierreports.BackColor = SystemColors.Control;
            cashierreports.Location = new Point(37, 388);
            cashierreports.Margin = new Padding(4);
            cashierreports.Name = "cashierreports";
            cashierreports.Size = new Size(195, 42);
            cashierreports.TabIndex = 124;
            cashierreports.Text = "Reports";
            cashierreports.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(-3, -4);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 793);
            textBox1.TabIndex = 123;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Location = new Point(313, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 653);
            panel1.TabIndex = 129;
            // 
            // Cashier_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 740);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(cashierpayment);
            Controls.Add(cashierlogout);
            Controls.Add(cashierreports);
            Controls.Add(textBox1);
            Name = "Cashier_Dashboard";
            Text = "Cashier_Dashboard";
            Load += Cashier_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button cashierpayment;
        private Button cashierlogout;
        private Button cashierreports;
        private TextBox textBox1;
        private Panel panel1;
    }
}