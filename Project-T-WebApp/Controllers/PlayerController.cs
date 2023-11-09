using Microsoft.AspNetCore.Mvc;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_T_WebApp.Controllers
{
    public class PlayerController : Controller
    {

        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }


        [HttpPost]
        public async Task<IActionResult> Create(string name, int raceId, int classId)
        {
            var character = await _playerService.CreateCharacterAsync(name, raceId, classId);

            if (character != null)
            {
                
                return View(character);

            }          
            return View(character);
        }
    }
}
