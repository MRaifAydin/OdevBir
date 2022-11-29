using OdevBir.Dto.Customers;

namespace OdevBir.Business.Abstract
{
    public interface ICustomerService
    {
        public CustomerDto GetById(int id);
    }
}
