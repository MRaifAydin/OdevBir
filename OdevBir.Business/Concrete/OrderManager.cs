using AutoMapper;
using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
using OdevBir.Dto.Orders;
using OdevBir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderManager(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public List<OrderDto> GetAll()
        {
            var entity = _orderRepository.GetAll();

            return entity.Select(x => _mapper.Map<OrderDto>(entity)).ToList();
        }
    }
}
