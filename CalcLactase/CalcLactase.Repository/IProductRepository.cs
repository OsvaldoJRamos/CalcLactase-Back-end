using CalcLactase.Dominio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcLactase.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
