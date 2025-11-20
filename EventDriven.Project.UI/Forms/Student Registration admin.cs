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
    public partial class Student_Registration_admin : Form
    {
        public Student_Registration_admin()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();

            Registrar_Dashboard registrar_Dashboard = new Registrar_Dashboard();
            registrar_Dashboard.Show();
            this.Close();

            View_Student_Registration view_Student_Registration = new View_Student_Registration();
            view_Student_Registration.Show();
            this.Close();
        }
    }
}
