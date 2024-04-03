using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Class>? Classes { get; set; } = new List<Class>();
        public List<Faculty>?Faculties { get; set; } = new List<Faculty>();

    }
}
