using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Example of creating Course object
            var courseMath = new Course
            {
                Name = "Math",
                Date = new DateTime(2021, 10, 12, 9, 0, 0),
                CourseId = 1,
                Fee = 150
            };
            var courseEng = new Course
            {
                Name = "English",
                Date = new DateTime(2021, 09, 29, 12, 0, 0),
                CourseId = 2,
                Fee = 190
            };
            var coursePhysics = new Course
            {
                Name = "Physics",
                Date = new DateTime(2021, 11, 15, 11, 0, 0),
                CourseId = 3,
                Fee = 190
            };
            

            //Example of creating student object
            var student1 = new Student
            {
                Name = "Sasha",
                Adress = "Lviv",
                Email = "Alex.Laptev@gmail.com",
                PhoneNumber = "+380987625674"
            };
            var student2 = new Student
            {
                Name = "Vika",
                Adress = "Kyiv",
                Email = "Viktoria.Mandziy@gmail.com",
                PhoneNumber = "+380672435143"

            };
            var student3 = new Student
            {
                Name = "Taras",
                Adress = "Ternopil",
                Email = "Taras.Koliada@gmail.com",
                PhoneNumber = "+380972984457"
            };

            //adding courses to the static list(class Course)
            Course.allCourses.Add(courseMath);
            Course.allCourses.Add(courseEng);
            Course.allCourses.Add(coursePhysics);


            //Enrolling students at the courses(static method enroll, class Student)
            Student.Enroll(student1, courseMath);
            Student.Enroll(student2, courseMath);
            
            Student.Enroll(student1, courseEng);
            Student.Enroll(student3, courseEng);

            Student.Enroll(student3, coursePhysics);
            Student.Enroll(student1, coursePhysics);
            Student.Enroll(student2, coursePhysics);

            Student.Unenroll(student2, courseMath);//Removing student2 from course Math;
            Student.Unenroll(student2, courseEng);//Removing student2 from course English(Drops Warning at console, cause that student is not studying at that course);

            //The static method shows info about count of students at the current courses(Class Course)
            Course.TakenCoursesInGeneral();
            
            //The static method sets marks for all students
            Student.SetFinalMarks();

            //This methods shows info about current student(including the marks created above)
            student1.ShowStudentInfo();
            student2.ShowStudentInfo();
            student3.ShowStudentInfo();


           

            
        }
    }
}
