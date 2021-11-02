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
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatservice)
        {
            _chatService = chatservice;
        }

        [NewMethod(Name = "getall")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _chatService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChatEntity entity)
        {
            var result = await _chatService.Create(entity);
            return Ok(result);
        }

        [HttpGet("{id:long}/users")]
        public async Task<IActionResult> GetUsersByChatId(long id)
        {
            var result = await _chatService.GetUsersByChat(id);

            return !result.Any() 
                ? Ok(new {message = "Users not found"}) 
                : Ok(result);
        }
    }
}
