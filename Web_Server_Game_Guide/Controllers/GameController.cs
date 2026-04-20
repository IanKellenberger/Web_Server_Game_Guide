using Microsoft.AspNetCore.Mvc;

namespace Web_Server_Game_Guide.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
