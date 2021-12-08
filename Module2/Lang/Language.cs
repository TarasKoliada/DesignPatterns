using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Lang
{
    public abstract class Language
    {
        public string langName;
        public Language(string name)
        {
            langName = name;
        }
        public abstract void UseLanguage();
    }
}
