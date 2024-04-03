using Core.Entities;

namespace SIMS.DTOs
{
    public class FacultyDto : Person
    {
        public List<Class> ClassList { get; set; }
        public List<Course> Courses { get; set; }
    }
}
