using Microsoft.AspNetCore.Mvc;

namespace aspstudy.Controllers;

public class HomeController : Controller
{
    // GET
    public string Index()
    {
        return "Hello World!";
    }
}