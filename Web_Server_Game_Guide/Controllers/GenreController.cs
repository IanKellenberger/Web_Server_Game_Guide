using Microsoft.AspNetCore.Mvc;

namespace Web_Server_Game_Guide.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult GenresList()
        {
            return View();
        }

        public IActionResult Survival()
        {
            return View();
        }

        public IActionResult Sports()
        {
            return View();
        }

        public IActionResult RPG()
        {
            return View();
        }

        public IActionResult Roguelike()
        {
            return View();
        }

        public IActionResult CityBuilders()
        {
            return View();
        }
    }
}
