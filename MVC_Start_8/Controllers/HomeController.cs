using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Start_8.Models;

namespace MVC_Start_8.Controllers;

public class HomeController : Controller
{
    public IActionResult Book(int id)
    {
        return View();
    }

    public IActionResult AboutUs(int id)
    {
        return View();
    }

    public IActionResult SignUp(int id)
    {
        return View();
    }

    public IActionResult index(int id)
    { 

        return View();
    }

   
    public IActionResult Locations()
    {
        return View();
    }

    public IActionResult Feedback()
    {
        return View();
    }
    public IActionResult success(int id)
    {
        return View();
    }

    public IActionResult success2()
    {
        return View();
    }

    public ViewResult Analytics(int id)
    {
        return View();
    }
}
