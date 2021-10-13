using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student : Staff
    {
        public List<string> violations = new List<string>();
        public Student(PersonalInfo info)
        {
            Init(info);
        }
        public override void CalculateWorkload()
        {
            if (GetPersonalInfo().Position == "Student")
            {
                Console.WriteLine("I'm partly loaded");
            }
            else if (GetPersonalInfo().Position == "Employed")
            {
                Console.WriteLine("I'm full loaded");
            }
            else
            {
                Console.WriteLine("I have a lot of free time");
            }
        }

        public override void SetViolation(string message)
        {
            violations.Add(message);
        }
        
        public static void Enroll(Course course, Student student)
        {
            course.AddStudent(student, course);
        }
        public static void Unenroll(Course course, Student student)
        {
            if (course.RemoveStudent(student) == false)
            {
                Console.WriteLine($"Can't find student {student.GetPersonalInfo().Name} at course {course.Name}\n");
            }
            else
            {
                Console.WriteLine($"Student {student.GetPersonalInfo().Name} has been removed from course {course.Name}\n");
            }
        }
        public void VisitSeminar(Seminar seminar)
        {
            Console.WriteLine($"Seminar with ID: {seminar.Id} was visited");
            
        }
    }
}
