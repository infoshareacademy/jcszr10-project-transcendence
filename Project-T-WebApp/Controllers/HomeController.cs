using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Transcendence_Database.DataAccess;
using System.Diagnostics;

namespace Project_T_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Play()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Exit()
        {
            return View();
        }
        public IActionResult CreateCharacter()
        {
            return View();
        }
        public IActionResult ClassInfo()
        {
            return View();
        }
        public IActionResult Map()
        {
            return View();
        }
        public IActionResult Quest()
        {
            return View();
        }
        public IActionResult Fight()
        {
            return View();
        }
        public IActionResult Beaten()
        {
            return View();
        }

        public IActionResult ShowCharacterClassAbilities()
        {
            var characterClass = _context.Classes
               .Include(cc => cc.Ability) // Upewniamy się, że pobieramy również umiejętności
               .FirstOrDefault(cc => cc.Id == 1);

            if (characterClass == null)
            {
                // Obsłuż sytuację, gdy klasa postaci o podanym Id nie została znaleziona
                return NotFound();
            }

            // Pobierz umiejętności danej klasy postaci
            var characterClassAbilities = characterClass.Ability.ToList();

            // Przekształć te umiejętności na odpowiedni model widoku, jeśli to konieczne

            return View(characterClassAbilities);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View();
        }
    }
}