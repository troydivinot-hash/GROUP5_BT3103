using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Repository
{
    public class StudentRepository
    {
        private string CONNECTIONSTRING = "Data Source=DESKTOP-PK86BAT\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;TrustServerCertificate=True";

        public List<StudentModel> GetAllStudents()
        {
            // Existing code unchanged
            List<StudentModel> students = new List<StudentModel>();
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetAllStudents", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(new StudentModel()
                                {
                                    Id = reader.GetInt32(0),  // StudentID
                                    LastName = reader.GetString(1),
                                    FirstName = reader.GetString(2),
                                    MiddleName = reader.GetString(3),
                                    Suffix = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    DateOfBirth = reader.GetDateTime(5),
                                    Address = reader.GetString(6),
                                    Gender = reader.GetString(7),
                                    ContactNumber = reader.GetString(8),
                                    Email = reader.IsDBNull(9) ? null : reader.GetString(9),
                                    StudentType = reader.IsDBNull(10) ? null : reader.GetString(10),
                                    FathersName = reader.IsDBNull(11) ? null : reader.GetString(11),
                                    FathersContact = reader.IsDBNull(12) ? null : reader.GetString(12),
                                    MothersName = reader.IsDBNull(13) ? null : reader.GetString(13),
                                    MothersContact = reader.IsDBNull(14) ? null : reader.GetString(14),
                                    GuardianName = reader.IsDBNull(15) ? null : reader.GetString(15),
                                    GuardianContact = reader.IsDBNull(16) ? null : reader.GetString(16),
                                    Relationship = reader.IsDBNull(17) ? null : reader.GetString(17),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving students: " + ex.Message);
            }
            return students;
        }

        // New: Insert a new student
        public void InsertStudent(StudentModel student)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LastName", student.LastName);
                        cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                        cmd.Parameters.AddWithValue("@Suffix", (object)student.Suffix ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Address", student.Address);
                        cmd.Parameters.AddWithValue("@Gender", student.Gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", student.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", (object)student.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StudentType", student.StudentType);
                        cmd.Parameters.AddWithValue("@FathersName", (object)student.FathersName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@FathersContact", (object)student.FathersContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MothersName", (object)student.MothersName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MothersContact", (object)student.MothersContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@GuardianName", (object)student.GuardianName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@GuardianContact", (object)student.GuardianContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Relationship", (object)student.Relationship ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting student: " + ex.Message);
            }
        }

        // New: Update an existing student
        public void UpdateStudent(StudentModel student)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateStudent", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", student.Id);
                        cmd.Parameters.AddWithValue("@LastName", student.LastName);
                        cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                        cmd.Parameters.AddWithValue("@Suffix", (object)student.Suffix ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Address", student.Address);
                        cmd.Parameters.AddWithValue("@Gender", student.Gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", student.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", (object)student.Email ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StudentType", student.StudentType);
                        cmd.Parameters.AddWithValue("@FathersName", (object)student.FathersName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@FathersContact", (object)student.FathersContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MothersName", (object)student.MothersName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MothersContact", (object)student.MothersContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@GuardianName", (object)student.GuardianName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@GuardianContact", (object)student.GuardianContact ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Relationship", (object)student.Relationship ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating student: " + ex.Message);
            }
        }

        // New: Delete a student by ID
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
    }
}