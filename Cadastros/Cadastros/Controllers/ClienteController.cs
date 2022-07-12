using Cadastros.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AdicionarCliente adicionarCliente)
        {
            var clienteAdicionado = await _mediator.Send(adicionarCliente);

            if(clienteAdicionado) return Ok(adicionarCliente);

            return BadRequest(clienteAdicionado);
        }

        [HttpPatch]
        public async Task<IActionResult> Patch([FromBody]AtualizarNomeCliente atualizarNomeCliente)
        {
            var clienteAtualizado = await _mediator.Send(atualizarNomeCliente);

            if (clienteAtualizado) return Ok(clienteAtualizado);

            return BadRequest(clienteAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Int64 id)
        {
            var clienteApagado = await _mediator.Send(new DeletarCliente() { Id = id });

            if (clienteApagado) return Ok(clienteApagado);

            return BadRequest(clienteApagado);
        }
    }
}
