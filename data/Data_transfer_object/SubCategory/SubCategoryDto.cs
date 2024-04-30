

using System.ComponentModel.DataAnnotations;
using backend.Data.Data_transfer_object.Dtos;


namespace backend.Database.Data_transfer_object.Dtos
{
    public class SubCategoryDto
    {
        public int SubCategoryId { get; set; }
        [Required]
        public string SubCategoryName { get; set; }
   
        public int CategoryId { get; set; }
        public CategoryDto? Category { get; set; }

        public List<ProductDto> Product { get; set; } = new List<ProductDto>();

    }
}