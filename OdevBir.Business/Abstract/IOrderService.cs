
using OdevBir.Dto.Orders;


namespace OdevBir.Business.Abstract
{
    public interface IOrderService
    {
        public List<OrderDto> GetAll();
    }
}
