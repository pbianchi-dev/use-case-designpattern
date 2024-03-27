using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) =>
            _userService = userService;

        [HttpGet]
        public async Task<IActionResult> RecoverAll()
        {
            var users = await _userService.RecoverAllUsers();
            
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            var id = await _userService.RegisterAUser(user);

            return Ok(id);
        }
    }
}
