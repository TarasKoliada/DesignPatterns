using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Team
{
    class QA : TeamMember
    {
        public QA(string name)
        {
            this.name = name;
            SetAction();
        }
        private void SetAction()
        {
            actions = new();
            actions.Add(DoStuff);
        }
        public void DoStuff()
        {
            Console.WriteLine($"{name} is checking some projects quality.");
        }
    }
}
