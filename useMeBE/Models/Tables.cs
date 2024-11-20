using useMeBE.Models.Enums;

namespace useMeBE.Models
{
    public class Tables
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        public string Name { get; set; } = null!;

        public int Size { get; set; }
        public string Place { get; set; } = null!;

        public TableStatusEnum Status { get; set; }
    }
}
