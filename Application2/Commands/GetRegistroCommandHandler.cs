using Dominio2.Abtractions;
using Dominio2.Abtractions.Repositories;
using Dominio2.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Commands
{
    public sealed class GetRegistroCommandHandler : IRequestHandler<GetRegistroCommand,List<Registro>>
    {
        private readonly IRegistroRepository _repository;

        public GetRegistroCommandHandler(IRegistroRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Registro>> Handle(GetRegistroCommand request, CancellationToken cancellationToken)
        {
            var listaRegistros = await _repository.Get(cancellationToken);
            return listaRegistros;
        }
    }
}
