using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Team
{
    class Architect : Developer
    {
        private readonly Developer _developer;
        public Architect(Developer developer): base(developer.name, developer.Language)
        {
            _developer = developer;
        }
        private void DoDuties()
        {
            Console.Write($"{name} is doing his Architect duties. ");
        }
        public override void DoWork()
        {
            DoDuties();
            Console.Write("Also he is developing some project with team. ");
            _developer.DoWork();
        }

    }
}
