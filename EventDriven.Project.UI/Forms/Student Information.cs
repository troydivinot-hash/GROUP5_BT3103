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

namespace EventDriven.Project.UI
{
    public partial class Student_Information : Form
    {
        private StudentController studentController;
        public Student_Information()
        {
            studentController = new StudentController();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentController.GetAllStudents();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            //FormDashboard adminDashboard = new FormDashboard();
            //adminDashboard.Show();
            //this.Close();/

            //Registrar_Dashboard registrar_Dashboard = new Registrar_Dashboard();
            //registrar_Dashboard.Show();
            //this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
            this.Close();
        }
    }
}
