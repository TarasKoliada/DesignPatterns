using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public DateTime StartingDate { get; set; }
        public abstract void AddStudent(Student student);
        public abstract void RemoveStudent(Student student);
        public abstract void SendCourseMaterials(Group group, string material);

    }
}
