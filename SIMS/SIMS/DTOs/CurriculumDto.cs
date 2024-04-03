namespace SIMS.DTOs
{
    public class CurriculumDto
    {
        public int Id { get; set; }
        public string Professor { get; set; }
        public List<string> Students { get; set; }
        public List<string> Courses { get; set; }
    }
}
