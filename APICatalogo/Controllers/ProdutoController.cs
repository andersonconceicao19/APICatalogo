
using APICatalogo.DataContext;
using APICatalogo.Models;using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APICatalogo.Controllers
{
    [Route("v1/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly DContext _produto;
        public ProdutoController(DContext produto)
        {
            _produto = produto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _produto.Produtos.ToList();
            return Ok(result);
        }

       [HttpPost("Adicionar")]
        public IActionResult Add(Produto produto)
        {
            var prod = _produto.Produtos.Add(produto);

            return Ok(prod);
        }
    }
}
