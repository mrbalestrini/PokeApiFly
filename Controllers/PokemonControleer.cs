using Microsoft.AspNetCore.Mvc;

namespace PokeApiFly.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public PokemonController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetPokemon(string name)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name.ToLower()}");

            if (!response.IsSuccessStatusCode)
                return NotFound("Pokémon não encontrado.");

            var content = await response.Content.ReadAsStringAsync();
            return Content(content, "application/json");
        }
    }
}