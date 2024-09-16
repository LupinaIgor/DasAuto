using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCar.Controllers;

public class PageController : Controller

{
    public IActionResult ColorPage()
    {
        return View();
    }
}