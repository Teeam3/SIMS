using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
    public class FacultySepcification : BaseSpecification<Faculty>
    {
        public FacultySepcification()
        {
            AddInclude(f => f.Courses);
            AddInclude(f => f.Classes);
        }
        
    }
}
