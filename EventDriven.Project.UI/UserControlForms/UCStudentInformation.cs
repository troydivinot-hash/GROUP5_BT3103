using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Model;
using EventDriven.Project.UI.UserControlForms.Buttons;

namespace EventDriven.Project.UI.UserControlForms
{
    public partial class UCStudentInformation : UserControl
    {
        public UCStudentInformation()
        {
            InitializeComponent();

        }

        public void LoadStudentInfo(StudentModel selected)
        {
            // Basic info
            txtfn.Text = selected.FirstName;
            txtln.Text = selected.LastName;
            txtmn.Text = selected.MiddleName;
            txtsuffix.Text = selected.Suffix;

            // Birthdate
            dateTimePickerdate.Value = selected.DateOfBirth;

            // Address / Gender
            txtaddress.Text = selected.Address;
            cbgender.Text = selected.Gender;

            // Contact info
            txtcn.Text = selected.ContactNumber;
            txtemail.Text = selected.Email;

            // Student Type
            New.Checked = selected.StudentType == "New";
            checkBox2.Checked = selected.StudentType == "Old";
            checkBox3.Checked = selected.StudentType == "Transferee";

            // Guardian Info
            txtfathername.Text = selected.FathersName;
            txtcn2.Text = selected.FathersContact;

            txtmothername.Text = selected.MothersName;
            txtcn3.Text = selected.MothersContact;

            txtguardian.Text = selected.GuardianName;
            txtrelationship.Text = selected.Relationship;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
        }
    }
}
