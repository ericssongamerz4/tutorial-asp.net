// Importa el espacio de nombres System.Diagnostics, que proporciona clases para trabajar con procesos, eventos, y diagnósticos.
using System.Diagnostics;
// Importa el espacio de nombres para trabajar con controladores en ASP.NET Core MVC.
using Microsoft.AspNetCore.Mvc;
// Importa el espacio de nombres para los modelos definidos en la aplicación.
using Tutorial_ASP.NET.Models;

namespace Tutorial_ASP.NET.Controllers
{
    // Define un controlador llamado HomeController que hereda de la clase base Controller.
    public class HomeController : Controller
    {
        // Campo privado para el registro de mensajes de diagnóstico y errores.
        private readonly ILogger<HomeController> _logger;

        // Constructor del controlador que recibe una instancia de ILogger para el controlador.
        public HomeController(ILogger<HomeController> logger)
        {
            // Asigna la instancia de ILogger al campo privado.
            _logger = logger;
        }

        // Acción que maneja las solicitudes a la ruta 'Home/Index'.
        // Retorna una vista llamada "Index".
        public IActionResult Index()
        {
            return View();
        }

        // Acción que maneja las solicitudes a la ruta 'Home/Privacy'.
        // Retorna una vista llamada "Privacy".
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
}
