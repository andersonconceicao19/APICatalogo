using System.Collections.Generic;
using System.Threading.Tasks;
using APICatalogo.Api.DTO;
using APICatalogo.Business.Interfaces;
using APICatalogo.Business.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoria;
        private readonly IMapper _mapper;

        public CategoriaController(ICategoriaRepository categoria, IMapper mapper)
        {
            _categoria = categoria;
            _mapper = mapper;
        }

        [HttpGet("obter")]
        public async Task<ActionResult> Obter()
        {
            
            return Ok(_mapper.Map<IEnumerable<CategoriaDTO>>(await _categoria.ObterTodos()));
        }

        [HttpPost("adicionar")]        
        public async Task<ActionResult> Adicionar([FromBody]CategoriaDTO categoria)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("ops");
            }
            var categ = _mapper.Map<Categoria>(categoria);
            await _categoria.Adicionar(categ);
            return Ok(categoria);
        }


    }
}
