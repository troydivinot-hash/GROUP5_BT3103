using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{
    public class StudentController
    {
        private StudentRepository studentRepository;

        public StudentController()
        {
            studentRepository = new StudentRepository();
        }

        public List<StudentModel> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }

        // New: Wrapper for inserting a student
        public void AddStudent(StudentModel student)
        {
            studentRepository.InsertStudent(student);
        }


        public void UpdateStudent(StudentModel student)
        {
            studentRepository.UpdateStudent(student);
        }

   
        public void DeleteStudent(int studentId)
        {
            studentRepository.DeleteStudent(studentId);
        }
    }
}