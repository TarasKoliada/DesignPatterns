using Module2.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Team
{
    public class Developer : TeamMember
    {
        protected Language language;
        public Language Language { get { return language; } set { language = value; } }
        public Developer(string name, Language lang)
        {
            language = lang;
            this.name = name;
            SetAction();
        }
        private void SetAction()
        {
            actions = new();
            actions.Add(DoWork);
        }
        public virtual void DoWork()
        {
            Console.Write($"{name} is ");
            language.UseLanguage();
        }
    }
}
