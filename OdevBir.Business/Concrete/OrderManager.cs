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
    public class OrderManager : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll().ToList();
        }
    }
}
