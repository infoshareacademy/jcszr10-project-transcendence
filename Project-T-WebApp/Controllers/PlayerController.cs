﻿using Microsoft.AspNetCore.Mvc;
using Project_T_WebApp.Models;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_T_WebApp.Controllers
{
    public class PlayerController : Controller
    {
        
        //private readonly IPlayerService _playerService;
        //private readonly IActionService _actionService;

        //public PlayerController(IPlayerService playerService, IActionService actionService)
        //{
        //    _playerService = playerService;
        //    _actionService = actionService;
        //}


        //public IActionResult CreateCharacter()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateCharacter(string characterName, int raceId, int classId, string carouselControl, string carouselControl2)
        //{
        //    //characterName = Request.Form["characterName"];
        //    //classId = GetClassIdFromClassButton(carouselControl);
        //    //raceId = GetRacesIdFromRaceButton(carouselControl2);


        //    //var newPlayerCharacter = await _playerService.CreateNewCharacterAsync(characterName, raceId, classId);


        //    //return RedirectToAction("Map", "Home");
           

        //    // Przypisz ścieżkę obrazu do TempData
            

        //    return RedirectToAction("Map", "Home");
        //}

        //[HttpGet("GetAvailableActions")]
        //public IActionResult GetAvailableActions(int playerId)
        //{
        //    //PlayerCharacter player = _playerService.LoadCharacterAsync(playerId)// Pobierz gracza na podstawie playerId
        //    //var actions = player.AvailableActions;
        //    //return Ok(actions.Select(a => new { a.Name }));
        //    return null;
        //}

        //[HttpPost("PerformAction")]
        //public IActionResult PerformAction(int playerId, int actionId)
        //{
        //    return null;// Logika wykonania akcji
        //}

        //private int GetClassIdFromClassButton(string classButton)

        //{
        //    if (!string.IsNullOrEmpty(imagePath))
        //    {
        //        // Ustaw ścieżkę obrazu w sesji
        //        HttpContext.Session.SetString("selectedImagePath", imagePath);
        //    }

        //    return Ok();
        //}
        ////private int GetClassIdFromClassButton(string classButton)
        ////{
        ////    classButton = Request.Form["carousel-control"];
        ////    return classButton switch
        ////    {
        ////        "button_a" => 1,
        ////        "button_b" => 2,
        ////        "button_c" => 3,
        ////        "button_d" => 4,
        ////        _ => 0,
        ////    };
        ////}

        ////private int GetRacesIdFromRaceButton(string raceButton)
        ////{
        ////    raceButton = Request.Form["carousel-control-2"];
        ////    return raceButton switch
        ////    {
        ////        "button_f" => 1,
        ////        "button_g" => 8,
        ////        "button_h" => 3,
        ////        "button_i" => 2,
        ////        _ => 0,
        ////    };
        ////}
    }
}
