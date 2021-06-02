using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Core.Commands;
using MyStore.Core.Infra.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Api.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ICommandHandler<ConsultarClientesPorAnoNascimento> _consultarClientesPorAnoNascimento;

        public ClienteController(ICommandHandler<ConsultarClientesPorAnoNascimento> consultarClientesPorAnoNascimento)
        {
            _consultarClientesPorAnoNascimento = consultarClientesPorAnoNascimento;
        }

        [HttpGet]
        public IActionResult ConsultarClientesPorAnoNascimento(int anoNascimento )
        {
            var command = new ConsultarClientesPorAnoNascimento()
            {
                AnoNascimento= anoNascimento
            };

            _consultarClientesPorAnoNascimento.Execute(command);
            return Ok(command.Result);
        }
    }
}
