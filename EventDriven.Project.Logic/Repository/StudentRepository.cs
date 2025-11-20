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
    class StudentRepository
    {
        private string CONNECTIONSTRING = "Data Source=DESKTOP-PK86BAT\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;TrustServerCertificate=True";
        public List<StudentModel> GetAllStudents()
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open(); 
                using (SqlCommand cmd = new SqlCommand("GetAllStudents", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<StudentModel> students = new List<StudentModel>();
                        while (reader.Read())
                        {
                            students.Add(new StudentModel()
                            {
                                Id = reader.GetInt32(0),
                                LastName = reader.GetString(1),
                                FirstName = reader.GetString(2),
                                MiddleName = reader.GetString(3),
                                GradeLevel = reader.GetInt32(4),
                                Section = reader.GetString(5),
                                Gender = reader.GetString(6),
                                ContactNumber = reader.GetString(7),
                                Address = reader.GetString(8),
                                EnrollmentStatus = reader.GetString(9)
                            });
                        }
                        return students;
                    }
                }
            }
        }
    }
}
