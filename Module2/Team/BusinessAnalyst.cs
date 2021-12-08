using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Team
{
    class BusinessAnalyst : TeamMember
    {
        public BusinessAnalyst(string name)
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
            Console.WriteLine($"{name} is doing his work stuff(Analysing).");
        }
    }
}
