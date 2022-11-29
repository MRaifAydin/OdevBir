using OdevBir.Dto.Shippers;



namespace OdevBir.Business.Abstract
{
    public interface IShipperService
    {
        public List<ShipperDto> GetAll();

        public void InsertOne(ShipperDto entity);

    }
}
