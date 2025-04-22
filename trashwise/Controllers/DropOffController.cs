using Microsoft.AspNetCore.Mvc;

namespace trashwise.Controllers;

public class DropOffController : Controller
{
    public IActionResult DropOff()
    {
        return View();
    }
}