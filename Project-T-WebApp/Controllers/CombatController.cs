using Microsoft.AspNetCore.Mvc;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_T_WebApp.Controllers
{
    public class CombatController : Controller
    {



        [HttpGet("GetAvailableActions")]
        public IActionResult GetAvailableActions(int playerId)
        {
            PlayerCharacter player = new(); // Pobierz gracza na podstawie playerId
            var actions = player.AvailableActions;
            return Ok(actions.Select(a => new { a.Name }));
        }

        [HttpPost("PerformAction")]
        public IActionResult PerformAction(int playerId, int actionId)
        {
            return null;// Logika wykonania akcji
        }
    }
}
