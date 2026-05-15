using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

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
    [HttpGet]
     public IActionResult GenerarSugerencia(SugeridorReceta datos)
    {
       int edad = datos.calcularEdad();
    string platoSugerido = datos.determinarPlato();
    int tiempoEsperado = datos.CalcularTiempo();
    string dificultad = datos.DeterminarDificultad();

    ViewBag.edad = edad;
    ViewBag.platoSugerido = platoSugerido;
    ViewBag.tiempoEsperado = tiempoEsperado;
    ViewBag.dificultad = dificultad;
    ViewBag.nombre = datos.nombreCocinero;

    return View("resultado");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
