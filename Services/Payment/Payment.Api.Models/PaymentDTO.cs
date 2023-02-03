namespace Payment.Api.Models
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public PaymentType Type { get; set; }
        public DateTime Date { get; set; }
    }

    public enum PaymentType
    {
        Cash,
        CreditCard
    }
}
