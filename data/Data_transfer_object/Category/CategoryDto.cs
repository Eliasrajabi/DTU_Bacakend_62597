
using System.ComponentModel.DataAnnotations;
using backend.Data.Data_transfer_object.Dtos;
using backend.Data.Data_transfer_object.ProductDto;

namespace backend.Database.Data_transfer_object.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        public string? Name { get; set; }
        
        public List<SubCategoryDto> SubCategory { get; set; } = new List<SubCategoryDto>();
        public List<ProductDto> Product { get; set; } = new List<ProductDto>();
    }
}