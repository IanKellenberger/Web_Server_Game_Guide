using Microsoft.AspNetCore.Mvc;

public class GenreController : Controller
{
    public IActionResult GenresList()
    {
        var genres = new List<string>
        {
            "Survival",
            "Sports",
            "RPG",
            "Roguelike",
            "City Builder"
        };

        return View(genres);
    }
}
