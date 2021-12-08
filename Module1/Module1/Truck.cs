using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Truck
    {
        public DateTime ManufactureDate { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ManufactureDate);
            sb.Append($"\n{Type}\n");
            sb.Append($"{Name}\n");
            sb.Append($"{Color}\n");
            sb.Append($"{Price}\n");
            return sb.ToString();
        }
    }
}
