using APICatalogo.DataContext;
using APICatalogo.Models;
using APICatalogo.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositories
{
    public class CategoriaRepository : ICategoriaRepository<Categoria>
    {
        private readonly DContext _context;

        public CategoriaRepository(DContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> ObterTodasCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
