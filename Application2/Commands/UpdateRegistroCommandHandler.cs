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
    public sealed class UpdateRegistroCommandHandler : IRequestHandler<UpdateRegistroCommand, Registro>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRegistroRepository _repository;

        public UpdateRegistroCommandHandler(IUnitOfWork unitOfWork, IRegistroRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<Registro> Handle(UpdateRegistroCommand request, CancellationToken cancellationToken)
        {
            var registro = await _repository.Get(request.Id, cancellationToken);
            if (registro == null) 
                throw new ArgumentException();

            registro.Nombre = request.Nombre;
            registro.Documento = request.Documento;
            registro.Apartamento = request.Apartamento;

            _repository.Update(registro, cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return registro;
        }
    }
}
