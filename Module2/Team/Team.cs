using Module2.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Team
{
    public class Team
    {
        public readonly List<TeamMember> members = new();
        public readonly string teamName;
        public Team(string teamName)
        {
            this.teamName = teamName;
            members.Add(new Architect(new Developer("Denys", new Python())));
            members.Add(new TeamLead(new Developer("Mykola", new JavaScript())));
            members.Add(new Developer("Nazar", new Python()));
            members.Add(new Developer("Oleh", new JavaScript()));
            members.Add(new QA("Daniel"));
            members.Add(new BusinessAnalyst("Vladyslaw"));
        }
        public void GetTeamInfo()
        {
            int counter = 0;
            foreach (var member in members)
            {
                if (member.actions != null)
                {
                    foreach (var action in member.actions)
                    {
                        Console.Write($"{++counter})  ");
                        action();
                    }
                }   
            }
        }
    }
}
