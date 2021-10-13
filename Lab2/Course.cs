using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        public static List<Course> allCourses = new List<Course>();//List contains all courses
        public List<Student> studentsAtCourse = new List<Student>();//List contains info about all students
        public string Name{ get; set; }
        public DateTime StartDate { get; set; }
        public List<int> SeminarsId { get; set; }

        public void AddStudent(Student student, Course course)
        {
            foreach (var item in allCourses)
            {
                if (item.Name == course.Name && item.studentsAtCourse.Count == 0)
                {
                    studentsAtCourse = new List<Student> { student };
                }
                else if (item.Name == course.Name)
                {
                    studentsAtCourse.Add(student);
                }
            }
        }
        public bool RemoveStudent(Student student)
        {
            foreach (var item in studentsAtCourse)
            {
                if (student.GetPersonalInfo().Name == item.GetPersonalInfo().Name)
                {
                    studentsAtCourse.Remove(student);
                    return true;
                }
            }
            return false;

        }
        public void GetStudentsAtCourse()
        {
            Console.WriteLine($"At Course {Name} are students: ");
            foreach (var item in allCourses)
            {
                foreach (var i in item.studentsAtCourse)
                {
                    Console.WriteLine($"  ID: {i.GetPersonalInfo().Id} ");
                    Console.WriteLine($"  Name: {i.GetPersonalInfo().Name}");
                    Console.WriteLine($"  Email: {i.GetPersonalInfo().Email}\n");
                }
            }
        }
        public static void AddSeminar(Seminar seminar)
        {
            Seminar.allSeminars.Add(seminar);
        }
        public void GetSeminarsAtCourse()
        {
            Console.WriteLine($"At course {Name} are seminars: ");
            foreach (var item in Seminar.allSeminars)
            {
                if (item.RelatedCourse == Name)
                {
                    Console.WriteLine($"  ID: {item.Id}");
                    Console.WriteLine($"  Title: {item.Title}\n");
                }
            }
        }
    }
}
