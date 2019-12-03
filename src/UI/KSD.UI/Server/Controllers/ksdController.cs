using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KSD.ServiceContracts;
using KSD.UI.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KSD.UI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ksdController : ControllerBase
    {
        private readonly IKSDService _service;
        public ksdController(IKSDService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetStudents());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _service.GetStudentDetails(id));
        }
        [HttpGet("smsLogs")]
        public async Task<IActionResult> GetSmsLogs()
        {
            return Ok(await _service.GetMSLogs());
        }
        [HttpGet("Full/{id}")]
        public async Task<IActionResult> GetFullDetails(Guid id)
        {
            return Ok(await _service.GetStudentFullDetails(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentDto dto)
        {
            return Ok(await _service.AddStudent(dto));
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> AddParent(Guid id,[FromBody] ParentDto dto)
        {
            return Ok(await _service.AddParent(id,dto));
        }
        [HttpPost("Meal/{id}")]
        public async Task<IActionResult> AddMeal(Guid id, [FromBody] MealDto dto)
        {
            return Ok(await _service.AddMeal(id, dto));
        }
    }
}