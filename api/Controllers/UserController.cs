namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Api.Data;
    using Api.Data.DTOs;
    using Api.Models;
    using Api.Services;
    using AutoMapper;

    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("signup")]
        public async Task <IActionResult> Signup(CreateUserDto createuserdto)
        {
            await _userService.Signup(createuserdto);
            return Ok("User Created");
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Signin(LoginUserDto loginuserdto)
        {
            await _userService.Signin(loginuserdto);
            return Ok("User logged");
        }

    }
}