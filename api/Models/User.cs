namespace Api.Models
{
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// Model of User object.
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
            : base()
        {
        }
    }
}
