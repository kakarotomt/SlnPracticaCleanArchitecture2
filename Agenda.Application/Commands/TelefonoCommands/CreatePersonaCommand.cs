using Agena.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.Commands.TelefonoCommands
{
    public sealed record CreatePersonaCommand(string nombres, string apellidos, DateTime fecha) : IRequest<Persona>;
}
