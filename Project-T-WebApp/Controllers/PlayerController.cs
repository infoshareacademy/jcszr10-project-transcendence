﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Transcendence.BuisnessLogic.Services;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;

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
        public async Task<IActionResult> CreateCharacter(string characterName, int raceId, int classId, string carouselControl, string carouselControl2)
        {
                characterName = Request.Form["characterName"];
                classId = GetClassIdFromClassButton(carouselControl);
                raceId = GetRacesIdFromRaceButton(carouselControl2);


                var newPlayerCharacter = await _playerService.CreateNewCharacterAsync(characterName, raceId, classId);


            return View();
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
                "button_g" => 2,
                "button_h" => 3,
                "button_i" => 4,
                _ => 0,
            };
        }
    }
}
