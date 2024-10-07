﻿using Dominio.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public sealed record AgendaAddCommand(string name, string number) : IRequest<Agenda>;
}
