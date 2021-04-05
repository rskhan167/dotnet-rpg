using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character obj = new Character();
        /* private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        }; */

        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            this._characterService = characterService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpGet("GetPower")]
        public IActionResult GetPower()
        {
            var obj1 = obj.Strength + obj.Intelligence;
            return Ok(obj1);
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}
