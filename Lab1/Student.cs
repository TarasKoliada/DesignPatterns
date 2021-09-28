using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public static int StudentNumber { get; set; }
        public string Email { get; set; }
        public float AverageMark { get; set; }
        public int FinalMark { get; set; }

        public void ShowStudentInfo()//all student info
        {
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Student id: {++StudentNumber}");
            Console.WriteLine($"Student name: {Name}");
            Console.WriteLine($"Student adress: {Adress}");
            Console.WriteLine($"Student email: {Email}");
            Console.WriteLine($"Student phone number: {PhoneNumber}");
            Console.WriteLine($"Student average mark: {AverageMark}");
            Console.WriteLine($"Student Final mark: {FinalMark}");
            Console.Write("Student Courses: ");
            foreach (var course in Course.allCourses)
            {
                foreach (var student in course.studentsAtCourse)
                {
                    if (student.Name == Name)
                    {
                        Console.Write($"{course.Name}|");
                    }
                }
            }
            Console.WriteLine("\n--------------------------------------------------");
        }
        public static void SetFinalMarks()//setter for final marks of all students
        {
            var enrollment = new Enrollment();
            foreach (var courses in Course.allCourses)
            {
                foreach (var students in courses.studentsAtCourse)
                {
                    enrollment.SetAverage(students);//in cycle sets average mark of all students(class Enrollment)
                    enrollment.SetFinalMark(students);//in cycle sets final mark of all students(class Enrollment)
                }
            }
        }
        public static void Enroll(Student student, Course course)//enrolling student
        {
            course.AddStudent(student, course);           
        }
        public static void Unenroll(Student student, Course course)//Unenrolling student
        {
            //course.RemoveStudent(student);
            if (course.RemoveStudent(student) == false)
            {
                Console.WriteLine($"Can't find student {student.Name} at course {course.Name}\n");
            }
            else
            {
                Console.WriteLine($"Student {student.Name} has been removed from course {course.Name}\n");
            }

        }
    }
}
