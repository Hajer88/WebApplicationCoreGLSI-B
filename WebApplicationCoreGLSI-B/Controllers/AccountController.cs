using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreGLSI_B.Models;

namespace WebApplicationCoreGLSI_B.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _identity;
        public AccountController(UserManager<ApplicationUser> identity)
        {
            _identity = identity;
        }

        public IActionResult GetAllUSers()
        {
            return View(_identity.Users);
        }
    }
}
