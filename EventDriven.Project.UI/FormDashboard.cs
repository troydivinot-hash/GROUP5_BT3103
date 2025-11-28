using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.UI.UserControlForms;

namespace EventDriven.Project.UI
{
    public partial class FormDashboard : Form
    {
        string role = "none";
        public FormDashboard(string role)
        {
            InitializeComponent();
            this.role = role;
            removeButton();
            
        }

        private void removeButton()
        {
            btnStudentInfo.Visible = true;
            BtnStudentRegistration.Visible = true;
            btnAssessment.Visible = true;
            btnPayment.Visible = true;
            btnPaymentHistory.Visible = true;
            btnReports.Visible = true;
            if (role.Equals("Cashier"))
            {
                btnStudentInfo.Visible = false;
                BtnStudentRegistration.Visible = false;
                btnAssessment.Visible = false;
            } else if (role.Equals("Registrar"))
            {
                btnPayment.Visible = false;
                btnPaymentHistory.Visible = false;
            }
        }

        // -----------------------------
        // FUNCTION TO LOAD USER CONTROL
        // -----------------------------
        public void LoadToPanel3(UserControl uc)
        {
            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }


        private void adminstinfo_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCInformationList());
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCHistoryList());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Show login form
                loginn loginForm = new loginn();
                loginForm.Show();

                // Close the current dashboard
                this.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCAssessmentList(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCRegistrationList());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCPaymentList());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


    }
}
