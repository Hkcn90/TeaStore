using Service.Dto;
using Service.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IProductService
    {
        void AddProduct(Products product);
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductAsync(int id);
    }
}
