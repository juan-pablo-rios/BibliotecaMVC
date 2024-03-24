using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;
using System.Diagnostics;

namespace biblioteca.Controllers;

public class PrestamoController : Controller
{
    // 1. MÉTODO:
    public IActionResult Index()
    {
        return View();
    }
    // 2. MÉTODO:
    public IActionResult RegistrarPrestamo()
    {
        return View();
    }
    // 3. MÉTODO:
    public IActionResult RenovarPrestamo()
    {
        return View();
    }
    // 4. MÉTODO:
    public IActionResult RegistrarDevolución()
    {
        return View();
    }
}