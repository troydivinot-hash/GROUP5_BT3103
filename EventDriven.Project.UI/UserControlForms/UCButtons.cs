using System;
using System.Windows.Forms;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlForms.Buttons
{
    public partial class UCButtons : UserControl
    {
        // Events for parent to handle
        public event EventHandler<StudentModel> EditClicked;
        public event EventHandler<int> DeleteClicked;
        private UCStudentInformation ucStudentInformation = new UCStudentInformation();

        // Property for selected student (set by parent via DataGridView selection)
        public StudentModel SelectedStudent { get; set; }

        public UCButtons()
        {   
            InitializeComponent();
        }


       
        private void pbEdit_Click(object sender, EventArgs e)
        {
            if (SelectedStudent != null)
            {
                EditClicked?.Invoke(this, SelectedStudent);
            }
            else
            {
                MessageBox.Show("Please select a student to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (SelectedStudent != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {SelectedStudent.FirstName} {SelectedStudent.LastName}?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteClicked?.Invoke(this, SelectedStudent.Id);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}