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
    public partial class View_Student_Registration : Form
    {
        public View_Student_Registration()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            //FormDashboard adminDashboard = new FormDashboard();
            //adminDashboard.Show();
            //this.Close();/

            Registrar_Dashboard registrar_Dashboard = new Registrar_Dashboard();
            registrar_Dashboard.Show();
            this.Close();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Student_Registration_admin student_Registration_Admin = new Student_Registration_admin();
            student_Registration_Admin.Show();
            this.Close();
        }
    }
}
