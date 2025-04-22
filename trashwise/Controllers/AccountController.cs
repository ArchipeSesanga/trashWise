using Microsoft.AspNetCore.Mvc;

namespace trashwise.Controllers;

public class AccountController : Controller
{
    public IActionResult LogoutView()
    {
        return View(); //returns the logout page 

    }
    
    public IActionResult Logout() 
    {
        //needs to be implemented 
        return RedirectToAction("Index", "Home");//return the index page after the uesr was logged out 

    }
}