using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public async Task<ResponsesProduto> Cadastro ([FromServices] IMediator mediator, [FromBody] RequestsProduto request)
        {
            return await mediator.Send(request);
        }
    }
}
