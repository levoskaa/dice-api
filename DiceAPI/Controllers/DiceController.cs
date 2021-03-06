﻿using DiceAPI.Services;
using DiceAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DiceAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DiceController : ControllerBase
  {
    private readonly IDiceService diceService;

    public DiceController(IDiceService diceService)
    {
      this.diceService = diceService;
    }

    [HttpGet("roll")]
    public DiceThrowVM GetDiceRolls([FromQuery] int diceSize, [FromQuery] int diceCount = 1)
    {
      return diceService.Roll(diceSize, diceCount);
    }

    [HttpGet("greeting")]
    public string GreetUser([FromQuery] string name = "World")
    {
      return $"Hello {WebUtility.UrlDecode(name)}!";
    }
  }
}
