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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

        }

        // -----------------------------
        // FUNCTION TO LOAD USER CONTROL
        // -----------------------------
        private void LoadToPanel3(UserControl uc)
        {
            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }

        // Load into panel2
        private void LoadToPanel2(UserControl uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
        }

        private void adminstinfo_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCInformationList());
            LoadToPanel2(new UCStudentInformation());
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
            LoadToPanel2(new UCStudentHistory());
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
            LoadToPanel3(new UCAssessmentList());
            LoadToPanel2(new UCStudentAssessment());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCRegistrationList());
            LoadToPanel2(new UCStudentRegistration());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadToPanel3(new UCPaymentList());
            LoadToPanel2(new UCStudentPayment());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


    }
}
