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
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _articleService.GetAll();
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(ArticleEntity entity)
        {
            var result = await _articleService.Create(entity);
            return Ok(result);
        }
    }
}
