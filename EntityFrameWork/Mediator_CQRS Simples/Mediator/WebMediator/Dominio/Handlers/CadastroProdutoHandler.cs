using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebMediator.Dominio.Comandos.Requests;
using WebMediator.Dominio.Comandos.Responses;

namespace WebMediator.Dominio.Handlers
{
    public class CadastroProdutoHandler : IRequestHandler<RequestsProduto, ResponsesProduto>
    {
        public Task<ResponsesProduto> Handle(RequestsProduto request, CancellationToken cancellationToken)
        {
            var resultado = new ResponsesProduto
            {
                Id = Guid.NewGuid(),
                Nome = "Telefone",
                Date = DateTime.Now
            };

            return Task.FromResult(resultado);
        }
    }
}
