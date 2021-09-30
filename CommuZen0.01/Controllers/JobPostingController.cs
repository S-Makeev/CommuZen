using CommuZen0._01.DataAccess.Entities;
using CommuZen0._01.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostingController : ControllerBase
    {
        private readonly IJobPostingService _jobpostingService;

        public JobPostingController(IJobPostingService jobpostingService)
        {
            _jobpostingService = jobpostingService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _jobpostingService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(JobPostingEntity entity)
        {
            var result = await _jobpostingService.Create(entity);
            return Ok(result);
        }
    }
}
