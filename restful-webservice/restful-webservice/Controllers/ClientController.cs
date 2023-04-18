using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
        "smth about Clients"
    };

        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "getClient")]
        public IEnumerable<Client> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Client
            {
            })
            .ToArray();
        }
        [HttpPost("test")]
        public string test()
        {
            var url = Url.Link("xxx", null);
            return $"The url of Route Name xxx is {url}";
        }
    }
}

