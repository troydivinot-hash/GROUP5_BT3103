using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
     public class ScheduleModel
    {
        private int ScheduleID { get; set; }
        private string SectionID { get; set; }
        private string TeacherID { get; set; }
        private string SubjectID { get; set; }
        private string StartTime { get; set; }
        private string EndTime { get; set; }
        private string Day { get; set; }
        private int GradeLevel { get; set; }

    }
}
