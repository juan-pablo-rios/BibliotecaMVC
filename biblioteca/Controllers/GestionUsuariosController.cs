using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;
using System.Diagnostics;

namespace biblioteca.Controllers;

public class GestionUsuariosController : Controller
{
    // 1. MÉTODO:
    public IActionResult Index()
    {
        return View();
    }
    // 2. MÉTODO:
    public IActionResult ActualizarUsuario()
    {
        return View();
    }
    // 3. MÉTODO:
    public IActionResult RegistrarUsuario()
    {
        return View();
    }
    // 4. MÉTODO:
    public IActionResult EliminarUsuario()
    {
        return View();
    }
}