using Microsoft.AspNetCore.Identity;

namespace DesignPatterns.Template.Models
{
    public class AppUser:IdentityUser<string>
    {
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}
