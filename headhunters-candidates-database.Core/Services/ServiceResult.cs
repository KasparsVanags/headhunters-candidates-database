using FlightPlanner.Core.Interfaces;

namespace headhunters_candidates_database.Core.Services;

public class @void
{
    public @void(bool success)
    {
        Success = success;
        Errors = new List<string>();
    }

    public @void SetEntity(IEntity entity)
    {
        Entity = entity;
        return this;
    }

    public @void AddError(string error)
    {
        Errors.Add(error);
        return this;
    }
    
    public bool Success { get; private set; }
    public IEntity Entity { get; private set; }
    
    public IList<string> Errors { get; private set; }

    public string FormattedErrors => string.Join(", ", Errors);
}