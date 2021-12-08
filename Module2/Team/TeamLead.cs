using Module2.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Team
{
    class TeamLead : Developer
    {
        private readonly Developer _developer;
        public TeamLead(Developer developer) : base(developer.name, developer.Language)
        {
            _developer = developer;
            developer.actions = new();
            developer.actions.Add(DoDuties);
            developer.actions.Add(DoWork);
        }

        private void DoDuties()
        {
            Console.Write($"{name} is doing his Leading duties.");
        }

        public override void DoWork()
        {
            DoDuties();
            Console.Write("TL is Developing some project with team. ");
            _developer.DoWork();
        }

    }
}
