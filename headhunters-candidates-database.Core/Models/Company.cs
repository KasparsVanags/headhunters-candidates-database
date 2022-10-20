namespace headhunters_candidates_database.Core.Models;

public class Company
{
    public string Name { get; set; }
    public virtual List<Candidate> Candidates { get; set; }
    public virtual List<Position> OpenPositions { get; set; }
}