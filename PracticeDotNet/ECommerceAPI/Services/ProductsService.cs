using ECommerceAPI.DTOs;
using ECommerceAPI.Interfaces;
using System.Text.Json;

namespace ECommerceAPI.Services
{
    public class ProductsService : IProducts
    {
        private HttpClient _httpClient;
        public ProductsService(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDto>> Get() 
        {
            var result = await _httpClient.GetAsync(_httpClient.BaseAddress);
            var body = await result.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<IEnumerable<ProductDto>>(body, options);
        }

        public async Task<ProductDto> GetById(int id) 
        {
            var result = await _httpClient.GetAsync(_httpClient.BaseAddress + "/"+id);
            var body = await result.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<ProductDto>(body, options);
        }
    }
}
