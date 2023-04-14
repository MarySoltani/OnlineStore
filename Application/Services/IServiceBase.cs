using Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace Application
{
    public interface IServiceBase
    {

    }
    public interface IQueryServiceBase<T> : IServiceBase
    where T : class, IEntityBase
    {

        bool Any(Expression<Func<T, bool>> where);

        Task<bool> AnyAsync(Expression<Func<T, bool>> where);


        T Get(Func<T, bool> key);

        Task<T> GetAsync(Expression<Func<T, bool>> key);

        IEnumerable<T> List();
        Task<IEnumerable<T>> ToListAsync();

    }
    public interface IServiceBase<TEntity> : IServiceBase, ICommandService<TEntity>, IQueryServiceBase<TEntity>
    where TEntity : class, IEntityBase
    {
    }
}