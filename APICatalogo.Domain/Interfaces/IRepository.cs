using APICatalogo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICatalogo.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(Guid id);
        Task Adicionar(TEntity entity);
        Task Remover(Guid id);
        Task Atualizar(TEntity entity);
    }
}
