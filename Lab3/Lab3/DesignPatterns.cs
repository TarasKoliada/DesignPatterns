using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DesignPatterns : Course
    {
        private List<Student> students = new List<Student>();
        public override void AddStudent(Student student)
        {
            students.Add(student);
        }

        public override void RemoveStudent(Student student)
        {
            foreach (var item in students)
            {
                if (student.GetPersonalInfo().Name == item.GetPersonalInfo().Name)
                {
                    students.Remove(student);
                }
            }
        }

        public override void SendCourseMaterials(Group group, string material)
        {
            group.SetMaterials(material);
        }
    }
}
