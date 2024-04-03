using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
    public class ClassSpecification : BaseSpecification<Class>
    {
        public ClassSpecification() 
        {
            AddInclude(cls => cls.Curriculum);
            AddInclude(cls => cls.Students);
            AddInclude(cls => cls.Faculties);
        }
        public ClassSpecification(int curriculumId) 
            : base(cls => (!cls.CurriculumId.HasValue) || (cls.CurriculumId == curriculumId))
        {
            AddInclude(cls => cls.Curriculum);
            AddInclude(cls => cls.Students);
            AddInclude(cls => cls.Faculties);
        }
    }
}
;