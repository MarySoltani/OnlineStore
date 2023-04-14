using Domain;

namespace Application
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        public ProductService(IUnitOfWork unit) : base(unit)
        {
        }
    }
}
