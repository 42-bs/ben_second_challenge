#nullable disable

namespace Api.Data.DTOs
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Data informed by the user in order to create a new user.
    /// </summary>
    public class CreateUserDto
    {
        /// <summary>
        /// Gets or sets represents username as string.
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets represents password as string.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets represents the password confirmation as string.
        /// </summary>
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}