using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;
using System.Diagnostics;

namespace biblioteca.Controllers;

public class LoginController : Controller
{
    // 1. MÉTODO:
    public IActionResult Index()
    {
        return View();
    }
}