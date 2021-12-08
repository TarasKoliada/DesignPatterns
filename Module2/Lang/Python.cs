using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Lang
{
    public class Python : Language
    {
        public Python() : base("Python")
        {        }
        public override void UseLanguage()
        {
            Console.WriteLine($"Coding with {langName} language.");
        }
    }
}
