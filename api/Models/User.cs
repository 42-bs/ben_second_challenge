namespace Api.Models
{
    using Microsoft.AspNetCore.Identity;

    public class User: IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public User(): base()
        {
        }
    }
}
