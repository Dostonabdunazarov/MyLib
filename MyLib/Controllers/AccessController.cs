using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyLib.Controllers
{
    public class AccessController : Controller
    {
        [AllowAnonymous]
        public IActionResult AllAccess()
        {
            return View();
        }

        [Authorize(Roles = "User, Admin")]
        public IActionResult UserAccess()
        {
            return View();
        }


        [Authorize(Roles = "Admin")]
        public IActionResult AdminAccess()
        {
            return View();
        }

    }
}
