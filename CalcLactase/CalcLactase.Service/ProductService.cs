using CalcLactase.Dominio;
using CalcLactase.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcLactase.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _productRepository.GetById(id);
        }
    }
}
