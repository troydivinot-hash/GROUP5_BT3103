using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;  // Assuming this is the correct namespace for StudentController
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlForms
{
    public partial class UCInformationList : UserControl
    {
        private StudentController studentController;
        private List<StudentModel> allStudents;  // Store full list for filtering/searching

        public event EventHandler<StudentModel> EditClicked;

        public UCInformationList()
        {
            InitializeComponent();
            studentController = new StudentController();
            LoadData();  // Load data when the UserControl is created
        }

        // Method to load student data into the DataGridView
        private void LoadData()
        {
            try
            {
                allStudents = studentController.GetAllStudents();  // Fetch all students
                if (allStudents != null && allStudents.Count > 0)
                {
                    dataGridView1.DataSource = allStudents;  // Bind to DataGridView
                    dataGridView1.AutoGenerateColumns = true;  // Auto-generate columns
                    dataGridView1.ReadOnly = true;  // Make it read-only for viewing
                    dataGridView1.AllowUserToAddRows = false;  // Prevent adding rows
                    dataGridView1.AllowUserToDeleteRows = false;  // Prevent deleting rows
                }
                else
                {
                    MessageBox.Show("No student data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the search button (filters the DataGridView based on txtSearch input)
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (allStudents == null || allStudents.Count == 0)
            {
                MessageBox.Show("No data to search. Please load data first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchText = txtsearch.Text.Trim().ToLower();  // Get search input (case-insensitive)
            if (string.IsNullOrEmpty(searchText))
            {
                // If search is empty, show all data
                dataGridView1.DataSource = allStudents;
                return;
            }

            // Filter the list by LastName, FirstName, or Email (adjust fields as needed)
            var filteredStudents = allStudents.Where(s =>
                s.LastName.ToLower().Contains(searchText) ||
                s.FirstName.ToLower().Contains(searchText) ||
                s.Email.ToLower().Contains(searchText)
            ).ToList();

            if (filteredStudents.Count > 0)
            {
                dataGridView1.DataSource = filteredStudents;
            }
            else
            {
                MessageBox.Show("No students match the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;  // Clear the grid if no matches
            }
        }

        // Preserved existing event handler
        private void ucButtons1_Load(object sender, EventArgs e)    
        {
            // Add any initialization logic here if needed
        }

        // Optional: Public method to refresh data (callable from parent Form/UserControl)
        public void RefreshData()
        {
            LoadData();
        }


    }
}
