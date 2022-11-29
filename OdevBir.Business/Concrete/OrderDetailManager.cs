using AutoMapper;
using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
using OdevBir.Dto.OrderDetails;
using OdevBir.Dto.Products;
using OdevBir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IMapper _mapper;
        public OrderDetailManager(IOrderDetailRepository orderDetailRepository, IMapper mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }

        public List<OrderDetailDto> GetById(int id)
        {
            var entity = _orderDetailRepository.Get(x => x.OrderId == id);

            return entity.Select(x => _mapper.Map<OrderDetailDto>(x)).ToList();
        }
    }
}
