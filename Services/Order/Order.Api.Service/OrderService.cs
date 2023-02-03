using Order.Api.Infrastructure;
using Order.Api.Models;

namespace Order.Api.Service
{
    public class OrderService : IOrderService
    {
        public OrderDTO GetOrderById(int Id)
        {
            return new OrderDTO()
            {
                Id = Id,
                Amount = new Random().Next(1, 1000),
                Date = DateTime.Now
            };
        }
    }
}
