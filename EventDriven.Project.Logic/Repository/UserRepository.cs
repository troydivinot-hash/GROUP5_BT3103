using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using System.Data.SqlClient;

namespace EventDriven.Project.Logic.Repository
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EventDriven.Project.DB;Integrated Security=True;TrustServerCertificate=True";

        public UserModel ValidateUser(string Username, string Password)//Form1 Validate User
        {

            try
            {
                using (SqlConnection Hotel = new SqlConnection(CONNECTIONSTRING))
                {
                    Hotel.Open();
                    string query = "SELECT Id, Username, Password, Roles FROM dbo.[TblUser] WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, Hotel))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate model with Role as well
                                return new UserModel
                                {
                                    Id = (int)reader["Id"],
                                    Username = reader["Username"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Role = reader["Roles"].ToString() // ✅ Role from DB
                                };
                            }
                        }
                    }
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return null;

        }
        public UserModel getUserByUserId(string UserIdParam)
        {
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection myConnection = new SqlConnection(CONNECTIONSTRING))
                {
                    string oString = "SELECT * FROM User WHERE Id = @userId";
                    using (SqlCommand oCmd = new SqlCommand(oString, myConnection))
                    {
                        oCmd.Parameters.AddWithValue("@UserId", UserIdParam);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {

                                matchingUser.Id = (int)oReader["Id"];
                                matchingUser.Username = oReader["Username"].ToString();
                                matchingUser.Password = oReader["Password"].ToString();
                            }
                            myConnection.Close();

                        }
                    }

                }

                if (matchingUser.Id == 0)
                {
                    throw new Exception("User does not exist");
                }

                return matchingUser;
            }

            catch (Exception ex)
            {

                throw new Exception("An error occurred: " + ex.Message);
            }
        }


    }
}

