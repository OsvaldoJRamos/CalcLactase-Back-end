using CalcLactase.Dominio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcLactase.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
