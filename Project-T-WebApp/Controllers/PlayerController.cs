using Microsoft.AspNetCore.Mvc;
using Project_Transcendence.BusinessLogic.Factories;

namespace Project_T_WebApp.Controllers
{
    public class PlayerController : Controller
    {

        private readonly Factory _playerFactory;

        public PlayerController()
        {
            _playerFactory = new();
        }

        //public IActionResult CreatePlayerCharacter()
        //{
        //    string name = string.Empty;
        //    ICharacterClass characterClass = null;
        //    ICharacterRace characterRace = null;

        //    PlayerCharacterModel playerCharacter = _playerFactory.Create(name, characterRace, characterClass);

        //    return View(playerCharacter);
        //}

    }
}
