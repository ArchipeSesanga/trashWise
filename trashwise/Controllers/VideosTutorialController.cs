using Microsoft.AspNetCore.Mvc;

namespace trashwise.Controllers;

public class VideosTutorialController : Controller
{
    public IActionResult VideosTutorial()
    {
        return View();
    }
}