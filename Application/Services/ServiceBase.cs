using Domain;

namespace Application
{
    public class ServiceBase : IServiceBase
    {
    }
    
    public class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : EntityBase
    {
    }
}