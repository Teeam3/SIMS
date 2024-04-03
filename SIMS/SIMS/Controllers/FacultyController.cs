using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FacultyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var facultySpec = await _unitOfWork.FacultyRepository.GetByIdAsync(id);
            return Ok(facultySpec);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetAllAsync()
        {
            var faculties = await _unitOfWork.FacultyRepository.GetAllAsync();
            return Ok(faculties);
        }
        [HttpGet("spec")]
        public async Task<ActionResult<IEnumerable<Class>>> GetAllAsyncWithSpec()
        {
            var faculties = await _unitOfWork.FacultyRepository.GetAllAsync();
            return Ok(faculties);
        }
    }
}
