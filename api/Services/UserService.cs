namespace Api.Services
{
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Api.Models;
    using Api.Data.DTOs;
    using Api.Services;

    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _usermanager;
        private readonly SignInManager<User> _signInManager;
        private readonly TokenService _tokenService;

        public UserService(IMapper mapper,
            UserManager<User> usermanager,
            SignInManager<User> signInManager,
            TokenService tokenService)
        {
            _mapper = mapper;
            _usermanager = usermanager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task Signup(CreateUserDto createUserDto)
        {
            User user = _mapper.Map<User>(createUserDto);

            IdentityResult result = await _usermanager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Failed to create user");
            }
        }

        public async Task<string> Signin(LoginUserDto loginUserDto)
        {
            var result = await _signInManager.PasswordSignInAsync(
                loginUserDto.UserName, loginUserDto.Password, false, false);
        
            if (!result.Succeeded)
            {
                throw new ApplicationException("Failed to Login");
            }

            var user = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(u => u.NormalizedUserName == loginUserDto.UserName.ToUpper());

            var token = _tokenService.GenerateToken(user);

            return token;
        }
    }
}