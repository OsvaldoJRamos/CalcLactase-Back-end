using CalcLactase.Dominio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalcLactase.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly CalcLactaseContext _context;

        public ProductRepository(CalcLactaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var retorno = new List<Product>()
            {
                new Product(Guid.NewGuid(),
                            "Leite de vaca integral",
                            "ml",
                            100,
                            104,
                            0.046,
                            "../assets/images/products/milk.jpg",
                            new List<Reference>()
                            {
                                new Reference("Valores Lactase",
                                               "http://dx.doi.org/10.1590/S0104-42302010000200025"),
                                new Reference("Peso Leite",
                                               "https://conversor-de-medidas.com/"),
                            }),

                new Product(Guid.NewGuid(),
                           "Leite em pó",
                           "g",
                           100,
                           100,
                           0.529,
                           "../assets/images/products/powdered-milk.jpg",
                           new List<Reference>()
                           {
                               new Reference("Valores Lactase",
                                              "http://dx.doi.org/10.1590/S0104-42302010000200025"),
                               new Reference("Peso Leite",
                                              "https://conversor-de-medidas.com/"),
                           })
                           };

            return retorno;
        }
    }
}

