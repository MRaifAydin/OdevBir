using OdevBir.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Abstract
{
    public interface IShipperService
    {
        public List<Shipper> GetAll();

        public void InsertOne(Shipper entity);

    }
}
