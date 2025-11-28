using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;
using System.Security.Cryptography.X509Certificates;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlForms
{
    public partial class UCAssessmentList : UserControl
    {
        StudentController studentController;
        private List<StudentModel> studentSearch;
        FormDashboard main;
        public UCAssessmentList(FormDashboard main)
        {
            this.main = main;
            InitializeComponent();
            studentController = new StudentController();
            loadStudents();
        }
        private void loadStudents()
        {
            studentSearch = studentController.GetAllStudents();
            dataGridView1.DataSource = studentSearch;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // prevent crash if header clicked

            // GET ID
            string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value?.ToString();

            // GET NAME (Lastname, Firstname Middlename Suffix)
            string last = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value?.ToString();
            string first = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value?.ToString();
            string middle = dataGridView1.Rows[e.RowIndex].Cells["MiddleName"].Value?.ToString();
            string suffix = dataGridView1.Rows[e.RowIndex].Cells["Suffix"].Value?.ToString();

            // Build full name
            string fullName = $"{last}, {first} {middle} {suffix}".Trim();

            // LOAD USER CONTROL AND PASS DATA
            main.LoadToPanel3(new UCStudentAssessment(fullName, id));
        }


        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                // Clear and rebind full list to prevent column duplication
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = studentSearch;
                return;
            }

            var filtered = studentSearch.Where(s =>
                (!string.IsNullOrEmpty(s.FirstName) && s.FirstName.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.MiddleName) && s.MiddleName.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.LastName) && s.LastName.ToLower().Contains(searchValue)));  // Fixed: was FirstName twice, now includes LastName

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No matching student found.");
            }

            // Clear and bind filtered list to prevent column duplication
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = new BindingSource { DataSource = filtered };
        
    }
    }
}
