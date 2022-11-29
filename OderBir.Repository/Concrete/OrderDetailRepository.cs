using OderBir.Repository.Common;
using OdevBir.Core.Models;
using OdevBir.DataAccess;
using OdevBir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Repository.Concrete
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(NorthwndContext northwndContext) : base(northwndContext)
        {
        }
    }
}
