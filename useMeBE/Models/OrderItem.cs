using useMeBE.Models.Enums;

namespace useMeBE.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int MenuItemId { get; set; }

        public int Quanlity { get; set; }

        public OrderStatusEnum Status { get; set; }
    }
}
