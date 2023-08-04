namespace Api.Controllers
{
    using Api.Data;
    using Api.Data.DTOs;
    using Api.Models;
    using Api.Services;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller to sign in and sign up users.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="userService">Service which contains the login rules and account creation.</param>
        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Creates an user account.
        /// </summary>
        /// <param name="createuserdto">Basic data required to create a login.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("signup")]
        public async Task<IActionResult> Signup(CreateUserDto createuserdto)
        {
            await userService.Signup(createuserdto);
            return Ok("User Created");
        }

        /// <summary>
        /// Generates access token for user account.
        /// </summary>
        /// <param name="loginuserdto">Required data for user account to sign in.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("signin")]
        public async Task<IActionResult> Signin(LoginUserDto loginuserdto)
        {
            var token = await userService.Signin(loginuserdto);
            return Ok(token);
        }
    }
}