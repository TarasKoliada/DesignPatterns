using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Staff
    {
        private PersonalInfo _personalInfo;

        public abstract void CalculateWorkload();
        public abstract void SetViolation(string message);
        public void Init(PersonalInfo info)
        {
            _personalInfo = new PersonalInfo();
            _personalInfo = info;
        }
        public PersonalInfo GetPersonalInfo()
        {
            return _personalInfo;
        }     
    }
}
