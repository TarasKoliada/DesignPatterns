using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Proj
{
    class Project
    {
        private readonly string _name;
        public readonly List<ProjectModule> _modules;
        public Project(string name, List<ProjectModule> modules)
        {
            _name = name;
            _modules = modules;
        }
        public void Produce()
        {
            Console.WriteLine($"\nTeam {_name} started doing project.");
            foreach (var module in _modules)
            {
                module.ProcessModule();
            }
            Console.WriteLine("Project is done.");
        }
    }
}
