using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
        "smth about reports"
    };

        private readonly ILogger<ReportController> _logger;

        public ReportController(ILogger<ReportController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "getReport")]
        public IEnumerable<Report> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Report
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
