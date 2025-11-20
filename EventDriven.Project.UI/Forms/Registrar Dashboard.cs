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
    public partial class Registrar_Dashboard : Form
    {
        public Registrar_Dashboard()
        {
            InitializeComponent();
        }

        private void adminlogout_Click(object sender, EventArgs e)
        {
            Login_User_Roles login_User_Roles = new Login_User_Roles();
            login_User_Roles.Show();
            this.Close();
        }

        private void adminstinfo_Click(object sender, EventArgs e)
        {
            Student_Information student_Information = new Student_Information();
            student_Information.Show();
            this.Close();
        }

        private void adminstureg_Click(object sender, EventArgs e)
        {
            View_Student_Registration view_Student_Registration = new View_Student_Registration();
            view_Student_Registration.Show();
            this.Close();
        }
    }
}
