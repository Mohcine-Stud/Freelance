namespace Freelance.Domain.Models;

public partial class CompetenceDmExpertise
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public virtual ICollection<CompetenceOffre> CompetenceOffres { get; set; } = new List<CompetenceOffre>();

    public virtual ICollection<ComptenceDmExpertise> ComptenceDmExpertises { get; set; } = new List<ComptenceDmExpertise>();

    public virtual ICollection<CondidatComp> CondidatComps { get; set; } = new List<CondidatComp>();
}