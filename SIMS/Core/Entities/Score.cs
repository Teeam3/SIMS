using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Score
    {
        public int? Id { get; set; }
        public int? Point { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public Student? Student { get; set; } = new Student();
        public Course? Course { get; set; } = new Course();
    }
}
