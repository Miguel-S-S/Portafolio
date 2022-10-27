using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using portafolio.Servicios;


namespace portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;

    public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
    {
        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
    }

    public IActionResult Index()
    {
      
            
        //    ViewBag.nombre = "Miguel Saucedo";
        // _logger.LogCritical("Este es un mensaje de LogCritical 6"); 
        // _logger.LogError("Este es un mensaje de LogError 5"); 
        // _logger.LogWarning("Este es un mensaje de LogWarning 4");
        // _logger.LogInformation("Este es un mensaje de logInformation 3");
        // _logger.LogDebug("Este es un mensaje de LogDebug 2"); 
        // _logger.LogTrace("Este es un mensaje de LogTrace 1"); 

        // var repositorioProyectos = new RepositorioProyectos();  
        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
        return View(modelo);
       
        // {
        //     Nombre = "Saucedo Miguel",
        //     Edad = 8            
        // };
      
        // ViewBag.Edad = 99";
        // return View("Index", Persona);        
    }

   

    public IActionResult Proyectos()
    {
        var proyectos = repositorioProyectos.ObtenerProyectos();
        return View(proyectos);
    }

    public IActionResult Contacto()
    {
        return View();
    }
   
    [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
    {
        return RedirectToAction("Gracias");
    }

    public IActionResult Gracias()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
