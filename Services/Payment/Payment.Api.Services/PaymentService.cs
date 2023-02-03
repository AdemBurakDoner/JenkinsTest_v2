using Payment.Api.Infrastructure;
using Payment.Api.Models;

namespace Payment.Api.Services
{
    public class PaymentService : IPaymentService
    {
        public PaymentDTO GetPaymentById(int Id)
        {
            Random rnd = new Random();
            Array values = Enum.GetValues(typeof(PaymentType));

            return new PaymentDTO()
            {
                Id = Id,
                OrderId = rnd.Next(1, 100),
                Amount = rnd.Next(1, 1000),
                Type = (PaymentType)values.GetValue(rnd.Next(values.Length)),
                Date = DateTime.Now,
            };
        }
    }
}
