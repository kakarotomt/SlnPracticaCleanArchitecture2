using Agena.Domain.Abstracts;
using Agena.Domain.Abstracts.Repository;
using Agena.Domain.Entities;
using Agenda.Application.TelefonoCommands;
using MediatR;

namespace Agenda.Application.Commands.TelefonoCommands
{
    public sealed class CreateTelefonoCommandHandler : IRequestHandler<CreateTelefonoCommand, int>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ITelefonoRespository _telefonoRespository;

        public CreateTelefonoCommandHandler(IUnitOfWork unitOfWork, ITelefonoRespository telefonoRespository)
        {
            _unitOfWork = unitOfWork;
            _telefonoRespository = telefonoRespository;
        }

        public async Task<int> Handle(CreateTelefonoCommand request, CancellationToken cancellationToken)
        {
            var newTelephone = new Telefono()
            {
                 NumeroTelefono = request.NumeroTelefono,
                 Pais = request.Pais,
                 PersonaId = request.PersonaId
            };

            _telefonoRespository.CreateAsync(newTelephone, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return newTelephone.Id;
        }
    }
}
