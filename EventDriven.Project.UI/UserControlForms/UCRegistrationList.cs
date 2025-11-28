using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlForms
{
    public partial class UCRegistrationList : UserControl
    {
        private List<StudentModel> studentSearch;
        private List<StudentModel> studentRecords;
        private string CONNECTIONSTRING = "Data Source=DESKTOP-PK86BAT\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;TrustServerCertificate=True";
        private int selectedStudentId;

        int studentId;
        public UCRegistrationList()
        {
            InitializeComponent();
            studentRecords = new List<StudentModel>();

            txtcn.MaxLength = 11;

            LoadStudentRecords();

            // Subscribe to CellClick
            StudentRegviewgrid.CellContentClick += StudentRegviewgrid_CellContentClick;
        }

        // Load student records into DataGridView
        public void LoadStudentRecords()
        {
            try
            {
                studentSearch = new List<StudentModel>();  // Clear list

                string query = @"SELECT 
            ID, LastName, FirstName, MiddleName, Suffix,
            DateOfBirth, Address, Gender, ContactNumber, Email,
            StudentType, FathersName, FathersContact,
            MothersName, MothersContact, GuardianName,
            Relationship
         FROM Student";

                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentSearch.Add(new StudentModel
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                LastName = reader["LastName"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                MiddleName = reader["MiddleName"].ToString(),
                                Suffix = reader["Suffix"].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                StudentType = reader["StudentType"].ToString(),
                                FathersName = reader["FathersName"].ToString(),
                                FathersContact = reader["FathersContact"].ToString(),
                                MothersName = reader["MothersName"].ToString(),
                                MothersContact = reader["MothersContact"].ToString(),
                                GuardianName = reader["GuardianName"].ToString(),
                                Relationship = reader["Relationship"].ToString()
                            });
                        }
                    }
                }

                // Sort ascending (ID 1–50)
                var sortedList = studentSearch.OrderBy(s => s.Id).ToList();

                // Clear grid and bind
                StudentRegviewgrid.DataSource = null;
                StudentRegviewgrid.Rows.Clear();
                StudentRegviewgrid.Columns.Clear();
                StudentRegviewgrid.DataSource = sortedList;

                // Enable column sorting
                foreach (DataGridViewColumn column in StudentRegviewgrid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading records: " + ex.Message);
            }
        }


        // Populate input fields when a cell is clicked
        private void StudentRegviewgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = StudentRegviewgrid.Rows[e.RowIndex];

            txtln.Text = row.Cells["LastName"].Value?.ToString();
            txtfn.Text = row.Cells["FirstName"].Value?.ToString();
            txtmn.Text = row.Cells["MiddleName"].Value?.ToString();
            txtsuffix.Text = row.Cells["Suffix"].Value?.ToString();
            txtaddress.Text = row.Cells["Address"].Value?.ToString();
            txtcn.Text = row.Cells["ContactNumber"].Value?.ToString();
            txtemail.Text = row.Cells["Email"].Value?.ToString();

            cbgender.SelectedItem = row.Cells["Gender"].Value?.ToString();
            cbstudenttype.SelectedItem = row.Cells["StudentType"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                dateTimePickerdate.Value = dob;

            if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int id))
                selectedStudentId = id;
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemChecked(index, false);
            }

            StudentController studentController = new StudentController();
            StudentRegModel reg = studentController.GetRegistration(selectedStudentId);
            SetCheckedOptions(reg.Requirements, reg.PaymentType);
             
        }

        private void SetCheckedOptions(string requirements, string paymentMethod)
        {
            // Split the comma-separated strings into lists (handle "None" gracefully)
            var requirementItems = requirements != null && requirements != "None"
                ? requirements.Split(',').Select(r => r.Trim()).ToList()
                : new List<string>();

            var paymentItems = paymentMethod != null && paymentMethod != "None"
                ? paymentMethod.Split(',').Select(p => p.Trim()).ToList()
                : new List<string>();

            // Clear all current checks
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
            

            // Re-check items that match the stored values
            foreach (var req in requirementItems)
            {
                int index = checkedListBox1.Items.IndexOf(req);
                if (index >= 0)
                    checkedListBox1.SetItemChecked(index, true);
            }

            
            }
            
        
        
        
        private void AdjustCheckedListBoxHeight()
        {
            int itemHeight = checkedListBox1.ItemHeight;
            int itemCount = checkedListBox1.Items.Count;

            // Add space for borders
            checkedListBox1.Height = itemHeight * itemCount + 3;
        }
        private void AdjustCheckedListBoxWidth()
        {
            int maxWidth = 0;

            using (Graphics g = checkedListBox1.CreateGraphics())
            {
                foreach (var item in checkedListBox1.Items)
                {
                    int width = (int)g.MeasureString(item.ToString(), checkedListBox1.Font).Width;
                    if (width > maxWidth)
                        maxWidth = width;
                }
            }

            // Add spacing for the checkbox and scrollbar
            checkedListBox1.Width = maxWidth + 30;
        }

        // Save new student
        private void btnsave_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Student 
                            (LastName, FirstName, MiddleName, Suffix, DateOfBirth, Address, Gender,
                             ContactNumber, Email, StudentType, FathersName, FathersContact,
                             MothersName, MothersContact, GuardianName, Relationship)
                             VALUES
                             (@LastName, @FirstName, @MiddleName, @Suffix, @DateOfBirth, @Address, @Gender,
                              @ContactNumber, @Email, @StudentType, @FathersName, @FathersContact,
                              @MothersName, @MothersContact, @GuardianName, @Relationship)";

            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@LastName", txtln.Text.Trim());
                cmd.Parameters.AddWithValue("@FirstName", txtfn.Text.Trim());
                cmd.Parameters.AddWithValue("@MiddleName", txtmn.Text.Trim());
                cmd.Parameters.AddWithValue("@Suffix", txtsuffix.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePickerdate.Value);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", cbgender.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txtcn.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentType", cbstudenttype.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Student added successfully!");
                    LoadStudentRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error saving student: " + ex.Message);
                }
            }
            
        }

        // Edit selected student
        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            string query = @"UPDATE Student
                             SET LastName=@LastName, FirstName=@FirstName, MiddleName=@MiddleName, Suffix=@Suffix,
                                 DateOfBirth=@DateOfBirth, Address=@Address, Gender=@Gender, ContactNumber=@ContactNumber,
                                 Email=@Email, StudentType=@StudentType
                             WHERE ID=@Id";

            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@LastName", txtln.Text.Trim());
                cmd.Parameters.AddWithValue("@FirstName", txtfn.Text.Trim());
                cmd.Parameters.AddWithValue("@MiddleName", txtmn.Text.Trim());
                cmd.Parameters.AddWithValue("@Suffix", txtsuffix.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePickerdate.Value);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", cbgender.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txtcn.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentType", cbstudenttype.Text);
                cmd.Parameters.AddWithValue("@Id", selectedStudentId);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Student updated successfully!");
                        LoadStudentRecords(); // Refresh the UI
                                              // Now handle registration after successful update
                                              // Convert checked items to strings (comma-separated for simplicity)
                        string requirements = string.Join(", ", checkedListBox1.CheckedItems.Cast<object>().Select(item => item.ToString()));
                        // Validate that something is selected
                        if (string.IsNullOrWhiteSpace(requirements))
                        {
                            MessageBox.Show("⚠️ Please select at least one requirement and one section for registration.");
                            return;
                        }
                        // Create and populate the model
                        var registerModel = new StudentRegModel
                        {
                            StudentId = selectedStudentId,
                            Requirements = requirements,
                             
                        };
                        // Call the controller to register
                        StudentController controller = new StudentController();
                        controller.RegisterStudent(registerModel);
                        // Display the result
                       
                    }
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error updating student: " + ex.Message);
                }
            }
        }

        // Delete selected student
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string query = "DELETE FROM Student WHERE ID=@Id";

            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", selectedStudentId);
                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Student deleted successfully!");
                        LoadStudentRecords();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No record found to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error deleting student: " + ex.Message);
                }
            }
        }

        // Search students
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                StudentRegviewgrid.DataSource = studentRecords;
                return;
            }

            var filtered = studentRecords.Where(s =>
                s.FirstName.ToLower().Contains(searchText) ||
                s.LastName.ToLower().Contains(searchText) ||
                s.Email.ToLower().Contains(searchText)
            ).ToList();

            if (filtered.Count == 0)
                MessageBox.Show("No matching students found.");

            StudentRegviewgrid.DataSource = filtered;
        }

        private void Studentviewgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure click is on a valid row
            if (e.RowIndex < 0) return;

            DataGridViewRow row = StudentRegviewgrid.Rows[e.RowIndex];

            // Populate textboxes
            txtln.Text = row.Cells["LastName"].Value?.ToString();
            txtfn.Text = row.Cells["FirstName"].Value?.ToString();
            txtmn.Text = row.Cells["MiddleName"].Value?.ToString();
            txtsuffix.Text = row.Cells["Suffix"].Value?.ToString();
            txtaddress.Text = row.Cells["Address"].Value?.ToString();
            txtcn.Text = row.Cells["ContactNumber"].Value?.ToString();
            txtemail.Text = row.Cells["Email"].Value?.ToString();

            // Populate comboboxes
            cbgender.SelectedItem = row.Cells["Gender"].Value?.ToString();
            cbstudenttype.SelectedItem = row.Cells["StudentType"].Value?.ToString();

            // Populate DateTimePicker
            if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                dateTimePickerdate.Value = dob;

            // Save selected student ID
            if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int id))
                studentId = id;
        }
    }
}
