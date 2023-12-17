﻿using Microsoft.AspNetCore.Mvc;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_T_WebApp.Controllers
{
    public class PlayerController : Controller
    {

        private readonly IPlayerService _playerService;
        private readonly IActionService _actionService;

        public PlayerController(IPlayerService playerService, IActionService actionService)
        {
            _playerService = playerService;
            _actionService = actionService;
        }


        public IActionResult CreateCharacter()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCharacter(string characterName, int raceId, int classId, string carouselControl, string carouselControl2)
        {  
            var character = await _playerService.CreateNewCharacterAsync(characterName, raceId, classId);

            return RedirectToAction("Map", "Home");
        }

        [HttpGet("GetAvailableActions")]
        public IActionResult GetAvailableActions(int playerId)
        {
            PlayerCharacter player; // Pobierz gracza na podstawie playerId
            var actions = player.AvailableActions;
            return Ok(actions.Select(a => new { a.Id, a.Name }));
        }

        [HttpPost("PerformAction")]
        public IActionResult PerformAction(int playerId, int actionId)
        {
            // Logika wykonania akcji
        }

        private int GetClassIdFromClassButton(string classButton)
        {
            classButton = Request.Form["carousel-control"];
            return classButton switch
            {
                "button_a" => 1,
                "button_b" => 2,
                "button_c" => 3,
                "button_d" => 4,
                _ => 0,
            };
        }

        private int GetRacesIdFromRaceButton(string raceButton)
        {
            raceButton = Request.Form["carousel-control-2"];
            return raceButton switch
            {
                "button_f" => 1,
                "button_g" => 8,
                "button_h" => 3,
                "button_i" => 2,
                _ => 0,
            };
        }
    }
}
