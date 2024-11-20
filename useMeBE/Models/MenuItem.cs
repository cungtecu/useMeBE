namespace useMeBE.Models
{
    public class MenuItem
    {
        public int id { get; set; }

        public int CatogoryId { get; set; }

        public string Name { get; set; }

        public  Decimal Price { get; set; }

        public string Description { get; set; }

        public bool Available { get; set; }

    }
}
