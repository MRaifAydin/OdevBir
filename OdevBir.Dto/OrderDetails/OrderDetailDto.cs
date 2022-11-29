using OdevBir.Dto.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Dto.OrderDetails
{
    public class OrderDetailDto
    {
        public int Id { get; set; }

        public ProductDto Product { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

    }
}
