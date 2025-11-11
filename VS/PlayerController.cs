using Microsoft.AspNetCore.Mvc;

namespace API_Aula_0511.Controllers
{
    public class PlayerController : ControllerBase
    {
        public static List<Model.Player> players = new()
        {
            new Model.Player {Id = "1", Vida = 3, QuantidadeItens = 0, PosicaoX = 0, PosicaoY = 0, PosicaoZ = 0}
        };
        [HttpGet]
        [Route("api/player")]
        public IActionResult GetPlayers()
        {
            return Ok(players);
        }

        [HttpGet]
        [Route("api/player/{id}")]
        public IActionResult GetPlayerById(string id)
        {
            var player = players.FirstOrDefault(a => a.Id == id);
            if(player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
        [HttpPost]
        [Route("api/player")]
        public IActionResult AddPlayer([FromBody] Model.Player novoPlayer)
        {
            players.Add(novoPlayer);
            return Ok(novoPlayer);
        }
        [HttpPut]
        [Route("api/player")]
        public IActionResult UpdatePlayer(string id, [FromBody] Model.Player playerAtualizado)
        {
            var player = players.FirstOrDefault(a => a.Id == id);
            if (player == null)
            {
                return NotFound();
            }
            player.Vida = playerAtualizado.Vida;
            player.QuantidadeItens = playerAtualizado.QuantidadeItens;
            player.PosicaoX = playerAtualizado.PosicaoX;
            player.PosicaoY = playerAtualizado.PosicaoY;
            player.PosicaoZ = playerAtualizado.PosicaoZ;
            return Ok(player);
        }
        [HttpDelete]
        [Route("api/player/{id}")]
        public IActionResult DeletePlayer(string id)
        {
            var player = players.FirstOrDefault(a => a.Id == id);
            if (player == null)
            {
                return NotFound();
            }
            players.Remove(player);
            return Ok(player);
        }
    }
}
