namespace Api.Data.DTOs
{
    /// <summary>
    /// Creates token's DTO.
    /// </summary>
    public class CreateTokenDto
    {
        #nullable disable

        /// <summary>
        /// Gets or sets token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets token expiration.
        /// </summary>
        public DateTime TokenExpiration { get; set; }
    }
}
