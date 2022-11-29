using OdevBir.Core.Models;
using OdevBir.Dto.Products;

namespace OdevBir.Business.Abstract
{
    public interface IProductService
    {
        public ProductDto GetById(int id);
    }
}
