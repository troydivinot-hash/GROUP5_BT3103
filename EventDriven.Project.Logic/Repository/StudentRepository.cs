using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
                            students.Add(new StudentModel
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
            } 
            catch (Exception e)
            {

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
                        cmd.Parameters.AddWithValue("@Suffix", (object)student.Suffix);
                        cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Address", student.Address);
                        cmd.Parameters.AddWithValue("@Gender", student.Gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", student.ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", (object)student.Email);
                        cmd.Parameters.AddWithValue("@StudentType", student.StudentType);
                        cmd.Parameters.AddWithValue("@FathersName", (object)student.FathersName);
                        cmd.Parameters.AddWithValue("@FathersContact", (object)student.FathersContact);
                        cmd.Parameters.AddWithValue("@MothersName", (object)student.MothersName);
                        cmd.Parameters.AddWithValue("@MothersContact", (object)student.MothersContact);
                        cmd.Parameters.AddWithValue("@GuardianName", (object)student.GuardianName);
                        cmd.Parameters.AddWithValue("@Relationship", (object)student.Relationship);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            { }
        }
      public void RegisterStudent(StudentRegModel model)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();

                    // 1. Check if registration exists
                    bool exists = false;

                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM tblStudentReg WHERE StudentId = @StudentId", con))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentId", model.StudentId);
                        exists = (int)checkCmd.ExecuteScalar() > 0;
                    }

                    // 2. Insert or Update
                    string procedure = exists ? "UpdateStudentReg" : "RegisterStudent";

                    using (SqlCommand cmd = new SqlCommand(procedure, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StudentId", model.StudentId);
                        cmd.Parameters.AddWithValue("@Requirements", model.Requirements);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving student registration: " + ex.Message);
            }
        }


        //public StudentRegModel GetRegistration()
        //{
        //    List<StudentRegModel> students = new List<StudentRegModel>();
        //    using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand("RegisterStudent", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    students.Add(new StudentRegModel()
        //                    {
        //                        Id = reader.GetInt32(0),  // StudentID
        //                        Requirements = reader.GetString(1),
        //                        Section = reader.GetString(2)

        //                    });
        //                }
        //            }
        //        }
        //    }
        //}

        public StudentRegModel GetRegistration(int id)
        {
            StudentRegModel model = null;

            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetStudentRegistration", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentId", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model = new StudentRegModel()
                            {
                                Id = reader.GetInt32(0),
                                StudentId = reader.GetInt32(1),
                                Requirements = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                        }
                    }
                }
            }

            return model;
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
    }
}