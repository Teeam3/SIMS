using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Curriculum
    {
        public int Id { get; set; }
        public string Professor { get; set; }
        public List<Student>? Students { get; set; }
        public List<Course>? Courses { get; set; } = new List<Course>();
    }
}
