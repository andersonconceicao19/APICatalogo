using APICatalogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositories.Interfaces
{
    public interface ICategoriaRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<Categoria>> ObterTodasCategorias();
    }
}
