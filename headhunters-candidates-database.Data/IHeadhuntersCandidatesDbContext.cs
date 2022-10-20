using headhunters_candidates_database.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace headhunters_candidates_database.Data;

public interface IHeadhuntersCandidatesDbContext
{
    DbSet<Candidate> Candidates { get; set; }
    DbSet<Company> Companies { get; set; }
    DbSet<Position> OpenPositions { get; set; }
    DbSet<T> Set<T>() where T : class;
    EntityEntry<T> Entry<T>(T entity) where T : class;
    int SaveChanges();
    Task<int> SaveChangesAsync();
}