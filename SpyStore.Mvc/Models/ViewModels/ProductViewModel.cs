using SpyStore.Models.Entities.Base;

namespace SpyStore.Mvc.Models.ViewModels
{
    public class ProductViewModel : EntityBase
    {
        public ProductDetails Details { get; set; } = new ProductDetails();
        public bool IsFeatured { get; set; }
        public decimal UntiCost { get; set; }
        public decimal CurrentPrice { get; set; }
        public int UntisInStock { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}