using OdevBir.Dto.Products;

namespace OdevBir.MVC.Models
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }

        public ProductDto Product { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }
    }
}
