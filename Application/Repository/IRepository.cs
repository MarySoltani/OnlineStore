using Domain;

namespace Application
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository
    where TEntity : class, IEntityBase
    {
    }
}
