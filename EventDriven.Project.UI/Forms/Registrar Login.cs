using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class Registrar_Login : Form
    {
        private UserController userController;
        int loginAttempt = 4;

        public Registrar_Login()
        {
            InitializeComponent();
            userController = new UserController();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {

        }

        private void Registrarbtn_Click(object sender, EventArgs e)
        {
            try

            {
                UserModel Registrar = userController.ValidateUser(usernametxt.Text, passwordtxt.Text);
                if (Registrar != null)

                {
                    if (Registrar.Role.Equals("Registrar"))
                    {
                        MessageBox.Show("Login Successful! Welcome " + Registrar.Username, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormDashboard Registrardashboard = new FormDashboard(Registrar.Role);
                        Registrardashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        loginAttempt--;
                        throw new Exception("Invalid Credentials");
                    }

                }
                else
                {
                    loginAttempt--;
                    throw new Exception("Invalid Credentials");
                }

            }
            catch (Exception ex)
            {
                if (loginAttempt == 0)
                {
                    MessageBox.Show("No more Login Attempts left");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Login_User_Roles login_User_Roles = new Login_User_Roles();
            login_User_Roles.Show();
            this.Hide();
        }
    }
}
