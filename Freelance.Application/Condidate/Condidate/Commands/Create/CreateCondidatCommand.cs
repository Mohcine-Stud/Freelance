﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Condidate.Condidate.Commands.Create
{
    public class CreateCondidatCommand : IRequest<int>
    {
        public int Id { get; set; }

        public string? Titre { get; set; }

        public string? Avatar { get; set; }

        public string? Adresse { get; set; }

        public DateTime? DateNaissance { get; set; }

        public string? Tele { get; set; }

        public string? Mobilite { get; set; }

        public string? Disponibilite { get; set; }

        public string? Ville { get; set; }
    }
}
