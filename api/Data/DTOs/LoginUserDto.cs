#nullable disable

namespace Api.Data.DTOs
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Data informed by the user in order to login the user.
    /// </summary>
    public class LoginUserDto
    {
        /// <summary>
        /// Gets or sets represents username as string.
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets represents password as string.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}