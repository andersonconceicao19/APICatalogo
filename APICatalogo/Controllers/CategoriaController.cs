using APICatalogo.Domain.Interfaces;
using APICatalogo.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("v1/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        
         private readonly ICategoriaRepository _categ;
        public CategoriaController(ICategoriaRepository categ)
        {
            _categ = categ;
        }

        [HttpPost("novacategoria")]
        public IActionResult Adicionar(Categoria categoria)
        {
            var result =  _categ.Adicionar(categoria);
            return Ok(result);
        }

        public IActionResult Index()
        {
            var result = _categ.ObterTodos();
            return Ok(result);
        }
         
         
    }
}
