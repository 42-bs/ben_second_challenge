namespace Api.Models
{
    using Microsoft.AspNetCore.Identity;

    public class User: IdentityUser
    {
        public User(): base()
        {
        }
    }
}
