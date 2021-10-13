using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Professor : Staff
    {
        private List<Course> professorCourses = new List<Course>();

        public List<string> violations = new List<string>();

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        private int Salary { get; set; }
        public override void CalculateWorkload()
        {
            if (professorCourses.Count <= 1)
            {
                Console.WriteLine("Professor has some free time.");
            }
            else if (professorCourses.Count == 2)
            {
                Console.WriteLine("Professor is busy.");
            }
            else
            {
                Console.WriteLine("Don't bother him. He has no free time.");
            }
        }

        public override void SetViolation(string message)
        {
            violations.Add(message);
        }
        public void SetToCourse(Course course)
        {
            professorCourses.Add(course);
        }
        public int CalculateSalary()
        {
            Random random = new Random();
            if (professorCourses.Count == 0)
            {
                return -1;
            }
            if (professorCourses.Count == 1)
            {
                Salary = random.Next(300, 400);
            }
            else if (professorCourses.Count >= 2 && professorCourses.Count <= 4)
            {
                Salary = random.Next(400, 600);
            }
            else
            {
                Salary = random.Next(600, 800);
            }
            return Salary;
        }
        public void RequestSupport()
        {
            
        }
    }
}
