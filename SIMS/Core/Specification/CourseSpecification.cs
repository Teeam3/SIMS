using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
    public class CourseSpecification : BaseSpecification<Course>
    {
        public CourseSpecification()
        {
            AddInclude(course => course.Classes);
            AddInclude(course => course.Faculties);
        }
    }
}
