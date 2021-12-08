using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Proj
{
    public class ProjectModule
    {
        private readonly Type _type;
        private readonly Team.Team _team;
        public ProjectModule(Type type, Team.Team team)
        {
            _team = team;
            _type = type;
        }
        public void ProcessModule()
        {
            Console.WriteLine($"    Team {_team.teamName} started processing {_type}.");
            Console.WriteLine($"    {_type} is done");
        }
    }
    public enum Type
    {
        Mobile_App = 1,
        WEB_App = 2,
        DATABASE = 3,
    }
}
