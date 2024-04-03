using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SIMS_Dbcontext : DbContext
    {
        public SIMS_Dbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Faculty> Faculties { get; set;}
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
