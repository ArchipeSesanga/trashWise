using Microsoft.AspNetCore.Mvc;

namespace trashwise.Controllers;

public class RequestPickupController : Controller
{
    public IActionResult RequestPickup()
    {
        return View();
    }
}