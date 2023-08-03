namespace Api.Profiles
{
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;

    /// <summary>
    /// Does the mapping rules from DTO to Model.
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}