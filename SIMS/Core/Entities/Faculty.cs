using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Faculty : Person
    {
        public List<Class>? Classes { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
