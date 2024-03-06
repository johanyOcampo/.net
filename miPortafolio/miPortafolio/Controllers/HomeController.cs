using Microsoft.AspNetCore.Mvc;
using miPortafolio.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace miPortafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var = proyectos = ObtenerProyectos().Take(2).ToList();
            var = modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "App para estadisticas",
                    Descripcion="Te puede ayudar a calcular tus ventas",
                    ImagenUrl="/images/estadistifa.jpg",
                    Link = "https://issuu.com/ari9310/docs/revista_digital..pptx"
                },
                new Proyecto
                {
                    Titulo = "App para esuchar musica",
                    Descripcion="Te puede ayudar a relajarte",
                    ImagenUrl="/images/appmusic.jpg",
                    Link = "https://issuu.com/ari9310/docs/revista_digital..pptx"
                },
            };
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
}
