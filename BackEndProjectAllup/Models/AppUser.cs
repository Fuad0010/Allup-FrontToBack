

using Microsoft.AspNetCore.Identity;

namespace BackEndProjectAllup.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
