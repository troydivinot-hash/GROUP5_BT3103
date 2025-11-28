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
using System.Data.SqlClient;

namespace EventDriven.Project.UI.UserControlForms
{

    public partial class UCInformationList : UserControl
    {
        private List<StudentModel> studentSearch;
        private string CONNECTIONSTRING = "Data Source=DESKTOP-PK86BAT\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;TrustServerCertificate=True";
        private List<StudentModel> studentRecord;
        int studentId;
       


        public UCInformationList()
        {
            InitializeComponent();
            studentRecord = new List<StudentModel>();

            txtcn.MaxLength = 11;
            txtcn2.MaxLength = 11;
            txtcn3.MaxLength = 11;

            LoadStudentRecords();
        }

        // Method to load student data into the DataGridView
        public UCInformationList(int id, string firstname, string lastname, string Suffix, string middlename,
        string email, string fatherName, string fcontactNumber, string motherName, string mcontactNumber,
        string relationship, string contactNumber, string gender, DateTime birthdate, string Address,
        string guardian, string studentType)
        {
            InitializeComponent();
            studentRecord = new List<StudentModel>();
            studentId = id;
            txtfn.Text = firstname;
            txtln.Text = lastname;
            txtmn.Text = middlename;
            txtsuffix.Text = Suffix;
            txtaddress.Text = Address;
            txtemail.Text = email;
            txtcn.Text = contactNumber;
            cbgender.Text = gender;
            dateTimePickerdate.Value = birthdate;

            txtfathername.Text = fatherName;
            txtcn2.Text = fcontactNumber;
            txtmothername.Text = motherName;
            txtcn3.Text = mcontactNumber;
            txtguardian.Text = guardian;

            txtrelationship.Text = relationship;
            cbstudenttype.Text = studentType;

            txtcn.MaxLength = 11;
            txtcn2.MaxLength = 11;
            txtcn3.MaxLength = 11;
        }

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
                Studentviewgrid.DataSource = null;
                Studentviewgrid.Rows.Clear();
                Studentviewgrid.Columns.Clear();
                Studentviewgrid.DataSource = sortedList;

                // Enable column sorting
                foreach (DataGridViewColumn column in Studentviewgrid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading records: " + ex.Message);
            }
        }



        private void Student_Information_Admin_Load(object sender, EventArgs e)
        {

        }

        private void adminstinfo_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtsearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                // Clear and rebind full list to prevent column duplication
                Studentviewgrid.DataSource = null;
                Studentviewgrid.Rows.Clear();
                Studentviewgrid.Columns.Clear();
                Studentviewgrid.DataSource = studentSearch;
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
            Studentviewgrid.DataSource = null;
            Studentviewgrid.Rows.Clear();
            Studentviewgrid.Columns.Clear();
            Studentviewgrid.DataSource = new BindingSource { DataSource = filtered };
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string lastname = txtln.Text.Trim();
            string firstname = txtfn.Text.Trim();
            string middlename = txtmn.Text.Trim();
            string suffix = txtsuffix.Text.Trim();
            DateTime birthdate = dateTimePickerdate.Value;
            string gender = cbgender.Text;
            string email = txtemail.Text.Trim();
            string address = txtaddress.Text.Trim();
            string contactNumber = txtcn.Text.Trim();
            string fatherName = txtfathername.Text.Trim();
            string fcontactNumber = txtcn2.Text.Trim();
            string motherName = txtmothername.Text.Trim();
            string mcontactNumber = txtcn3.Text.Trim();
            string guardian = txtguardian.Text.Trim();
            string relationship = txtrelationship.Text.Trim();
            string studentType = cbstudenttype.Text;

