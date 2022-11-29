using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
using OdevBir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Concrete
{
    public class ShipperManager : IShipperService
    {
        private readonly IShipperRepository _shipperRepository;

        public ShipperManager(IShipperRepository shipperRepository)
        {
            _shipperRepository = shipperRepository;
        }

        public List<Shipper> GetAll()
        {
            return _shipperRepository.GetAll().ToList();
        }

        public void InsertOne(Shipper entity)
        {
            _shipperRepository.InsertOne(entity);
        }
    }
}
