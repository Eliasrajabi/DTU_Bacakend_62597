using backend.Data.Data_transfer_object.Dtos;
using backend.Data.Data_transfer_object.ProductDto;
using DTU_Bacakend_62597.Models;

namespace backend.Data.Mapper
{
    public static class ProductMapper
    {
        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Currency = product.Currency,
                RebateQuantity = product.RebateQuantity,
                RebatePercent = product.RebatePercent,
                UpsellProductId = product.UpsellProductId,
                SubcategoryId = product.SubcategoryId,
                
         
            };
        }

        public static Product ToProductFromPostDto(this Post_ProductDto productDto)
        {
            return new Product
            {
                // ProductId = productDto.ProductId,
                Name = productDto.Name,
                Price = productDto.Price,
                Currency = productDto.Currency,
                RebateQuantity = productDto.RebateQuantity,
                RebatePercent = productDto.RebatePercent,
                UpsellProductId = productDto.UpsellProductId,
                SubcategoryId = productDto.SubcategoryId,
                
               
            };
        }

        public static Product ToProductFromPutDto(this Put_ProductDto productDto, string Id)
        {
            return new Product
            {
                ProductId = Id,
                Name = productDto.Name,
                Price = productDto.Price,
                Currency = productDto.Currency,
                RebateQuantity = productDto.RebateQuantity,
                RebatePercent = productDto.RebatePercent,
                UpsellProductId = productDto.UpsellProductId,
              
            };
        }
    }
}