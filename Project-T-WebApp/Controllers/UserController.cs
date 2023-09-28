using Microsoft.AspNetCore.Mvc;

namespace Project_T_WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DisplayUserCharacters()
        {
            return View();
        }

    }
}
