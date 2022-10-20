namespace headhunters_candidates_database.Core.Models;

public class Candidate : Entity
{
    public string Name { get; set; }
    public List<string> Skillset { get; set; }
}