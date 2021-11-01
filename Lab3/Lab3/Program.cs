using System;

namespace Lab3
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
            var student = new Student(personalInfo);


            HeadDepartment department = new HeadDepartment();//Create HeadDepartment object
            var courses = department.AttachCourse();//Factory Method(Set and get courses) 
            foreach (var item in courses)
            {
                Console.WriteLine($"Course: {item.Title}");//Show courses info
            }

            Course course = new DesignPatterns();
            course.AddStudent(student);//Add student at course
        }
    }
}
