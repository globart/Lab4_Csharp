namespace Domain.Repositories;

public abstract class Repository<T>
{
    private readonly List<T> _entities = new List<T>();

    public void AddRange(IEnumerable<T> entities)
    {
        _entities.AddRange(entities);
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }
}