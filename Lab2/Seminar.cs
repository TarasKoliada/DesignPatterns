using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Seminar
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string RelatedCourse { get; set; }
        public static List<Seminar> allSeminars = new List<Seminar>();
    }
}
