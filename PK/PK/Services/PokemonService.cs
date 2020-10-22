using PK.Models;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace PK.Services
{
    public interface IPokemonService
    {
        //Task<Pokemon> GetAllPokemon();
        Task<RootObject> GetAllPokemons();
        Task<Pokemon> GetSinglePokemon(string url);
        Task<RootObject> Filtrar(string clave);


    }
    public class PokemonService : IPokemonService
    {   
        

        public async Task<RootObject> GetAllPokemons()
        {
            try
            {
                Random random = new Random();
                int OffSet = random.Next(1, 10);
                string AllUrl = "https://pokeapi.co/api/v2/pokemon?offset="+OffSet+"0&limit=11";
                RootObject RootObject = new RootObject();
                var httpClient = new HttpClient();
                var json = await httpClient.GetStringAsync(AllUrl);
                RootObject = JsonConvert.DeserializeObject<RootObject>(json);

                
                return  IncrutarImagen(RootObject);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<Pokemon> GetSinglePokemon(string url)
        {
            //url = "https://pokeapi.co/api/v2/pokemon/1/";
            try
            {
                Pokemon Pokemon = new Pokemon();
                Pokemon Pokemon2 = new Pokemon();
                var httpClient = new HttpClient();
                var Data = await httpClient.GetStringAsync(url);
                var dataObj = JObject.Parse(Data);
                Pokemon = JsonConvert.DeserializeObject<Pokemon>(Data);
                return Pokemon;
                
            }
            catch (Exception e)
            {

                throw;
            }
        }
       
        public async Task<RootObject> Filtrar (string clave)
        {
            
            string AllUrl = "https://pokeapi.co/api/v2/pokemon?limit=1100";
            RootObject RootObject = new RootObject();
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(AllUrl);
            RootObject = JsonConvert.DeserializeObject<RootObject>(json);

            RootObject.results = RootObject.results.Where(x => x.name.Contains(clave)).ToList();

            return IncrutarImagen(RootObject);
        }

        public RootObject IncrutarImagen(RootObject rootObject)
        {
            var httpClient = new HttpClient();
            foreach (var pokemon in rootObject.results)
            {
                string[] url = pokemon.url.Split('/');
                
                string imageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + url[6] + ".png";
                pokemon.image = imageUrl;
            }
            return rootObject;
        }

    }
}
