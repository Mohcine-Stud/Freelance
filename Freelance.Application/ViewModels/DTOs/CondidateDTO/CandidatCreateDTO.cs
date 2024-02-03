﻿using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CondidateDTO;

public partial class CandidatCreateDTO
{
    public string? Titre { get; set; }

    public string? Avatar { get; set; }

    public string? Adresse { get; set; }

    public DateTime? DateNaissance { get; set; }

    public string? Tele { get; set; }

    public string? Mobilite { get; set; }

    public string? Disponibilite { get; set; }

    public string? Ville { get; set; }
}