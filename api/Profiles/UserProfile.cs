namespace Api.Profiles
{
    using AutoMapper;
    using Api.Data.DTOs;
    using Api.Models;

    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}