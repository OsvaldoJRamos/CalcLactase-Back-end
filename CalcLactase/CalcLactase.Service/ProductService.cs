using CalcLactase.Dominio;
using CalcLactase.Repository;
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

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
