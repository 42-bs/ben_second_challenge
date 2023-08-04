namespace Api.Services
{
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// Service which contains the sign in and sign up rules.
    /// </summary>
    public class UserService
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> usermanager;
        private readonly SignInManager<User> signInManager;
        private readonly TokenService tokenService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="mapper">Mapps the DTO with model.</param>
        /// <param name="usermanager">Manages the user.</param>
        /// <param name="signInManager">Manages the sign in.</param>
        /// <param name="tokenService">Token service.</param>
        public UserService(
            IMapper mapper,
            UserManager<User> usermanager,
            SignInManager<User> signInManager,
            TokenService tokenService)
        {
            this.mapper = mapper;
            this.usermanager = usermanager;
            this.signInManager = signInManager;
            this.tokenService = tokenService;
        }

        /// <summary>
        /// Method that creates the user account.
        /// </summary>
        /// <param name="createUserDto">User's sent object to create the account.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <exception cref="ApplicationException">Thrown if there's an error during the user creation.</exception>
        public async Task Signup(CreateUserDto createUserDto)
        {
            User user = mapper.Map<User>(createUserDto);

            IdentityResult result = await usermanager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Failed to create user");
            }
        }

        /// <summary>
        /// Method that does the login.
        /// </summary>
        /// <param name="loginUserDto">User's sent object to login.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <exception cref="ApplicationException">Thrown if there's an error during the login.</exception>
        public async Task<CreateTokenDto?> Signin(LoginUserDto loginUserDto)
        {
            var result = await signInManager.PasswordSignInAsync(
                loginUserDto.UserName, loginUserDto.Password, false, false);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Failed to Login");
            }

            var user = signInManager
                .UserManager
                .Users
                .FirstOrDefault(u => u.NormalizedUserName == loginUserDto.UserName.ToUpper());

            if (user == null)
            {
                return null;
            }

            var token = tokenService.GenerateToken(user);

            return token;
        }
    }
}