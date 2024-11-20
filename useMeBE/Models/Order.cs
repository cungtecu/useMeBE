using useMeBE.Models.Enums;

namespace useMeBE.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int TableId { get; set; }

        public  OrderStatusEnum Status{ get; set; }

        public DateTime CreatAt { get; set; }
    }
}
