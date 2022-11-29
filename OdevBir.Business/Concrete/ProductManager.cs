using AutoMapper;
using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
using OdevBir.Dto.Products;
using OdevBir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public ProductDto GetById(int id)
        {
            var entity = _productRepository.Get(x => x.ProductId == id).FirstOrDefault();
            return _mapper.Map<ProductDto>(entity);
        }
    }
}
