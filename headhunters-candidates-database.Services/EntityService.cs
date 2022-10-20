using headhunters_candidates_database.Core.Models;
using headhunters_candidates_database.Core.Services;
using headhunters_candidates_database.Data;

namespace headhunters_candidates_database.Services;

public class EntityService<T> : DbService, IEntityService<T> where T : Entity
{
    public EntityService(IHeadhuntersCandidatesDbContext context) : base(context)
    {
    }

    public void Create(T entity)
    {
        Create<T>(entity);
    }

    public void Delete(T entity)
    {
        Delete<T>(entity);
    }

    public void Update(T entity)
    {
        Update<T>(entity);
    }

    public List<T> GetAll()
    {
        return GetAll<T>();
    }

    public T? GetById(int id)
    {
        return GetById<T>(id);
    }

    public IQueryable<T> Query()
    {
        return Query<T>();
    }
}