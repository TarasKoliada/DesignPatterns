using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class HeadDepartment : Administration
    {
        public override List<Course> AttachCourse()
        {
            List<Course> courses = new List<Course>();
            DesignPatterns designPatterns = new DesignPatterns { CourseId = 1, Title = "Design Patterns Course", StartingDate = DateTime.Now};
            MachineLearning machineLearning = new MachineLearning { CourseId = 2, Title = "Machine Learning Course", StartingDate = DateTime.Now};

            courses.Add(designPatterns);
            courses.Add(machineLearning);

            return courses;

        }
    }
}
