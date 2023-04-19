using Microsoft.AspNetCore.Mvc;

namespace restful_webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        Client client = new Client();

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
        public Client Get()
        {
            return client;
        }

        [HttpPost("addCliente")]
        public string add(string email, string nome, string apelido)
        {
            client.Email = email;
            client.Nome = nome;
            client.Apelido = apelido;

            return $"Cadastrado com sucesso.";
        }

        [HttpPost("editClient")]
        public string edit(string email, string nome, string apelido)
        {
            client.Email = email;
            client.Nome = nome;
            client.Apelido = apelido;

            return $"Editado com sucesso.";
        }
        [HttpPost("deleteClient")]
        public string delete(string nome)
        {
            //deve ter um id para selecionar posteriormente
            client.Email = "";
            client.Nome = "";
            client.Apelido = "";

            return $"Deletado com sucesso.";
        }
    }
}

