using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Transcendence.BuisnessLogic.Models;

namespace Project_T_WebApp.Controllers
{
    public class UserController : Controller
    {

        private readonly IAuthService _authService;

        public UserController(IAuthService authService)
        {
            _authService = authService;
        }

        // Formularz rejestracji
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Rejestracja usera
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Wywołaj usługę autoryzacji do utworzenia użytkownika
                var result = await _authService.RegisterAsync(model);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }

                // Jeśli rejestracja nie powiodła się, dodaj błędy do ModelState
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);

        }
     


    }
}
