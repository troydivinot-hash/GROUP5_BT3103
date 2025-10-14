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
    }
}
