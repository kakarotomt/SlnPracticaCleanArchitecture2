using Dominio2.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Commands
{
    public sealed record GetRegistroCommand():IRequest<List<Registro>>;
}
