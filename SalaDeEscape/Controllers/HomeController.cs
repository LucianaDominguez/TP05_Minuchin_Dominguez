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
        string habitacion = "Habitacion"+ Escape.GetEstadoJuego();
        return View(habitacion);
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala != Escape.GetEstadoJuego())
        {
             
             return View("Habitacion" + Escape.GetEstadoJuego()); 
        }
        else
        {
            if(Escape.ResolverSala(sala, clave) && (+Escape.GetEstadoJuego()-1) != 6 )
            {
                
               return View("Habitacion" + (Escape.GetEstadoJuego())); 
            }
            else if (Escape.GetEstadoJuego() == 6)
            {
                return View("Victoria");
            }
            else
            { 
                ViewBag.Error = "La respuesta es incorrecta.";
                return View("Habitacion" + Escape.GetEstadoJuego());
                
            }
        }

        
    }
}
