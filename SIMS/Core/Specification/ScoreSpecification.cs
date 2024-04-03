using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
    public class ScoreSpecification : BaseSpecification<Score>
    {
        public ScoreSpecification() { }
        public ScoreSpecification(int student_id, int course_id) 
            : base(s => (!s.StudentId.HasValue || s.StudentId == student_id) && (!s.CourseId.HasValue || s.CourseId == course_id))
        {
            AddInclude(s => s.Student);
            AddInclude(s => s.Course);
        }
    }
}
