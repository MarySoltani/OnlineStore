using Application;

namespace InfraStructure
{
    public class Repository : IRepository
    {
    }

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : EntityBase
    {
    }
}
