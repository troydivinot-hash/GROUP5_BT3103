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
using System.Data.SqlClient;

namespace EventDriven.Project.UI.UserControlForms
{
    public partial class UCStudentAssessment : UserControl
    {
        private string CONNECTIONSTRING = "Data Source=DESKTOP-PK86BAT\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;TrustServerCertificate=True";
        List<string> subjects = new List<string>
{
    "Mathematics",
    "English",
    "Science",
    "Filipino",
    "Araling Panlipunan",
    "MAPEH",
    "Edukasyon sa Pagpapakatao (ESP)",
    "Computer / ICT",
    "Programming Fundamentals",
    "Physical Education",
    "Health",
    "Music",
    "Arts",
    "Media Information Literacy",
    "Oral Communication",
    "Reading and Writing",
    "21st Century Literature",
    "Earth and Life Science",
    "Physical Science",
    "Statistics and Probability"
};

        public UCStudentAssessment(string name, string id/*, string grade*/)
        {
            InitializeComponent();
            comboBox1.DataSource = subjects;
            lblNames.Text = name;
            lblId.Text = id;
            //lblGrade.Text = grade;
            listBox1.DisplayMember = "SubjectName";
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            int studentId = Convert.ToInt32(lblId.Text);

            listBox1.Items.Clear();

            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                string query = @"
            SELECT s.SubjectName 
            FROM tblStudentSubject ss
            INNER JOIN tblSubject s ON ss.SubjectId = s.SubjectID
            WHERE ss.StudentId = @StudentId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["SubjectName"].ToString());
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Example: subject selected from comboBoxSubject
            string selected = comboBox1.Text;

            if (selected == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            // Prevent duplicates
            foreach (var item in listBox1.Items)
            {
                if (selected.Equals(item))
                {
                    MessageBox.Show("Subject already added.");
                    return;
                }
            }

            // Add to listbox (display name but keep ID internally)
            listBox1.Items.Add(selected);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No subjects to save.");
                return;
            }

            int studentId = Convert.ToInt32(lblId.Text);

            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();

                foreach (var item in listBox1.Items)
                {
                    string subject = item.ToString();
                    int subjectId = GetSubjectIdByName(subject);

                    if (subjectId == -1)
                        continue;

                    // Check if this student already has this subject
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM tblStudentSubject WHERE StudentId=@StudentId AND SubjectId=@SubjectId", con))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentId", studentId);
                        checkCmd.Parameters.AddWithValue("@SubjectId", subjectId);

                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                            continue; // Skip if already exists
                    }

                    // Insert new subject
                    using (SqlCommand cmd = new SqlCommand("addSubjectToStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        cmd.Parameters.AddWithValue("@SubjectId", subjectId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("New subjects saved successfully!");
        }



        private int GetSubjectIdByName(string subjectName)
        {
            // This method should return the subject ID based on the subject name.
            // You may need to query your database or have a predefined mapping.
            // For demonstration, let's assume a simple mapping:
            Dictionary<string, int> subjectMapping = new Dictionary<string, int>
        {
            {"Mathematics", 1},
            {"English", 2},
            {"Science", 3},
            {"Filipino", 4},
            {"Araling Panlipunan", 5},
            {"MAPEH", 6},
            {"Edukasyon sa Pagpapakatao (ESP)", 7},
            {"Computer / ICT", 8},
            {"Programming Fundamentals", 9},
            {"Physical Education", 10},
            {"Health", 11},
            {"Music", 12},
            {"Arts", 13},
            {"Media Information Literacy", 14},
            {"Oral Communication", 15},
            {"Reading and Writing", 16},
            {"21st Century Literature", 17},
            {"Earth and Life Science", 18},
            {"Physical Science", 19},
            {"Statistics and Probability", 20}
        };
            return subjectMapping.ContainsKey(subjectName) ? subjectMapping[subjectName] : -1;
        }

        private void lz_Click(object sender, EventArgs e)
        {

        }
    }
}