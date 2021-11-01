using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student : Staff
    {
        public List<string> violations = new List<string>();
        public Student(PersonalInfo personalInfo)
        {
            Init(personalInfo);
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
    }
}
