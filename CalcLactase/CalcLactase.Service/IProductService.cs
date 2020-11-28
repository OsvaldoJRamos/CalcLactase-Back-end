using CalcLactase.Dominio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcLactase.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(Guid id);
    }
}
