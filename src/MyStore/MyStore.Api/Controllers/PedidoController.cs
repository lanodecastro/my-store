using Microsoft.AspNetCore.Mvc;
using MyStore.Core.Commands;

namespace MyStore.Api.Controllers
{
    [Route("v1/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly ICommandHandler<EfetuarPedido> _efetuarPedidoHandler;
        public PedidoController(ICommandHandler<EfetuarPedido> efetuarPedidoHandler)
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
