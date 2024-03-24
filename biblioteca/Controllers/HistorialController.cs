using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;
using System.Diagnostics;

namespace biblioteca.Controllers;

public class HistorialController : Controller
{
    // 1. MÉTODO:
    public IActionResult Index()
    {
        return View();
    }
    // 2. MÉTODO:
    public IActionResult BuscarPrestamo()
    {
        return View();
    }
    // 3. MÉTODO:
    public IActionResult MostrarHistorial()
    {
        return View();
    }
}