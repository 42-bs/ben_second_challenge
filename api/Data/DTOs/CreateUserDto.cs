namespace Api.Data.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class CreateUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        [Required]
        [Compare("UserPassword")]
        public string UserPasswordConfirmation { get; set; }
    }
}