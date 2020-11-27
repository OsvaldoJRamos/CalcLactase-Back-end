using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CalcLactase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        public ProdutoController()
        {

        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            var retorno = new List<Produto>()
            {
                new Produto(new System.Guid(),
                            "Leite de vaca integral",
                            "ml",
                            100,
                            104,
                            0.046,
                            "../assets/images/products/milk.jpg",
                            new List<References>()
                            {
                                new References("Valores Lactase",
                                               "http://dx.doi.org/10.1590/S0104-42302010000200025"),
                                new References("Peso Leite",
                                               "https://conversor-de-medidas.com/"),
                            }),

                new Produto(new System.Guid(),
                           "Leite em pó",
                           "g",
                           100,
                           100,
                           0.529,
                           "../assets/images/products/powdered-milk.jpg",
                           new List<References>()
                           {
                               new References("Valores Lactase",
                                              "http://dx.doi.org/10.1590/S0104-42302010000200025"),
                               new References("Peso Leite",
                                              "https://conversor-de-medidas.com/"),
                           })
                           };

            return retorno;
        }
    }
}
