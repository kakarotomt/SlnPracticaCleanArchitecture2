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
    public sealed class AddRegistroCommandHandler : IRequestHandler<AddRegistroCommand, Registro>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRegistroRepository _repository;

        public AddRegistroCommandHandler(IUnitOfWork unitOfWork, IRegistroRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<Registro> Handle(AddRegistroCommand request, CancellationToken cancellationToken)
        {
            var newRegistro = new Registro() { 
                Apartamento = request.Apartamento,
                Documento = request.Documento,
                Nombre = request.Nombre
            };
            _repository.Add(newRegistro, cancellationToken);
            await _unitOfWork.SaveChangesAsync();

            return newRegistro;

        }
    }
}
