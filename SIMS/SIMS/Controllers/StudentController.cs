using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.DTOs;

namespace SIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet("id")]
        public async Task<ActionResult<StudentDto>> GetById(int id)
        {
            var studentSpec = await _unitOfWork.StudentRepository.GetByIdAsync(id);
            return Ok(_mapper.Map<Student, StudentDto>(studentSpec));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetAllAsync()
        {
            var students = await _unitOfWork.StudentRepository.GetWithClassAndScore();
            return Ok(_mapper.Map<IEnumerable<Student>, IEnumerable<StudentDto>>(students));
        }
        [HttpGet("classscore")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetAllAsyncWithScoreClass()
        {
            var students = await _unitOfWork.StudentRepository.GetWithClassAndScore();
            return Ok(_mapper.Map<IEnumerable<Student>, IEnumerable<StudentDto>>(students));
        }
    }
}
