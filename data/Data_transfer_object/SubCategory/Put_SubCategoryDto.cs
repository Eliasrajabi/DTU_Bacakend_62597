using System.ComponentModel.DataAnnotations;
using backend.Data.Data_transfer_object.ProductDto;

public class Put_SubCategoryDto
{
   
    [Required]
    [StringLength(255)]
    public string SubCategoryName { get; set; }

}