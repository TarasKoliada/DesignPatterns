using Module2.Proj;
using System;
using System.Collections.Generic;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Team.Team team = new Team.Team("GreatTeam");
            team.GetTeamInfo();
            var modules = new List<ProjectModule>
            {
                new ProjectModule(Proj.Type.DATABASE, team),
                new ProjectModule(Proj.Type.WEB_App, team),
                new ProjectModule(Proj.Type.Mobile_App, team)
            };
            var project = new Project("Restaurant", modules);
            project.Produce();
        }
    }
}
