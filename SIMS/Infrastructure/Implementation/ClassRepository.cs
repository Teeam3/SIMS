using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class ClassRepository : GenericRepository<Class>, IClassRepository
    {
        public ClassRepository(SIMS_Dbcontext dbcontext) : base(dbcontext)
        {
        }
    }
}
