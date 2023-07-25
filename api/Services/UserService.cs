namespace Api.Services
{
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Api.Models;
    using Api.Data.DTOs;

    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _usermanager;
        private readonly SignInManager<User> _signInManager;
        public UserService(IMapper mapper, UserManager<User> usermanager, SignInManager<User> signInManager)
        {
            _mapper = mapper;
            _usermanager = usermanager;
            _signInManager = signInManager;
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

        public async Task Signin(LoginUserDto loginUserDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginUserDto.UserName, loginUserDto.Password, false, false);
        
            if (!result.Succeeded)
            {
                throw new ApplicationException("Failed to Login");
            }
        }
    }
}