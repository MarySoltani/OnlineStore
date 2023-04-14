using Domain;

namespace Application
{
    public class OrderItemService : ServiceBase<OrderItem>, IOrderItemService
    {
        public OrderItemService(IUnitOfWork unit) : base(unit)
        {
        }
    }
}