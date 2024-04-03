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
    public class ScoreController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ScoreController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var scoreSpec = await _unitOfWork.ScoreRepository.GetByIdAsync(id);
            return Ok(_mapper.Map<Score, ScoreDto>(scoreSpec));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetAllAsync()
        {
            var scores = await _unitOfWork.ScoreRepository.GetAllAsync();
            return Ok(scores);
        }
        [HttpGet("spec")]
        public async Task<ActionResult<IEnumerable<Class>>> GetAllAsyncWithSpec(int studentId, int CourseId)
        {
            var spec = new ScoreSpecification(studentId, CourseId);
            var scores = await _unitOfWork.ScoreRepository.GetAllAsyncWithSpec(spec);
            return Ok(scores);
        }
    }
}
