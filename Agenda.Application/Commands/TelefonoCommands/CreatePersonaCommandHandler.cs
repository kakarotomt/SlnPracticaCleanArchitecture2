using Agena.Domain.Abstracts;
using Agena.Domain.Abstracts.Repository;
using Agena.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Commands.TelefonoCommands
{
    public sealed class CreatePersonaCommandHandler : IRequestHandler<CreatePersonaCommand, Persona>
    {

        private readonly IPersonaRepository _personaRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreatePersonaCommandHandler(IPersonaRepository personaRepository, IUnitOfWork unitOfWork)
        {
            _personaRepository = personaRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Persona> Handle(CreatePersonaCommand request, CancellationToken cancellationToken)
        {
            var persona =  new Persona() {  Apellidos = request.apellidos, FechaNacimiento = DateOnly.FromDateTime( request.fecha), Nombres = request.nombres};
            var result = _personaRepository.CreateAsync(persona,cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return persona;
        }
    }
}
