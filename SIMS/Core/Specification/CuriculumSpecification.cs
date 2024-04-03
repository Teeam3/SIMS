using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
    public class CuriculumSpecification : BaseSpecification<Curriculum>
    {
        public CuriculumSpecification() 
        {
            AddInclude(curriculum => curriculum.Courses);
            AddInclude(curriculum => curriculum.Students);
        }

        public CuriculumSpecification(string course, string student)
            : base(cu => cu.Students.All(s => s.Name == student) && cu.Courses.All(c => c.Name == course))
        {
            AddInclude(curriculum => curriculum.Courses);
            AddInclude(curriculum => curriculum.Students);
        }
    }
}
