

using backend.Data.Mapper;
using backend.Database.Data_transfer_object.Dtos;
using backend.Database.Data_transfer_object.Request.SubCategory;
using DTU_Bacakend_62597.Models;

public static class SubCategoryMapper
{
    public static SubCategoryDto ToSubCategoryDto(this SubCategory subCategory)
    {
        return new SubCategoryDto
        {
            SubCategoryId = subCategory.SubCategoryId,
            SubCategoryName = subCategory.Name,
            CategoryId = subCategory.CategoryId,
            Product = subCategory.Product?.Select(p => p.ToProductDto()).ToList()
        };
    }

    public static SubCategory ToSubCategoryFromPostDto(this Post_SubCategoryDto subCategoryDto)
    {
        return new SubCategory
        {
            Name = subCategoryDto.SubCategoryName,
            CategoryId = subCategoryDto.CategoryId,
           
        };
    }

    public static SubCategory ToSubCategoryFromPutDto(this Put_SubCategoryDto putSubCategoryDto)
    {
        return new SubCategory
        {
            
            Name = putSubCategoryDto.SubCategoryName,
            // CategoryId = putSubCategoryDto.CategoryId,
           
        };
    }
}