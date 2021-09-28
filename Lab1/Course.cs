using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Course
    {
        
        public static List<Course> allCourses = new List<Course>();//List contains all courses
        public List<Student> studentsAtCourse = new List<Student>();//List contains info about all students
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public float Fee { get; set; }
        public static void TakenCoursesInGeneral()//Method shows info about courses and students who attended it
        {
            foreach (var course in allCourses)
            {
                Console.WriteLine($"At course {course.Name}: ");
                foreach (var student in course.studentsAtCourse)
                {
                    Console.WriteLine($"   Student: {student.Name}");
                }
            }
        }
        public void AddStudent(Student student, Course course)//Adding student at the course
        {
            foreach (var item in allCourses)
            {
                if (item.Name == course.Name && item.studentsAtCourse.Count == 0)
                {
                    studentsAtCourse = new List<Student> {student};
                }
                else if(item.Name == course.Name)
                {
                    studentsAtCourse.Add(student);
                }
            }
        }
        public bool RemoveStudent(Student student)//Student removing by the name
        {
            var deleteStudent = studentsAtCourse.FirstOrDefault(stud => stud.Name == student.Name);
            if (deleteStudent == null)
            {
                return false;
            }
            else
            {
                studentsAtCourse.Remove(deleteStudent);
                return true;
            }
        }
    }
}
