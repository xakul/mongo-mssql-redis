using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using mockProject.Interfaces;
using mockProject.Persistences.Mongo.Models;
using mockProject.ViewModels;

namespace mockProject.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetAll()
        {
            var userList = await _userService.GetAllUsers();

            var userListViewModel =  _mapper.Map<List<UserViewModel>>(userList);

            return Ok(userListViewModel);
        }

        [HttpPost("create-user")]
        public async Task<ActionResult<UserViewModel>> CreateUser(UserViewModel userViewModel)
        {
            var userModel = _mapper.Map<User>(userViewModel);

            var user = await _userService.CreateUser(userModel);

            return Ok(user);
        }

    }
}
