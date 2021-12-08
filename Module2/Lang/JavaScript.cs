using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Lang
{
    class JavaScript : Language
    {
        public JavaScript() : base("JavaScript")
        {        }
        public override void UseLanguage()
        {
            Console.WriteLine($"Coding with {langName} language.");
        }
    }
}
