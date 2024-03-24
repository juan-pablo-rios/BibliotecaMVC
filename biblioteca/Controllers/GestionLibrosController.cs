using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;
using System.Diagnostics;

namespace biblioteca.Controllers;

public class GestionLibrosController : Controller
{
    // 1.MÉTODO:
    public IActionResult Index()
    {
        return View();
    }
    // 2. MÉTODO:
    public IActionResult ActualizarLibro()
    {
        return View();
    }
    // 3. MÉTODO:
    public IActionResult RegistrarLibro()
    {
        return View();
    }
    // 4. MÉTODO:
    public IActionResult EliminarLibro()
    {
        return View();
    }
}