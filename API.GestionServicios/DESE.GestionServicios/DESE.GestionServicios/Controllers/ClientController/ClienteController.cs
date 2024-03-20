using DESE.Application.Commands.Client;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DESE.GestionServicios.Controllers.ClientController
{
    [Route("controller")]
    [ApiController]
    public class ClienteController : ApiBaseController
    {
        [HttpPost]
        [Route("CrearCliente")]

        public async Task<IActionResult> CrearCliente(CrearClienteCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
