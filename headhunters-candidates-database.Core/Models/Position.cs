namespace headhunters_candidates_database.Core.Models;

public class Position : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual List<Company> Companies { get; set; }
    public virtual List<Candidate> Candidates { get; set; }
}