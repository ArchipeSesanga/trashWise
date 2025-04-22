using Microsoft.AspNetCore.Mvc;

namespace trashwise.Controllers;

public class CommunityEventController : Controller
{
    public IActionResult CommunityEvent()
    {
        return View();
    }
}