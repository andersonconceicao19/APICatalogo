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
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly DContext _context;
        protected readonly DbSet<TEntity> DbSet;
        protected Repository(DContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> ObterTodos()
        {

            return await DbSet.ToListAsync();
        }

        public async Task Adicionar(TEntity entity)
        {
            var produto = DbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Guid id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }


    }
}
