using System.Threading.Tasks;
using CommuZen0._01.DataAccess.Entities;
using CommuZen0._01.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CommuZen0._01.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // localhost:5000/api/users/594
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]long id)
        {
            var user = await _userService.GetById(id);

            if (user == null)
            {
                return NotFound("");
            }

            return Ok(new {data = user});
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();

            return Ok(new {users});
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]UserEntity user)
        {
            var userId = await _userService.Create(user);

            return Ok(new {id=userId});
        }
    }
}