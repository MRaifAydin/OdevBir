using OdevBir.Core.Models;


namespace OdevBir.Business.Abstract
{
    public interface IProductService
    {
        public Product GetById(int id);
    }
}
