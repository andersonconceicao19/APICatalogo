using APICatalogo.Business.Interfaces;
using APICatalogo.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICatalogo.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly MyContext _context;
        private readonly DbSet<TEntity> _Db;
        public Repository(MyContext context)
        {
            _context = context;
            _Db = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await _Db.ToListAsync();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await _Db.FindAsync(id);
        }

        public async Task Adicionar(TEntity entity)
        {
            _Db.Add(entity);
            await SaveChange();
        }

        public async Task Atualizar(TEntity entity)
        {
            var result = _Db.Update(entity);
            await SaveChange();
        }       

        public async Task Remover(Guid id)
        {            
            _Db.Remove(await _Db.FindAsync(id));
            await SaveChange();
           
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
        public async Task<int> SaveChange()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
