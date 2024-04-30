

using backend.Controllers.Interfaces;
using backend.Data;
using backend.Database.Data_transfer_object.Request.Category;
using DTU_Bacakend_62597.data;
using DTU_Bacakend_62597.Models;
using Microsoft.EntityFrameworkCore;


namespace backend.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Category?> CategoryNameExisting(string name)
        {
            var category = _context.Categories
            .Include (s=>s.SubCategory)
            /*  .Include(p=>p.Product)*/

            .FirstOrDefaultAsync(x => x.Name == name);
            return category;
        }

        public async Task<Category> CreateCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category?> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories
            .Include(s=>s.SubCategory)
            //.Include(p=>p.Product)
            .ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories
            .Include(s=> s.SubCategory)
            //.Include(p=>p.Product)
            .FirstOrDefaultAsync(x => x.CategoryId == id);
        }


        public async Task<Category?> UpdateCategoryAsync(int id, Put_CategoryDto categoryDto)
        {
            var existingCategory = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            if (existingCategory is null)
            {
                return null;
            }

            existingCategory.Name = categoryDto.CategoryName;
          
            await _context.SaveChangesAsync();
            return existingCategory;
        }
    }
}
