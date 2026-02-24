using Microsoft.AspNetCore.Mvc;
using ViewGameDemo.Models;
using ViewGameDemo.Data;

namespace ViewGameDemo.Controllers
{ 
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            var games = GameRepository.Games;
            return View(games);
        }

        public IActionResult Play(int id)
        {
            var game = GameRepository.Games.FirstOrDefault(g => g.Id == id);

            if (game == null)
                return NotFound();

            return View(game);
        }
    }
}
