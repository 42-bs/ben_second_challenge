#nullable disable

namespace Api.Services
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;
    using Microsoft.IdentityModel.Tokens;

    /// <summary>
    /// It has the necessary service for the token management rules.
    /// </summary>
    public class TokenService
    {
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenService"/> class.
        /// </summary>
        /// <param name="configuration">Contains the configuration options of the application.</param>
        /// <param name="mapper">Maps DTO to model.</param>
        public TokenService(IConfiguration configuration, IMapper mapper)
        {
            this.configuration = configuration;
            this.mapper = mapper;
        }

        /// <summary>
        /// Generates a tokaen.
        /// </summary>
        /// <param name="user">Represents the Model of a user.</param>
        /// <returns>Returns a token.</returns>
        public CreateTokenDto GenerateToken(User user)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", user.UserName),
                new Claim("id", user.Id)
            };

            var key = new SymmetricSecurityKey(
                Encoding
                .UTF8
                .GetBytes(configuration["SymmetricSecurityKey"]));

            var signinCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddMinutes(1),
                claims: claims,
                signingCredentials: signinCredentials);

            var jwtToken = new JwtToken
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };

            return mapper.Map<CreateTokenDto>(jwtToken);
        }
    }
}