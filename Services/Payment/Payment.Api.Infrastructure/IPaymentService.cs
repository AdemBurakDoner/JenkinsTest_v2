using Payment.Api.Models;

namespace Payment.Api.Infrastructure
{
    public interface IPaymentService
    {
        public PaymentDTO GetPaymentById(int Id);
    }
}
