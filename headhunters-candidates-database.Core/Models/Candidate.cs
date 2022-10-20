namespace headhunters_candidates_database.Core.Models;

public class Candidate : Entity
{
    public string Name { get; set; }
    public List<Skill> Skillset { get; set; }
    public virtual List<Company> CompanyAppliedTo { get; set; }
    public virtual List<Position> PositionAppliedTo { get; set; }
}