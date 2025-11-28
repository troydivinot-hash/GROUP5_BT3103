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
            cbstudenttype = new ComboBox();
            btnsave = new Button();
            lbl = new Label();
            lblstudenttype = new Label();
            txtemail = new TextBox();
            lblemaill = new Label();
            txtcn = new TextBox();
            lblcn = new Label();
            panel3 = new Panel();
            lblrequirements = new Label();
            checkedListBox1 = new CheckedListBox();
            txtaddress = new TextBox();
            lbladdress = new Label();
            cbgender = new ComboBox();
            lblgender = new Label();
            dateTimePickerdate = new DateTimePicker();
            lbldob = new Label();
            txtsuffix = new TextBox();
            lblsuffix = new Label();
            label7 = new Label();
            txtln = new TextBox();
            txtmn = new TextBox();
            lblmn = new Label();
            lblln = new Label();
            txtfn = new TextBox();
            lblfn = new Label();
            panel1 = new Panel();
            Editbtn = new PictureBox();
            Deletebtn = new PictureBox();
            txtsearch = new TextBox();
            btnsearch = new Button();
            panel2 = new Panel();
            StudentRegviewgrid = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Editbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Deletebtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentRegviewgrid).BeginInit();
            SuspendLayout();
            // 
            // cbstudenttype
            // 
            cbstudenttype.FormattingEnabled = true;
            cbstudenttype.Items.AddRange(new object[] { "New", "Old ", "Transferee" });
            cbstudenttype.Location = new Point(252, 445);
            cbstudenttype.Name = "cbstudenttype";
            cbstudenttype.Size = new Size(341, 33);
            cbstudenttype.TabIndex = 97;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ButtonShadow;
            btnsave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(365, 897);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 34);
            btnsave.TabIndex = 96;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += Editbtn_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(307, 552);
            lbl.Name = "lbl";
            lbl.Size = new Size(198, 38);
            lbl.TabIndex = 83;
            lbl.Text = "Requirements";
            // 
            // lblstudenttype
            // 
            lblstudenttype.AutoSize = true;
            lblstudenttype.Location = new Point(362, 402);
            lblstudenttype.Name = "lblstudenttype";
            lblstudenttype.Size = new Size(115, 25);
            lblstudenttype.TabIndex = 82;
            lblstudenttype.Text = "Student Type";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(521, 357);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(311, 31);
            txtemail.TabIndex = 78;
            // 
            // lblemaill
            // 
            lblemaill.AutoSize = true;
            lblemaill.Location = new Point(535, 329);
            lblemaill.Name = "lblemaill";
            lblemaill.Size = new Size(58, 25);
            lblemaill.TabIndex = 77;
            lblemaill.Text = "Email:";
            // 
            // txtcn
            // 
            txtcn.Location = new Point(46, 357);
            txtcn.Name = "txtcn";
            txtcn.Size = new Size(304, 31);
            txtcn.TabIndex = 76;
            // 
            // lblcn
            // 
            lblcn.AutoSize = true;
            lblcn.Location = new Point(52, 329);
            lblcn.Name = "lblcn";
            lblcn.Size = new Size(110, 25);
            lblcn.TabIndex = 75;
            lblcn.Text = "Contact No.:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblrequirements);
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(cbstudenttype);
            panel3.Controls.Add(btnsave);
            panel3.Controls.Add(lbl);
            panel3.Controls.Add(lblstudenttype);
            panel3.Controls.Add(txtemail);
            panel3.Controls.Add(lblemaill);
            panel3.Controls.Add(txtcn);
            panel3.Controls.Add(lblcn);
            panel3.Controls.Add(txtaddress);
            panel3.Controls.Add(lbladdress);
            panel3.Controls.Add(cbgender);
            panel3.Controls.Add(lblgender);
            panel3.Controls.Add(dateTimePickerdate);
            panel3.Controls.Add(lbldob);
            panel3.Controls.Add(txtsuffix);
            panel3.Controls.Add(lblsuffix);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtln);
            panel3.Controls.Add(txtmn);
            panel3.Controls.Add(lblmn);
            panel3.Controls.Add(lblln);
            panel3.Controls.Add(txtfn);
            panel3.Controls.Add(lblfn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(679, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(882, 1024);
            panel3.TabIndex = 9;
            // 
            // lblrequirements
            // 
            lblrequirements.AutoSize = true;
            lblrequirements.BackColor = SystemColors.GradientActiveCaption;
            lblrequirements.Location = new Point(349, 642);
            lblrequirements.Name = "lblrequirements";
            lblrequirements.Size = new Size(120, 25);
            lblrequirements.TabIndex = 100;
            lblrequirements.Text = "Requirements";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Good Moral", "Form 137", "Birthday Certificate" });
            checkedListBox1.Location = new Point(311, 670);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(194, 88);
            checkedListBox1.TabIndex = 98;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(352, 278);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(342, 31);
            txtaddress.TabIndex = 74;
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Location = new Point(365, 250);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(81, 25);
            lbladdress.TabIndex = 73;
            lbladdress.Text = "Address:";
            // 
            // cbgender
            // 
            cbgender.FormattingEnabled = true;
            cbgender.Items.AddRange(new object[] { "Male", "Female" });
            cbgender.Location = new Point(700, 275);
            cbgender.Name = "cbgender";
            cbgender.Size = new Size(137, 33);
            cbgender.TabIndex = 72;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(700, 250);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(73, 25);
            lblgender.TabIndex = 71;
            lblgender.Text = "Gender:";
            // 
            // dateTimePickerdate
            // 
            dateTimePickerdate.Location = new Point(46, 277);
            dateTimePickerdate.Name = "dateTimePickerdate";
            dateTimePickerdate.Size = new Size(297, 31);
            dateTimePickerdate.TabIndex = 70;
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Location = new Point(46, 250);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(116, 25);
            lbldob.TabIndex = 69;
            lbldob.Text = "Date of Birth:";
            // 
            // txtsuffix
            // 
            txtsuffix.Location = new Point(700, 189);
            txtsuffix.Name = "txtsuffix";
            txtsuffix.Size = new Size(83, 31);
            txtsuffix.TabIndex = 68;
            // 
            // lblsuffix
            // 
            lblsuffix.AutoSize = true;
            lblsuffix.Location = new Point(713, 161);
            lblsuffix.Name = "lblsuffix";
            lblsuffix.Size = new Size(60, 25);
            lblsuffix.TabIndex = 67;
            lblsuffix.Text = "Suffix:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(284, 96);
            label7.Name = "label7";
            label7.Size = new Size(287, 38);
            label7.TabIndex = 66;
            label7.Text = "Student Registration";
            // 
            // txtln
            // 
            txtln.Location = new Point(277, 189);
            txtln.Name = "txtln";
            txtln.Size = new Size(217, 31);
            txtln.TabIndex = 65;
            // 
            // txtmn
            // 
            txtmn.Location = new Point(500, 189);
            txtmn.Name = "txtmn";
            txtmn.Size = new Size(194, 31);
            txtmn.TabIndex = 64;
            // 
            // lblmn
            // 
            lblmn.AutoSize = true;
            lblmn.Location = new Point(500, 161);
            lblmn.Name = "lblmn";
            lblmn.Size = new Size(123, 25);
            lblmn.TabIndex = 63;
            lblmn.Text = "Middle Name:";
            // 
            // lblln
            // 
            lblln.AutoSize = true;
            lblln.Location = new Point(277, 161);
            lblln.Name = "lblln";
            lblln.Size = new Size(104, 25);
            lblln.TabIndex = 62;
            lblln.Text = "Last Name: ";
            // 
            // txtfn
            // 
            txtfn.Location = new Point(46, 189);
            txtfn.Name = "txtfn";
            txtfn.Size = new Size(223, 31);
            txtfn.TabIndex = 61;
            // 
            // lblfn
            // 
            lblfn.AutoSize = true;
            lblfn.Location = new Point(46, 161);
            lblfn.Name = "lblfn";
            lblfn.Size = new Size(101, 25);
            lblfn.TabIndex = 60;
            lblfn.Text = "First Name:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Editbtn);
            panel1.Controls.Add(Deletebtn);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(btnsearch);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 1024);
            panel1.TabIndex = 7;
            // 
            // Editbtn
            // 
            Editbtn.Image = Properties.Resources.write;
            Editbtn.Location = new Point(500, 14);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(64, 64);
            Editbtn.SizeMode = PictureBoxSizeMode.AutoSize;
            Editbtn.TabIndex = 7;
            Editbtn.TabStop = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Image = Properties.Resources.bin__1_;
            Deletebtn.Location = new Point(591, 14);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(64, 64);
            Deletebtn.SizeMode = PictureBoxSizeMode.AutoSize;
            Deletebtn.TabIndex = 6;
            Deletebtn.TabStop = false;
            Deletebtn.Click += Deletebtn_Click;
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
            panel2.Controls.Add(StudentRegviewgrid);
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 940);
            panel2.TabIndex = 8;
            // 
            // StudentRegviewgrid
            // 
            StudentRegviewgrid.AllowUserToResizeColumns = false;
            StudentRegviewgrid.AllowUserToResizeRows = false;
            StudentRegviewgrid.BackgroundColor = SystemColors.ControlLightLight;
            StudentRegviewgrid.ColumnHeadersHeight = 34;
            StudentRegviewgrid.Dock = DockStyle.Top;
            StudentRegviewgrid.Location = new Point(0, 0);
            StudentRegviewgrid.MultiSelect = false;
            StudentRegviewgrid.Name = "StudentRegviewgrid";
            StudentRegviewgrid.ReadOnly = true;
            StudentRegviewgrid.RowHeadersVisible = false;
            StudentRegviewgrid.RowHeadersWidth = 62;
            StudentRegviewgrid.Size = new Size(679, 940);
            StudentRegviewgrid.TabIndex = 1;
            StudentRegviewgrid.CellClick += StudentRegviewgrid_CellContentClick;
            StudentRegviewgrid.CellContentClick += StudentRegviewgrid_CellContentClick;
            // 
            // UCRegistrationList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCRegistrationList";
            Size = new Size(1561, 1024);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Editbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Deletebtn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentRegviewgrid).EndInit();
            ResumeLayout(false);
        }
        private ComboBox cbstudenttype;
        private Button btnsave;
        private Label lbl;
        private Label lblstudenttype;
        private TextBox txtemail;
        private Label lblemaill;
        private TextBox txtcn;
        private Label lblcn;
        private Panel panel3;
        private TextBox txtaddress;
        private Label lbladdress;
        private ComboBox cbgender;
        private Label lblgender;
        private DateTimePicker dateTimePickerdate;
        private Label lbldob;
        private TextBox txtsuffix;
        private Label lblsuffix;
        private Label label7;
        private TextBox txtln;
        private TextBox txtmn;
        private Label lblmn;
        private Label lblln;
        private TextBox txtfn;
        private Label lblfn;
        private Panel panel1;
        private PictureBox Editbtn;
        private PictureBox Deletebtn;
        private TextBox txtsearch;
        private Button btnsearch;
        private Panel panel2;
        private DataGridView StudentRegviewgrid;
        private Label lblrequirements;
        private CheckedListBox checkedListBox1;

        #endregion
        //private Buttons.UCButtons ucButtons1;
    }
}
