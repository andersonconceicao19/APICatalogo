using APICatalogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositories.Interfaces
{
    public interface IProdutoRepository<TEntity>: IDisposable where TEntity : Entity
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);
        Task<Produto> Adicionar(TEntity entity);
        Task<Produto> Remover(Guid id);
        Task<Produto> Atualizar(TEntity entity);

    }
}
