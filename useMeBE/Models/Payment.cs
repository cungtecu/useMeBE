using useMeBE.Models.Enums;

namespace useMeBE.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Decimal TotalAmount { get; set; }

        public PaymentMethodEnum PaymentMethod { get; set; }

        public  PaymentStatusEnum Status { get; set; }
    }
}
