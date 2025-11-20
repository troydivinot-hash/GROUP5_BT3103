using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class StudentModel
    {
        public int Id { get; set; }  // StudentID
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }  // Nullable
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }  // Nullable
        public string StudentType { get; set; }  
        public string FathersName { get; set; }  // Nullable
        public string FathersContact { get; set; }  // Nullable
        public string MothersName { get; set; }  // Nullable
        public string MothersContact { get; set; }  // Nullable
        public string GuardianName { get; set; }  // Nullable
        public string GuardianContact { get; set; }  // Nullable
        public string Relationship { get; set; }  // Nullable
    }
}
