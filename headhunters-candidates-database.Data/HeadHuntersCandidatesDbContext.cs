using headhunters_candidates_database.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace headhunters_candidates_database.Data;

public class HeadhuntersCandidatesDbContext : DbContext, IHeadhuntersCandidatesDbContext
{
    public HeadhuntersCandidatesDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Position> OpenPositions { get; set; }

    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}