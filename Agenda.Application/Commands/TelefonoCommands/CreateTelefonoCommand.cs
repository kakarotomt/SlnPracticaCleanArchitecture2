using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.TelefonoCommands
{
    public sealed record CreateTelefonoCommand(
        string NumeroTelefono ,
        string Pais ,
        int PersonaId 
    ) : IRequest<int>;
}
