namespace EventDriven.Project.UI
{
    partial class Student_Admin_Registration
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
            cbstudenttype = new ComboBox();
            btnsave = new Button();
            label11 = new Label();
            GuardianName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            Suffix = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            StudentType = new DataGridViewTextBoxColumn();
            FathersName = new DataGridViewTextBoxColumn();
            FathersContact = new DataGridViewTextBoxColumn();
            MothersName = new DataGridViewTextBoxColumn();
            MothersContact = new DataGridViewTextBoxColumn();
            Relationship = new DataGridViewTextBoxColumn();
            lblstudenttype = new Label();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            Studentviewgrid = new DataGridView();
            txtemail = new TextBox();
            lblemaill = new Label();
            txtcn = new TextBox();
            lblcn = new Label();
            txtaddress = new TextBox();
            lbladdress = new Label();
            cbgender = new ComboBox();
            lblgender = new Label();
            dateTimePickerdate = new DateTimePicker();
            Editbtn = new Button();
            txtsearch = new TextBox();
            btnsearch = new Button();
            lbldob = new Label();
            txtsuffix = new TextBox();
            lblsuffix = new Label();
            txtln = new TextBox();
            txtmn = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            adminstinfo = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Deletebtn = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            lblmn = new Label();
            lblln = new Label();
            txtfn = new TextBox();
            lblfn = new Label();
            panel2 = new Panel();
            lblmop = new Label();
            lblrequirements = new Label();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Studentviewgrid).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            btnsave.Location = new Point(365, 894);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 34);
            btnsave.TabIndex = 96;
            btnsave.Text = "Add";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(331, 553);
            label11.Name = "label11";
            label11.Size = new Size(176, 38);
            label11.TabIndex = 83;
            label11.Text = "Registration";
            // 
            // GuardianName
            // 
            GuardianName.HeaderText = "GuardianName";
            GuardianName.MinimumWidth = 8;
            GuardianName.Name = "GuardianName";
            GuardianName.Width = 150;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // MiddleName
            // 
            MiddleName.HeaderText = "MiddleName";
            MiddleName.MinimumWidth = 8;
            MiddleName.Name = "MiddleName";
            MiddleName.Width = 150;
            // 
            // Suffix
            // 
            Suffix.HeaderText = "Suffix";
            Suffix.MinimumWidth = 8;
            Suffix.Name = "Suffix";
            Suffix.Width = 150;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "DateOfBirth";
            DateOfBirth.MinimumWidth = 8;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.Width = 150;
            // 
            // ContactNumber
            // 
            ContactNumber.HeaderText = "ContactNumber";
            ContactNumber.MinimumWidth = 8;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // StudentType
            // 
            StudentType.HeaderText = "StudentType";
            StudentType.MinimumWidth = 8;
            StudentType.Name = "StudentType";
            StudentType.Width = 150;
            // 
            // FathersName
            // 
            FathersName.HeaderText = "FathersName";
            FathersName.MinimumWidth = 8;
            FathersName.Name = "FathersName";
            FathersName.Width = 150;
            // 
            // FathersContact
            // 
            FathersContact.HeaderText = "FathersContact";
            FathersContact.MinimumWidth = 8;
            FathersContact.Name = "FathersContact";
            FathersContact.Width = 150;
            // 
            // MothersName
            // 
            MothersName.HeaderText = "MothersName";
            MothersName.MinimumWidth = 8;
            MothersName.Name = "MothersName";
            MothersName.Width = 150;
            // 
            // MothersContact
            // 
            MothersContact.HeaderText = "MothersContact";
            MothersContact.MinimumWidth = 8;
            MothersContact.Name = "MothersContact";
            MothersContact.Width = 150;
            // 
            // Relationship
            // 
            Relationship.HeaderText = "Relationship";
            Relationship.MinimumWidth = 8;
            Relationship.Name = "Relationship";
            Relationship.Width = 150;
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
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Location = new Point(66, 797);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(195, 46);
            button7.TabIndex = 108;
            button7.Text = "LogOut";
            button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.peksur;
            pictureBox1.Location = new Point(45, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            dataGridView1.Size = new Size(679, 1024);
            dataGridView1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(Studentviewgrid);
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(679, 1024);
            panel5.TabIndex = 3;
            // 
            // Studentviewgrid
            // 
            Studentviewgrid.AllowUserToResizeColumns = false;
            Studentviewgrid.AllowUserToResizeRows = false;
            Studentviewgrid.BackgroundColor = SystemColors.ControlLightLight;
            Studentviewgrid.ColumnHeadersHeight = 34;
            Studentviewgrid.Dock = DockStyle.Bottom;
            Studentviewgrid.Location = new Point(0, 90);
            Studentviewgrid.Name = "Studentviewgrid";
            Studentviewgrid.RowHeadersVisible = false;
            Studentviewgrid.RowHeadersWidth = 62;
            Studentviewgrid.Size = new Size(679, 934);
            Studentviewgrid.TabIndex = 0;
            Studentviewgrid.CellContentClick += Studentviewgrid_CellContentClick;
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
            // Editbtn
            // 
            Editbtn.Location = new Point(438, 26);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(93, 34);
            Editbtn.TabIndex = 6;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = true;
            Editbtn.Click += Editbtn_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(1, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 1069);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 111;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(adminstinfo);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Location = new Point(66, 355);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(205, 332);
            flowLayoutPanel1.TabIndex = 112;
            // 
            // adminstinfo
            // 
            adminstinfo.BackColor = SystemColors.ButtonFace;
            adminstinfo.Location = new Point(4, 4);
            adminstinfo.Margin = new Padding(4);
            adminstinfo.Name = "adminstinfo";
            adminstinfo.Size = new Size(195, 46);
            adminstinfo.TabIndex = 106;
            adminstinfo.Text = "Student Information";
            adminstinfo.UseVisualStyleBackColor = false;
            adminstinfo.Click += adminstinfo_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(4, 58);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(195, 46);
            button2.TabIndex = 108;
            button2.Text = "Student Registration";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(4, 112);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(195, 46);
            button3.TabIndex = 109;
            button3.Text = "Assesment";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(4, 166);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(195, 46);
            button4.TabIndex = 113;
            button4.Text = "Payment";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(4, 220);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(195, 46);
            button5.TabIndex = 107;
            button5.Text = "Payment History";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Location = new Point(4, 274);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(195, 46);
            button6.TabIndex = 110;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(546, 26);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(93, 34);
            Deletebtn.TabIndex = 7;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(Deletebtn);
            panel4.Controls.Add(Editbtn);
            panel4.Controls.Add(txtsearch);
            panel4.Controls.Add(btnsearch);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(679, 89);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(337, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 1024);
            panel3.TabIndex = 9;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblmop);
            panel2.Controls.Add(lblrequirements);
            panel2.Controls.Add(checkedListBox2);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(cbstudenttype);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblstudenttype);
            panel2.Controls.Add(txtemail);
            panel2.Controls.Add(lblemaill);
            panel2.Controls.Add(txtcn);
            panel2.Controls.Add(lblcn);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(lbladdress);
            panel2.Controls.Add(cbgender);
            panel2.Controls.Add(lblgender);
            panel2.Controls.Add(dateTimePickerdate);
            panel2.Controls.Add(lbldob);
            panel2.Controls.Add(txtsuffix);
            panel2.Controls.Add(lblsuffix);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtln);
            panel2.Controls.Add(txtmn);
            panel2.Controls.Add(lblmn);
            panel2.Controls.Add(lblln);
            panel2.Controls.Add(txtfn);
            panel2.Controls.Add(lblfn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1016, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 1024);
            panel2.TabIndex = 8;
            // 
            // lblmop
            // 
            lblmop.AutoSize = true;
            lblmop.BackColor = SystemColors.GradientActiveCaption;
            lblmop.Location = new Point(600, 669);
            lblmop.Name = "lblmop";
            lblmop.Size = new Size(154, 25);
            lblmop.TabIndex = 101;
            lblmop.Text = "Mode of Payment";
            // 
            // lblrequirements
            // 
            lblrequirements.AutoSize = true;
            lblrequirements.BackColor = SystemColors.GradientActiveCaption;
            lblrequirements.Location = new Point(155, 669);
            lblrequirements.Name = "lblrequirements";
            lblrequirements.Size = new Size(120, 25);
            lblrequirements.TabIndex = 100;
            lblrequirements.Text = "Requirements";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Partial", "Full" });
            checkedListBox2.Location = new Point(579, 697);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(194, 88);
            checkedListBox2.TabIndex = 99;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Good Moral", "Form 137", "Birthday Certificate" });
            checkedListBox1.Location = new Point(117, 697);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(194, 88);
            checkedListBox1.TabIndex = 98;
            // 
            // Student_Admin_Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Student_Admin_Registration";
            Text = "Student_Admin_Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Studentviewgrid).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbstudenttype;
        private Button btnsave;
        private Label label11;
        private DataGridViewTextBoxColumn GuardianName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn Suffix;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn StudentType;
        private DataGridViewTextBoxColumn FathersName;
        private DataGridViewTextBoxColumn FathersContact;
        private DataGridViewTextBoxColumn MothersName;
        private DataGridViewTextBoxColumn MothersContact;
        private DataGridViewTextBoxColumn Relationship;
        private Label lblstudenttype;
        private Button button7;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private DataGridView Studentviewgrid;
        private TextBox txtemail;
        private Label lblemaill;
        private TextBox txtcn;
        private Label lblcn;
        private TextBox txtaddress;
        private Label lbladdress;
        private ComboBox cbgender;
        private Label lblgender;
        private DateTimePicker dateTimePickerdate;
        private Button Editbtn;
        private TextBox txtsearch;
        private Button btnsearch;
        private Label lbldob;
        private TextBox txtsuffix;
        private Label lblsuffix;
        private TextBox txtln;
        private TextBox txtmn;
        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button adminstinfo;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button Deletebtn;
        private Panel panel4;
        private Panel panel3;
        private Label label7;
        private Label lblmn;
        private Label lblln;
        private TextBox txtfn;
        private Label lblfn;
        private Panel panel2;
        private Label lblmop;
        private Label lblrequirements;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
    }
}