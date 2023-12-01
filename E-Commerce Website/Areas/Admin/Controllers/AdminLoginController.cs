using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLogInController : Controller
    {
      
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Confirm() 
        {
            return View(); 
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
