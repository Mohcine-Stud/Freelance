﻿namespace Freelance.Domain.Models;

public  partial class Candidat
{
    public int Id { get; set; }

    public string? Titre { get; set; }
    public string? Gender { get; set; }

    public string? Avatar { get; set; }

    public string? Adresse { get; set; }

    public DateTime? DateNaissance { get; set; }

    public string? Tele { get; set; }

    public string? Mobilite { get; set; }

    public string? Disponibilite { get; set; }

    public string? Ville { get; set; }
    //public string ApplicationUserId { get; set; }
    //public ApplicationUser ApplicationUser { get; set; }

    public virtual ICollection<CondidatComp> CondidatComps { get; set; } = new List<CondidatComp>();

    public virtual ICollection<ConsultaionProfil> ConsultaionProfils { get; set; } = new List<ConsultaionProfil>();

    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    public virtual ICollection<Formation> Formations { get; set; } = new List<Formation>();
    public virtual ICollection<Messagerie> Messageries { get; set; } = new List<Messagerie>();

    public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();
}
