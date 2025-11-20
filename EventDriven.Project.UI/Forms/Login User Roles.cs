using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class Login_User_Roles : Form
    {
        public Login_User_Roles()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier_Login cashier_Login = new Cashier_Login();
            cashier_Login.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrar_Login registrarlogin = new Registrar_Login();
            registrarlogin.Show();
            this.Hide();

        }

        private void Login_User_Roles_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            loginn loginn = new loginn();
            loginn.Show();
            this.Hide();
        }
    }
}
