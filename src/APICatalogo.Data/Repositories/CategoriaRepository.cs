using APICatalogo.Business.Interfaces;
using APICatalogo.Business.Models;
using APICatalogo.Data.Context;

namespace APICatalogo.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(MyContext context) : base(context)
        {

        }
    }
}
