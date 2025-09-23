using EventDriven.Project.Model;
using EventDriven.Project.Logic.Controller;
namespace EventDriven.Project.UI
{
    public partial class AdminLogin : Form
    {
        private UserController userController;
        int loginAttempt = 4;
        public AdminLogin()
        {
            InitializeComponent();
            userController = new UserController();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            try

            {
                UserModel Admin = userController.ValidateUser(usernametxt.Text, passwordtxt.Text);
                if (Admin != null)

                {
                    if (Admin.Role.Equals("Admin"))
                    {
                        MessageBox.Show("Login Successful! Welcome " + Admin.Username, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminDashboard Admindashboard = new AdminDashboard();
                        Admindashboard.Show();
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
