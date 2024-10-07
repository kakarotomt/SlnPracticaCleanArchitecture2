using Dominio2.Abtractions.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Commands
{
    public sealed record DeleteRegistroCommand(int id) : IRequest;
}
