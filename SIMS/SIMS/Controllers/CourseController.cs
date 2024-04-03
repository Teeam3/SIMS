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
    public class CourseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mappers;
        public CourseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mappers = mapper;
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var courseSpec = await _unitOfWork.CourseRepository.GetByIdAsync(id);
            return Ok(courseSpec);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllAsync()
        {
            var spec = new CourseSpecification();
            var courses = await _unitOfWork.CourseRepository.GetAllAsync();
            return Ok(courses);
        }
        [HttpGet("spec")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllAsyncWithSpec()
        {
            var spec = new CourseSpecification();
            var courses = await _unitOfWork.CourseRepository.GetAllAsyncWithSpec(spec);
            return Ok(_mappers.Map<IEnumerable<Course>,IEnumerable<CourseDto>>(courses));
        }
    }
}
