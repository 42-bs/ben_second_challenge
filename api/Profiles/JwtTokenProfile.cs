namespace Api.Profiles
{
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;

    /// <summary>
    /// Maps the JWT token from token DTO.
    /// </summary>
    public class JwtTokenProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JwtTokenProfile"/> class.
        /// </summary>
        public JwtTokenProfile()
        {
            CreateMap<CreateTokenDto, JwtToken>();
            CreateMap<JwtToken, CreateTokenDto>();
        }
    }
}
