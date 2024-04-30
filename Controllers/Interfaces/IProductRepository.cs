


using backend.Controllers.Helpers;
using backend.Data.Data_transfer_object.ProductDto;
using DTU_Bacakend_62597.Models;

namespace backend.Controllers.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(ProductQueryObjects productQuery);
        Task<Product?> GetProductByIdAsync(string id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product?> UpdateProductAsync(string id, Put_ProductDto productDto);
        Task<Product?> DeleteProductAsync(string id);
     
        Task<bool> ProductExists(string id);
    }
}