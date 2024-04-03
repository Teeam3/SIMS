using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClassRepository ClassRepository { get; }
        ICourseRepository CourseRepository { get; }
        ICurriculumRepository CurriculumRepository { get; }
        IFacultyRepository FacultyRepository { get; }
        IScoreRepository ScoreRepository { get; }
        IStudentRepository StudentRepository { get; }
        Task<int> Save();
    }
}
