using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouteController : Controller
    {
        Route route = new Route();
        private static readonly string[] Summaries = new[]
        {
        "smth about Routes"
    };

        private readonly ILogger<RouteController> _logger;

        public RouteController(ILogger<RouteController> logger)
        {
            _logger = logger;
        }
        [HttpGet("getReport")]
        public Route Get()
        {
            return route;
        }
        [HttpPost("addRoute")]
        public string add(string dados, string coordenadas)
        {
            route.Coordenadas_Local = dados;
            route.Dados_Local = coordenadas;

            return $"Cadastrado com sucesso.";
        }

        [HttpPost("editRoute")]
        public string edit(string dados, string coordenadas)
        {
            route.Coordenadas_Local = dados;
            route.Dados_Local = coordenadas;

            return $"Editado com sucesso.";
        }
        [HttpPost("deleteRoute")]
        public string delete(string dados)
        {
            //deve ter um id para selecionar posteriormente
            route.Coordenadas_Local = "";
            route.Dados_Local = "";

            return $"Deletado com sucesso.";
        }
    }
}
