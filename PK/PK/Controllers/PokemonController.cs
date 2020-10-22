using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PK.Models;
using PK.Services;

namespace PK.Controllers
{
    
   
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PokemonController : Controller
    {
        private readonly IPokemonService _IPokeService;

        public PokemonController(IPokemonService IPokemonService)
        {
            _IPokeService = IPokemonService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _IPokeService.GetAllPokemons());
        }
        
        [HttpGet("Filtrar/{clave}")]
        public async Task<IActionResult> Filtrar(string clave)
        {
            return Ok(await _IPokeService.Filtrar(clave));
        }
        [HttpPost("GetSingle")]
        public async Task<IActionResult> GetSingle ( [FromBody] Result url  )
        {
            return Ok(await _IPokeService.GetSinglePokemon(url.url));
        }

    }
}
