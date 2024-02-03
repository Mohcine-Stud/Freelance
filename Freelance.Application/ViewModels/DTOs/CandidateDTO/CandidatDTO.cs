﻿using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CandidateDTO;

public partial class CandidatDTO
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
