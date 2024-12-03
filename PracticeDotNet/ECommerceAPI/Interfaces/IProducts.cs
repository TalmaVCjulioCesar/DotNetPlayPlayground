using ECommerceAPI.DTOs;

namespace ECommerceAPI.Interfaces
{
    public interface IProducts
    {
        public Task<IEnumerable<ProductDto>> Get();

        public Task<ProductDto> GetById(int id);
    }
}
