using Domain;

namespace Application
{
    public class OrderService : ServiceBase<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unit) : base(unit)
        {
        }
    }
}