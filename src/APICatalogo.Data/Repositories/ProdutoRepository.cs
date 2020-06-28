using APICatalogo.Business.Interfaces;
using APICatalogo.Business.Models;
using APICatalogo.Data.Context;

namespace APICatalogo.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MyContext context) : base(context)
        {

        }
    }
}
