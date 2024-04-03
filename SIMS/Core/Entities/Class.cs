using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public int? CurriculumId { get; set; }
        public string Name { get; set; }    
        public List<Faculty>? Faculties { get; set; } = new List<Faculty>();
        public List<Student>? Students { get; set; }  = new List<Student>(); 
        public Curriculum? Curriculum { get; set; }
    }
}
