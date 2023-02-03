using Order.Api.Models;

namespace Order.Api.Infrastructure
{
    public interface IOrderService
    {
        public OrderDTO GetOrderById(int Id);
    }
}
