using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public interface ICommandService<T> where T : class
    {
        void Add(T item); 

        void Delete(T entity);

        void Update(T item);
     
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}