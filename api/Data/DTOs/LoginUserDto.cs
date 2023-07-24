namespace Api.Data.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class LoginUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserPassword { get; set; }
    }
}