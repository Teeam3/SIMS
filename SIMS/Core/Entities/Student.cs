using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student : Person
    {
        public int? ClassId { get; set; }
        public int? ScoreId { get; set; }
        public Class? Class { get; set; }
        public List<Score> ?Scores { get; set; } 

    }
}
