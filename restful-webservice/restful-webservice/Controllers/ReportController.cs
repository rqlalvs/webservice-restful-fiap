using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : Controller
    {

        Report report = new Report();
        private static readonly string[] Summaries = new[]
        {
        "smth about Routes"
    };

        private readonly ILogger<RouteController> _logger;

        public ReportController(ILogger<RouteController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "getReport")]
        public Report Get()
        {
            return report;
        }
        [HttpPost("addReport")]
        public string add(string report, string resolvido, string data)
        {

            return $"Cadastrado com sucesso.";
        }

        [HttpPost("editReport")]
        public string edit(string report, string resolvido, string data)
        {


            return $"Editado com sucesso.";
        }
        [HttpPost("deleteReport")]
        public string delete(string nome)
        {

            return $"Deletado com sucesso.";
        }

    }
}
