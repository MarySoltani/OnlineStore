using Domain;

namespace Application
{
    public interface IServiceBase
    {
    }

    public interface IServiceBase<TEntity> : IServiceBase
    where TEntity : class, IEntityBase
    {
    }
}
