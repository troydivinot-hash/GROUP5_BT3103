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
            Editbtn = new PictureBox();
            Deletebtn = new PictureBox();
            txtsearch = new TextBox();
            btnsearch = new Button();
            panel2 = new Panel();
            Studentviewgrid = new DataGridView();
            lblfn = new Label();
            txtfn = new TextBox();
            lblln = new Label();
            lblmn = new Label();
            txtmn = new TextBox();
            txtln = new TextBox();
            label7 = new Label();
            lblsuffix = new Label();
            txtsuffix = new TextBox();
            lbldob = new Label();
            dateTimePickerdate = new DateTimePicker();
            lblgender = new Label();
            cbgender = new ComboBox();
            lbladdress = new Label();
            txtaddress = new TextBox();
            lblcn = new Label();
            txtcn = new TextBox();
            lblemaill = new Label();
            txtemail = new TextBox();
            lblstudenttype = new Label();
            label11 = new Label();
            lblfathername = new Label();
            lblmothername = new Label();
            txtfathername = new TextBox();
            txtmothername = new TextBox();
            lblcn2 = new Label();
            lblcn3 = new Label();
            txtcn2 = new TextBox();
            txtcn3 = new TextBox();
            lblguardian = new Label();
            txtguardian = new TextBox();
            lblrelationship = new Label();
            txtrelationship = new TextBox();
            btnsave = new Button();
            cbstudenttype = new ComboBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Editbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Deletebtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Studentviewgrid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 0;
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
            panel2.Controls.Add(Studentviewgrid);
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 1024);
            panel2.TabIndex = 1;
            // 
            // Studentviewgrid
            // 
            Studentviewgrid.AllowUserToOrderColumns = true;
            Studentviewgrid.AllowUserToResizeColumns = false;
            Studentviewgrid.AllowUserToResizeRows = false;
            Studentviewgrid.BackgroundColor = SystemColors.ControlLightLight;
            Studentviewgrid.ColumnHeadersHeight = 34;
            Studentviewgrid.Dock = DockStyle.Top;
            Studentviewgrid.Location = new Point(0, 0);
            Studentviewgrid.Name = "Studentviewgrid";
            Studentviewgrid.RowHeadersVisible = false;
            Studentviewgrid.RowHeadersWidth = 62;
            Studentviewgrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Studentviewgrid.Size = new Size(679, 931);
            Studentviewgrid.TabIndex = 0;
            Studentviewgrid.CellContentClick += Studentviewgrid_CellContentClick;
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
            // txtfn
            // 
            txtfn.Location = new Point(46, 189);
            txtfn.Name = "txtfn";
            txtfn.Size = new Size(223, 31);
            txtfn.TabIndex = 61;
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
            // lblmn
            // 
            lblmn.AutoSize = true;
            lblmn.Location = new Point(500, 161);
            lblmn.Name = "lblmn";
            lblmn.Size = new Size(123, 25);
            lblmn.TabIndex = 63;
            lblmn.Text = "Middle Name:";
            // 
            // txtmn
            // 
            txtmn.Location = new Point(500, 189);
            txtmn.Name = "txtmn";
            txtmn.Size = new Size(194, 31);
            txtmn.TabIndex = 64;
            // 
            // txtln
            // 
            txtln.Location = new Point(277, 189);
            txtln.Name = "txtln";
            txtln.Size = new Size(217, 31);
            txtln.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(284, 96);
            label7.Name = "label7";
            label7.Size = new Size(287, 38);
            label7.TabIndex = 66;
            label7.Text = "Student Information";
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
            // txtsuffix
            // 
            txtsuffix.Location = new Point(700, 189);
            txtsuffix.Name = "txtsuffix";
            txtsuffix.Size = new Size(83, 31);
            txtsuffix.TabIndex = 68;
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
            // dateTimePickerdate
            // 
            dateTimePickerdate.Location = new Point(46, 277);
            dateTimePickerdate.Name = "dateTimePickerdate";
            dateTimePickerdate.Size = new Size(297, 31);
            dateTimePickerdate.TabIndex = 70;
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
            // cbgender
            // 
            cbgender.FormattingEnabled = true;
            cbgender.Items.AddRange(new object[] { "Male", "Female" });
            cbgender.Location = new Point(700, 275);
            cbgender.Name = "cbgender";
            cbgender.Size = new Size(137, 33);
            cbgender.TabIndex = 72;
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
            // txtaddress
            // 
            txtaddress.Location = new Point(352, 278);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(342, 31);
            txtaddress.TabIndex = 74;
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
            // txtcn
            // 
            txtcn.Location = new Point(46, 357);
            txtcn.Name = "txtcn";
            txtcn.Size = new Size(304, 31);
            txtcn.TabIndex = 76;
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
            // txtemail
            // 
            txtemail.Location = new Point(521, 357);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(311, 31);
            txtemail.TabIndex = 78;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(272, 549);
            label11.Name = "label11";
            label11.Size = new Size(321, 38);
            label11.TabIndex = 83;
            label11.Text = "Guardian's Information";
            // 
            // lblfathername
            // 
            lblfathername.AutoSize = true;
            lblfathername.Location = new Point(128, 625);
            lblfathername.Name = "lblfathername";
            lblfathername.Size = new Size(128, 25);
            lblfathername.TabIndex = 84;
            lblfathername.Text = "Father's Name:";
            // 
            // lblmothername
            // 
            lblmothername.AutoSize = true;
            lblmothername.Location = new Point(128, 691);
            lblmothername.Name = "lblmothername";
            lblmothername.Size = new Size(138, 25);
            lblmothername.TabIndex = 85;
            lblmothername.Text = "Mother's Name:";
            // 
            // txtfathername
            // 
            txtfathername.Location = new Point(114, 653);
            txtfathername.Name = "txtfathername";
            txtfathername.Size = new Size(261, 31);
            txtfathername.TabIndex = 86;
            // 
            // txtmothername
            // 
            txtmothername.Location = new Point(114, 719);
            txtmothername.Name = "txtmothername";
            txtmothername.Size = new Size(261, 31);
            txtmothername.TabIndex = 87;
            // 
            // lblcn2
            // 
            lblcn2.AutoSize = true;
            lblcn2.Location = new Point(492, 625);
            lblcn2.Name = "lblcn2";
            lblcn2.Size = new Size(110, 25);
            lblcn2.TabIndex = 88;
            lblcn2.Text = "Contact No.:";
            // 
            // lblcn3
            // 
            lblcn3.AutoSize = true;
            lblcn3.Location = new Point(492, 694);
            lblcn3.Name = "lblcn3";
            lblcn3.Size = new Size(110, 25);
            lblcn3.TabIndex = 89;
            lblcn3.Text = "Contact No.:";
            // 
            // txtcn2
            // 
            txtcn2.Location = new Point(481, 653);
            txtcn2.Name = "txtcn2";
            txtcn2.Size = new Size(261, 31);
            txtcn2.TabIndex = 90;
            // 
            // txtcn3
            // 
            txtcn3.Location = new Point(481, 722);
            txtcn3.Name = "txtcn3";
            txtcn3.Size = new Size(261, 31);
            txtcn3.TabIndex = 91;
            // 
            // lblguardian
            // 
            lblguardian.AutoSize = true;
            lblguardian.Location = new Point(128, 759);
            lblguardian.Name = "lblguardian";
            lblguardian.Size = new Size(87, 25);
            lblguardian.TabIndex = 92;
            lblguardian.Text = "Guardian:";
            // 
            // txtguardian
            // 
            txtguardian.Location = new Point(114, 787);
            txtguardian.Name = "txtguardian";
            txtguardian.Size = new Size(261, 31);
            txtguardian.TabIndex = 93;
            // 
            // lblrelationship
            // 
            lblrelationship.AutoSize = true;
            lblrelationship.Location = new Point(490, 762);
            lblrelationship.Name = "lblrelationship";
            lblrelationship.Size = new Size(112, 25);
            lblrelationship.TabIndex = 94;
            lblrelationship.Text = "Relationship:";
            // 
            // txtrelationship
            // 
            txtrelationship.Location = new Point(481, 790);
            txtrelationship.Name = "txtrelationship";
            txtrelationship.Size = new Size(261, 31);
            txtrelationship.TabIndex = 95;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ButtonShadow;
            btnsave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(365, 894);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 34);
            btnsave.TabIndex = 96;
            btnsave.Text = "Add";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(cbstudenttype);
            panel3.Controls.Add(btnsave);
            panel3.Controls.Add(txtrelationship);
            panel3.Controls.Add(lblrelationship);
            panel3.Controls.Add(txtguardian);
            panel3.Controls.Add(lblguardian);
            panel3.Controls.Add(txtcn3);
            panel3.Controls.Add(txtcn2);
            panel3.Controls.Add(lblcn3);
            panel3.Controls.Add(lblcn2);
            panel3.Controls.Add(txtmothername);
            panel3.Controls.Add(txtfathername);
            panel3.Controls.Add(lblmothername);
            panel3.Controls.Add(lblfathername);
            panel3.Controls.Add(label11);
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
            panel3.TabIndex = 6;
            // 
            // UCInformationList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCInformationList";
            Size = new Size(1561, 1024);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Editbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Deletebtn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Studentviewgrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtsearch;
        private Button btnsearch;
        private PictureBox Editbtn;
        private PictureBox Deletebtn;
        private DataGridView Studentviewgrid;
        private Label lblfn;
        private TextBox txtfn;
        private Label lblln;
        private Label lblmn;
        private TextBox txtmn;
        private TextBox txtln;
        private Label label7;
        private Label lblsuffix;
        private TextBox txtsuffix;
        private Label lbldob;
        private DateTimePicker dateTimePickerdate;
        private Label lblgender;
        private ComboBox cbgender;
        private Label lbladdress;
        private TextBox txtaddress;
        private Label lblcn;
        private TextBox txtcn;
        private Label lblemaill;
        private TextBox txtemail;
        private Label lblstudenttype;
        private Label label11;
        private Label lblfathername;
        private Label lblmothername;
        private TextBox txtfathername;
        private TextBox txtmothername;
        private Label lblcn2;
        private Label lblcn3;
        private TextBox txtcn2;
        private TextBox txtcn3;
        private Label lblguardian;
        private TextBox txtguardian;
        private Label lblrelationship;
        private TextBox txtrelationship;
        private Button btnsave;
        private ComboBox cbstudenttype;
        private Panel panel3;
        //private Buttons.UCButtons ucButtons1;
    }
}
