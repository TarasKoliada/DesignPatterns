using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> studentsIdList { get; set; }
        public string CourseMaterials { get; private set; }
        public void SetMaterials(string materials)
        {
            CourseMaterials = materials;
        }
    }
}
