using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dean : Administration
    {
        public override List<Course> AttachCourse()
        {
            List<Course> courses = new List<Course>();
            Calculus calculus = new Calculus { CourseId = 3, Title = "Calculuc Course", StartingDate = DateTime.Now };
            courses.Add(calculus);

            return courses;
        }
    }
}
