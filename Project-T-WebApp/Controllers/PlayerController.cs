using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Transcendence.BuisnessLogic.Services;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;

namespace Project_T_WebApp.Controllers
{
    public class PlayerController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public PlayerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //private readonly IPlayerService _playerService;

        //public PlayerController(IPlayerService playerService)
        //{
        //    _playerService = playerService;
        //}


        //[HttpPost]
        //public async Task<IActionResult> Create(string name, int raceId, int classId)
        //{
        //    var character = await _playerService.CreateCharacterAsync(name, raceId, classId);

        //    if (character != null)
        //    {

        //        return View(character);

        //    }          
        //    return View(character);
        //}
        [HttpGet]
        public IActionResult CreateCharacter()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateCharacter(string characterName)
        {
            if (ModelState.IsValid)
            {
                
                var newPlayerCharacter = new PlayerCharacter { Name = characterName };
                _dbContext.Characters.Add(newPlayerCharacter);
                _dbContext.SaveChanges();

                
                return RedirectToAction("Map", "Home");
            }

            
            return View();
        }
        public IActionResult ClassInfo()
        {
            return View();
        }
        public IActionResult Inventory()
        {
            return View();
        }
    }
}
