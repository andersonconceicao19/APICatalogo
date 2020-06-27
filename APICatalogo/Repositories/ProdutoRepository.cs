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
    public class ProdutoRepository : IProdutoRepository<Produto>
    {

        private readonly DContext _context;

        public ProdutoRepository(DContext context)
        {
            _context = context;            
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task Adicionar(Produto entity)
        {
            var produto = _context.Produtos.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Produto entity)
        {
            _context.Produtos.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Guid id)
        {
            _context.Produtos.Remove(await _context.Produtos.FindAsync(id));
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
