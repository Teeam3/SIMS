using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(SIMS_Dbcontext dbcontext) : base(dbcontext)
        {
        }
        public async Task<IEnumerable<Student>> GetWithClassAndScore()
        {
           
           var studentDetail = await _dbcontext.Students.Include(x => x.Scores).Include(x => x.Class).ToListAsync();
            return studentDetail;
        }
    }
}
