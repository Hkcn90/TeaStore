using Service.Dto;
using Service.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IProductService
    {
        string AddProduct(ProductDto productDto);
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductAsync(int id);
    }
}
