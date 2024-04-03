using AutoMapper;
using Core.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SIMS_Dbcontext _dbcontext;

        public UnitOfWork(SIMS_Dbcontext dbcontext)
        {
            _dbcontext = dbcontext;
            ClassRepository = new ClassRepository(_dbcontext);
            CourseRepository = new CourseRepository(_dbcontext);
            CurriculumRepository = new CurriculumRepository(_dbcontext);
            FacultyRepository = new FacultyRepository(_dbcontext);
            ScoreRepository = new ScoreRepository(_dbcontext);
            StudentRepository = new StudentRepository(_dbcontext);
        }
        public IClassRepository ClassRepository {get; private set;}

        public ICourseRepository CourseRepository { get; private set; }

        public ICurriculumRepository CurriculumRepository { get; private set; }

        public IFacultyRepository FacultyRepository { get; private set; }

        public IScoreRepository ScoreRepository { get; private set; }

        public IStudentRepository StudentRepository { get; private set; }

        public IMapper mapper {get; private set;}

        public void Dispose()
        {
            _dbcontext.Dispose();
        }

        public async Task<int> Save()
        {
            return await _dbcontext.SaveChangesAsync();
        }
    }
}
