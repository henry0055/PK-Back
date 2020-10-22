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
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        

        [HttpGet]
        public async Task<RootObject> GetAll()
        {
            PokemonService service = new PokemonService();
            return await service.GetAllPokemons();
        }
        [HttpGet("{clave}")]
        public async Task<RootObject> Filtrar(string clave)
        {
            PokemonService service = new PokemonService();
            return await service.Filtrar(clave);
        }

        [HttpPost]

        public async Task<Pokemon> GetSingle ( [FromBody] Result url  )
        {
            PokemonService service = new PokemonService();
            return await service.GetSinglePokemon(url.url);
        }

    }
}
