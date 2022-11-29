using AutoMapper;
using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
using OdevBir.Dto.Shippers;
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
        private readonly IMapper _mapper;
        public ShipperManager(IShipperRepository shipperRepository, IMapper mapper)
        {
            _shipperRepository = shipperRepository;
            _mapper = mapper;
        }

        public List<ShipperDto> GetAll()
        {
            var entity = _shipperRepository.GetAll();

            return entity.Select(x => _mapper.Map<ShipperDto>(x)).ToList();
        }

        public void InsertOne(ShipperDto dto)
        {
            var entity = _mapper.Map<Shipper>(dto);
            _shipperRepository.InsertOne(entity);
        }
    }
}
