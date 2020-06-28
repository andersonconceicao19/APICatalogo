
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICatalogo.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
    {
        Task<IEnumerable<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(Guid id);
        Task Adicionar(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
    }
}
