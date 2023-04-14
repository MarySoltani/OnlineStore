using Domain;

namespace Application
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unit) : base(unit)
        {
        }
    }
}