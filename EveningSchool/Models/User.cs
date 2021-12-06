using Microsoft.AspNetCore.Identity;

namespace EveningSchool.Models
{
    public class User : IdentityUser
    {
        public string UserImage { get; set; }
    }
}