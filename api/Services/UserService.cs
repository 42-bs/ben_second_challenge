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
        private readonly SignInManager<User> _signinmanager;
        public UserService(IMapper mapper, UserManager<User> usermanager, SignInManager<User> signinmanager)
        {
            _mapper = mapper;
            _usermanager = usermanager;
            _signinmanager = signinmanager;
        }

        public async Task Signup(CreateUserDto createUserDto)
        {
            User user = _mapper.Map<User>(createUserDto);

            var result = await _usermanager.CreateAsync(user, createUserDto.UserPassword);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Failed to create user");
            }
        }

        // public async Task Signin(LoginUserDto loginUserDto)
        // {
        //     throw new NotImplementedException();
        // }
    }
}