using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;
using System.Diagnostics;

namespace biblioteca.Controllers;

public class DashboardController : Controller
{   
    // 1. MÉTODO:
    public IActionResult Index()
    {
        return View();
    }
    // 2. MÉTODO:
    public IActionResult Login()
    {
        return View();
    }
}