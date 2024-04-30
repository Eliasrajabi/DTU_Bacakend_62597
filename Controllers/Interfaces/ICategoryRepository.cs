
using backend.Database.Data_transfer_object.Request.Category;

using DTU_Bacakend_62597.Models;

namespace backend.Controllers.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task<Category> CreateCategoryAsync(Category category);
        Task<Category?> UpdateCategoryAsync(int id, Put_CategoryDto categoryDto);
        Task<Category?> DeleteCategoryAsync(int id);
        Task<Category?> CategoryNameExisting(string name);
    }
}