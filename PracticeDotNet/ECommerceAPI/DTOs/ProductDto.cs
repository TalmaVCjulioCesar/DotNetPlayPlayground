using ECommerceAPI.Models;

namespace ECommerceAPI.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Title { get;  set; }
        public int Price { get;  set; }
        public string Description { get;  set; }

        public Category Category { get;  set; }
        public string[] Images { get;  set; }
    }
}
