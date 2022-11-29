using OdevBir.Dto.OrderDetails;


namespace OdevBir.Business.Abstract
{
    public interface IOrderDetailService
    {
        public List<OrderDetailDto> GetById(int id);
    }
}