namespace DTU_Bacakend_62597.Models
{
    public class Order
    {
        public string OrderId { get;  set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public List<Product>? Products { get; set; }
        public string? Company { get; set; }
        public string? Country { get; set; }
        public string? VatNumber { get; set; }
        
    }
}
