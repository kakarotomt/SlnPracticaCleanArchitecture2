using Dominio.Abstractions;
using Dominio.Abstractions.Repositories;
using Dominio.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public sealed class AgendaAddCommandHandler : IRequestHandler<AgendaAddCommand, Agenda>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAgendaRepository _agendaRepository;

        public AgendaAddCommandHandler(IUnitOfWork unitOfWork, IAgendaRepository agendaRepository)
        {
            _unitOfWork = unitOfWork;
            _agendaRepository = agendaRepository;
        }

        public async Task<Agenda> Handle(AgendaAddCommand request, CancellationToken cancellationToken)
        {
            var newAgenda = new Agenda() { 
             Name = request.name, 
             Number = request.number
            };

            _agendaRepository.Insert(newAgenda);
            await _unitOfWork.SaveChangesAsync();

            return newAgenda;
        }
    }
}
