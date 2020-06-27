using APICatalogo.Data.Context;
using APICatalogo.Domain.Interfaces;
using APICatalogo.Domain.Models;

namespace APICatalogo.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DContext context) : base(context) { }
    }
}
