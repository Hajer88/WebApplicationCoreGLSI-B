using Microsoft.AspNetCore.Identity;

namespace WebApplicationCoreGLSI_B.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
