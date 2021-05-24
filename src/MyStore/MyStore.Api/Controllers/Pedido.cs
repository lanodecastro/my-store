using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Api.Controllers
{
    [Route("v1/pedido")]
    [ApiController]
    public class Pedido : ControllerBase
    {
        private readonly ICommandHandler<EfetuarPedido> _efetuarPedidoHandler;
        public Pedido(ICommandHandler<EfetuarPedido> efetuarPedidoHandler)
        {
            _efetuarPedidoHandler = efetuarPedidoHandler;
        }

        public IActionResult EfetuarPedido([FromBody] EfetuarPedido command)
        {
            _efetuarPedidoHandler.Execute(command);

            return Ok();
        }
    }
}
