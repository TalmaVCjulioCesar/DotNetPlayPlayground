namespace ECommerceAPI.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public int Price { get; private set; }
        public string Description { get; private set; }

        public Category Category { get; private set; }
        public string[] Images { get; private set; }
    }
}
