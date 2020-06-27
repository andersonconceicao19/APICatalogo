using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.DataContext;
using APICatalogo.Models;
using APICatalogo.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("v1/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DContext _categ;
        public CategoriaController(DContext categ)
        {
            _categ = categ;
        }

        [HttpPost("novacategoria")]
        public IActionResult Adicionar(Categoria categoria)
        {
            var result =  _categ.Categorias.Add(categoria);
            _categ.SaveChanges();
            return Ok(result);
        }

        public IActionResult Index()
        {
            var result = _categ.Categorias.ToList();
            return Ok(result);
        }
    }
}