            // 🚨 REMOVE ID from INSERT — identity should be automatic
            string query = @"INSERT INTO Student 
        (LastName, FirstName, MiddleName, Suffix, DateOfBirth, Address, Gender,
         ContactNumber, Email, StudentType, FathersName, FathersContact, MothersName,
         MothersContact, GuardianName, Relationship)
        VALUES
        (@LastName, @FirstName, @MiddleName, @Suffix, @DateOfBirth, @Address, @Gender,
         @ContactNumber, @Email, @StudentType, @FathersName, @FathersContact, @MothersName,
         @MothersContact, @GuardianName, @Relationship)";

            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@FirstName", firstname);
                    cmd.Parameters.AddWithValue("@MiddleName", middlename);
                    cmd.Parameters.AddWithValue("@Suffix", suffix);
                    cmd.Parameters.AddWithValue("@DateOfBirth", birthdate);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@StudentType", studentType);
                    cmd.Parameters.AddWithValue("@FathersName", fatherName);
                    cmd.Parameters.AddWithValue("@FathersContact", fcontactNumber);
                    cmd.Parameters.AddWithValue("@MothersName", motherName);
                    cmd.Parameters.AddWithValue("@MothersContact", mcontactNumber);
                    cmd.Parameters.AddWithValue("@GuardianName", guardian);
                    cmd.Parameters.AddWithValue("@Relationship", relationship);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Student added successfully!");
                        LoadStudentRecords();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Error: " + ex.Message);
                    }
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (Studentviewgrid.CurrentRow == null)
            {
                MessageBox.Show("Select a student record in the grid first.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // Get the selected student's ID
            int id = Convert.ToInt32(Studentviewgrid.CurrentRow.Cells["ID"].Value);

            // Delete directly from table
            string query = "DELETE FROM Student WHERE ID = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Student record deleted successfully!");
                        LoadStudentRecords(); // Refresh grid
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No record found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error deleting student: " + ex.Message);
            }
        }


        public void DeleteStudent(int studentId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", studentId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting student: " + ex.Message);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (Studentviewgrid.CurrentRow == null)
            {
                MessageBox.Show("Select a student record first.");
                return;
            }

            int id = Convert.ToInt32(Studentviewgrid.CurrentRow.Cells["ID"].Value);

            string query = @"UPDATE Student
                     SET LastName = @LastName,
                         FirstName = @FirstName,
                         MiddleName = @MiddleName,
                         Suffix = @Suffix,
                         DateOfBirth = @DateOfBirth,
                         Address = @Address,
                         Gender = @Gender,
                         ContactNumber = @ContactNumber,
                         Email = @Email,
                         StudentType = @StudentType,
                         FathersName = @FathersName,
                         FathersContact = @FathersContact,
                         MothersName = @MothersName,
                         MothersContact = @MothersContact,
                         GuardianName = @GuardianName,
                         Relationship = @Relationship
                     WHERE ID = @Id";

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
                cmd.Parameters.AddWithValue("@FathersName", txtfathername.Text.Trim());
                cmd.Parameters.AddWithValue("@FathersContact", txtcn2.Text.Trim());
                cmd.Parameters.AddWithValue("@MothersName", txtmothername.Text.Trim());
                cmd.Parameters.AddWithValue("@MothersContact", txtcn3.Text.Trim());
                cmd.Parameters.AddWithValue("@GuardianName", txtguardian.Text.Trim());
                cmd.Parameters.AddWithValue("@Relationship", txtrelationship.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Student updated successfully!");
                        LoadStudentRecords();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No record found to update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error updating: " + ex.Message);
                }
            }
        }

        private void Studentviewgrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = Studentviewgrid.Columns[e.ColumnIndex].Name;

            List<StudentModel> sorted;

            switch (columnName)
            {
                case "ID":
                    sorted = studentSearch.OrderByDescending(s => s.Id).ToList(); // newest first
                    break;
                case "LastName":
                    sorted = studentSearch.OrderBy(s => s.LastName).ToList();
                    break;
                case "FirstName":
                    sorted = studentSearch.OrderBy(s => s.FirstName).ToList();
                    break;
                case "MiddleName":
                    sorted = studentSearch.OrderBy(s => s.MiddleName).ToList();
                    break;
                case "DateOfBirth":
                    sorted = studentSearch.OrderBy(s => s.DateOfBirth).ToList();
                    break;
                default:
                    sorted = studentSearch.ToList();
                    break;
            }

            Studentviewgrid.DataSource = null;
            Studentviewgrid.Rows.Clear();
            Studentviewgrid.Columns.Clear();
            Studentviewgrid.DataSource = sorted;

            // Re-enable automatic sorting for all columns
            foreach (DataGridViewColumn column in Studentviewgrid.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void Studentviewgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure click is on a valid row
            if (e.RowIndex < 0) return;

            DataGridViewRow row = Studentviewgrid.Rows[e.RowIndex];

            // Populate textboxes
            txtln.Text = row.Cells["LastName"].Value?.ToString();
            txtfn.Text = row.Cells["FirstName"].Value?.ToString();
            txtmn.Text = row.Cells["MiddleName"].Value?.ToString();
            txtsuffix.Text = row.Cells["Suffix"].Value?.ToString();
            txtaddress.Text = row.Cells["Address"].Value?.ToString();
            txtcn.Text = row.Cells["ContactNumber"].Value?.ToString();
            txtemail.Text = row.Cells["Email"].Value?.ToString();
            txtfathername.Text = row.Cells["FathersName"].Value?.ToString();
            txtcn2.Text = row.Cells["FathersContact"].Value?.ToString();
            txtmothername.Text = row.Cells["MothersName"].Value?.ToString();
            txtcn3.Text = row.Cells["MothersContact"].Value?.ToString();
            txtguardian.Text = row.Cells["GuardianName"].Value?.ToString();
            txtrelationship.Text = row.Cells["Relationship"].Value?.ToString();

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
