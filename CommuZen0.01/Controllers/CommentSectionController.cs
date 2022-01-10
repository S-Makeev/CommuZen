using CommuZen0._01.DataAccess.Entities;
using CommuZen0._01.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentSectionController : ControllerBase
    {
        private readonly ICommentSectionService _commentSectionService;

        public CommentSectionController(ICommentSectionService commentSectionService)
        {
            _commentSectionService = commentSectionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _commentSectionService.GetAll();
            return Ok (result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentSectionEntity entity)
        {
            var result = await _commentSectionService.Create(entity);
            return Ok(result);
        }
    }
}
