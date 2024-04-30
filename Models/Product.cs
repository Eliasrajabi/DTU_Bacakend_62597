using DTU_Bacakend_62597.Models.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTU_Bacakend_62597.Models
{
    public class Product
    {

        public string? ProductId { get; set; }
        public string? Name { get; set; }

        [Column(TypeName = "decimal(18,2)")] public decimal Price { get; set; }

        public CurrencyType Currency { get; set; }
        public int RebateQuantity { get; set; }
        public int RebatePercent { get; set; }
        public string? UpsellProductId { get; set; }
        public string? FileName { get; set; }
        public string? ContentType { get; set; }
        public string? Path { get; set; }
        public int? SubcategoryId { get; set; }
        public SubCategory Subcategory { get; set; }
        
    }
}
