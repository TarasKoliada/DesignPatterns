using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalInfo = new PersonalInfo//Create new PersonalInfo object
            {
                Adress = "Lviv",
                Email = "Koliada.tarass@gmail.com",
                Id = 1,
                Name = "Taras",
                PhoneNumber = "+380986255638",
                Position = "Student"
            };

            var courseEng = new Course//Create new Course object
            {
                Name = "English",
                StartDate = DateTime.Now,
            };
            var professor1 = new Professor//Create new PRofessor object
            {
                Name = "Andrii",
                Surname = "Danylovych",
                Email = "Andrii.Danylovych@gmail.com",
                Adress = "Lviv",
                PhoneNumber = "+380676839102"
            };

            Course.allCourses.Add(courseEng);//Add created course to static list

            var student1 = new Student(personalInfo);//set student personal info
            Student.Enroll(courseEng, student1);//Enroll student at course

            courseEng.GetStudentsAtCourse();//Get all students at current course

            professor1.SetToCourse(courseEng);//set professor to course;

            var seminarForEng = new Seminar//Create new Seminar object
            {
                Id = 1,
                RelatedCourse = courseEng.Name,
                Title = "English seminar B1"
            };
            var seminarForMath = new Seminar
            {
                Id = 2,
                RelatedCourse = "Math",
                Title = "Some Title"
            };

            Course.AddSeminar(seminarForEng);//Add seminars to courses
            Course.AddSeminar(seminarForMath);

            courseEng.GetSeminarsAtCourse();//Get seminars at current course

            Student.Unenroll(courseEng, student1);//Remove student from current course
        }
    }
}
