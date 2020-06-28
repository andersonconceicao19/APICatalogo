using System.Threading.Tasks;
using APICatalogo.Business.Interfaces;
using APICatalogo.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoria;

        public CategoriaController(ICategoriaRepository categoria)
        {
            _categoria = categoria;
        }

        [HttpGet("obter")]
        public async Task<ActionResult> Obter()
        {            
            return Ok(await _categoria.ObterTodos());
        }

        [HttpPost("adicionar")]        
        public async Task<ActionResult> Adicionar([FromBody]Categoria categoria)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("ops");
            }

            await _categoria.Adicionar(categoria);
            return Ok(categoria);
        }


    }
}
