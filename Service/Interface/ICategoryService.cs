using Service.Dto;
using Service.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);
    }
}