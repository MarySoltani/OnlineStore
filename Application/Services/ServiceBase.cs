using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class ServiceBase : IServiceBase
    {
        protected readonly IUnitOfWork _context;

        public ServiceBase(IUnitOfWork context)
        {
            _context = context;
        }
        protected DbSet<T> DbSet<T>()
            where T : class, IEntityBase
            => _context.CommandSet<T>();

    }

    public class QueryServiceBase<TEntity> : ServiceBase, IQueryServiceBase<TEntity>
        where TEntity : EntityBase
    {

        public QueryServiceBase(IUnitOfWork context) : base(context)
        {
        }

        protected IQueryable<TEntity> Queryable => _context.QuerySet<TEntity>();


        public bool Any(Expression<Func<TEntity, bool>> where)
        {
            return Queryable.Any(where);
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> where)
        {
            return Queryable.AnyAsync(where);
        }


        public TEntity Get(Func<TEntity, bool> key)
        {
            return Queryable.SingleOrDefault(key);
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> key)
        {
            return Queryable.SingleOrDefaultAsync(key);
        }

        public IEnumerable<TEntity> List()
        {
            return Queryable.ToList();
        }
        public Task<IEnumerable<TEntity>> ToListAsync()
        {
            return Task.FromResult(Queryable.ToList().AsEnumerable());
        }
    }
    public class ServiceBase<T> : QueryServiceBase<T>, IServiceBase<T>
        where T : EntityBase
    {


        public ServiceBase(IUnitOfWork context) : base(context)
        {
        }

        private DbSet<T> Set => DbSet<T>();

        public void Add(T item)
        {
            Set.Add(item);
        }

        public void Delete(T key)
        {
            var item = Set.Find(key);

            if (item == null) { return; }

            Set.Remove(item);
        }

        public void Update(T item)
        {
            Set.Update(item);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

    }
}