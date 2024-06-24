using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaDeEscape.Models;

namespace SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
        return View();
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala != Escape.GetEstadoJuego())
        {
            RedirectToAction("Habitacion" + Escape.GetEstadoJuego());
        }
        else
        {
            if(Escape.ResolverSala(sala, clave))
            {
                RedirectToAction("Habitacion" + Escape.GetEstadoJuego());
            }
            else
            {
                return View();
                ViewBag.Error = "La respuesta es incorrecta.";
            }
        }

        return View();
    }
}
