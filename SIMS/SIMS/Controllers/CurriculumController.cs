using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.DTOs;

namespace SIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CurriculumController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var curriculumSpec = await _unitOfWork.CurriculumRepository.GetByIdAsync(id);
            return Ok(curriculumSpec);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumDto>>> GetAllAsync()
        {
            var curriculums = await _unitOfWork.CurriculumRepository.GetAllAsync();
            return Ok(curriculums);
        }
        [HttpGet("spec")]
        public async Task<ActionResult<IEnumerable<CurriculumDto>>> GetAllAsyncWithSpec(string course, string student)
        {
            var spec = new CuriculumSpecification(course,student);
            var curriculums = await _unitOfWork.CurriculumRepository.GetAllAsyncWithSpec(spec);
            return Ok(_mapper.Map<IEnumerable<Curriculum>, IEnumerable<CurriculumDto>>(curriculums));
        }
    }
}
