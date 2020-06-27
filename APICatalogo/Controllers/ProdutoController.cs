using APICatalogo.Domain.Interfaces;
using APICatalogo.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("v1/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        
        private readonly IProdutoRepository _prod;
        public ProdutoController(IProdutoRepository produto)
        {
            _prod = produto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _prod.ObterTodos();
            return Ok(result);
        }

       [HttpPost("Adicionar")]
        public IActionResult Add(Produto produto)
        {
            var prod = _prod.Adicionar(produto);

            return Ok(prod);
        }
         
    }
}
