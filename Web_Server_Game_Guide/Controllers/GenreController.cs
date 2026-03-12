using Microsoft.AspNetCore.Mvc;

namespace Web_Server_Game_Guide.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
