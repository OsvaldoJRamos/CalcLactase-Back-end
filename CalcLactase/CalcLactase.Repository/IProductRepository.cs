using CalcLactase.Dominio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcLactase.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(Guid id);
    }
}
