using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Administration
    {
        private PersonalInfo personalInfo;

        public abstract List<Course> AttachCourse();
        public void FillCourse(Professor professor, Group group)
        {
            professor.AddProfessorGroup(group);
        }  
    }
}
