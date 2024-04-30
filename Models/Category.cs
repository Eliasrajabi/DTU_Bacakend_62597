namespace DTU_Bacakend_62597.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<SubCategory> SubCategory { get; set; } = new List<SubCategory>();
        
    }
}
