using Core.Entities;

namespace SIMS.DTOs
{
    public class CourseDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<string> Classes { get; set; } = new List<string>();
        public List<string> Faculties { get; set; } = new List<string>();
    }
}
