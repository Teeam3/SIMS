using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Infrastructure.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.DTOs;

namespace SIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #region GET
        public ClassController(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var classSpec = await _unitOfWork.ClassRepository.GetByIdAsync(id);
            return Ok(classSpec);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetAllAsync()
        {
            var spec = new ClassSpecification();
            var classes = await _unitOfWork.ClassRepository.GetAllAsyncWithSpec(spec);
            return Ok(classes);
        }
        [HttpGet("spec")]
        public async Task<ActionResult<IEnumerable<ClassDto>>> GetAllAsyncWithSpec()
        {
            var spec = new ClassSpecification();
            var classes = await _unitOfWork.ClassRepository.GetAllAsyncWithSpec(spec);
            return Ok(_mapper.Map<IEnumerable<Class>,IEnumerable<ClassDto>>(classes));
        }
        #endregion
        #region POST
        [HttpPost]
        public async Task<ActionResult<Class>> Add(string name)
        {
            var cls = new Class { Name = name };
            var clas = _unitOfWork.ClassRepository.Add(cls);
            await _unitOfWork.Save();
            return Ok(clas);
        }
        [HttpPost("AddRange")]
        public async Task<ActionResult<IEnumerable<Class>>> AddRange(IEnumerable<string> classes)
        {
            var classCount = new List<Class>();
           foreach (var cls in classes)
            {
                classCount.Add(new Class { Name = cls});
            }
            var classList = _unitOfWork.ClassRepository.AddRange(classCount);
            await _unitOfWork.Save();
            return Ok();
        }
        #endregion

        #region UPDATE
        [HttpPut("addStudent")]
        public async Task<ActionResult<IEnumerable<Class>>> AddStudent(int classId, int studentId)
        {
            var students = await _unitOfWork.StudentRepository.GetByIdAsync(studentId);
            students.ClassId = classId;
            await _unitOfWork.Save();
            return Ok();
        }
        [HttpPut("addFaculty")]
        public async Task<ActionResult<IEnumerable<ClassDto>>> AddFaculty(int classId, IEnumerable<string> faculties)
        {
            var faculty = await _unitOfWork.FacultyRepository.GetAllAsync();
            var classes = await _unitOfWork.ClassRepository.GetByIdAsync(classId);
            foreach (var fa in faculty)
            {
                if(faculties.Contains(fa.Name))
                {
                    classes.Faculties.Add(fa);
                }
            }
            await _unitOfWork.Save();
            return Ok();
        }
        #endregion

        #region DELETE

        #endregion
    }
}
