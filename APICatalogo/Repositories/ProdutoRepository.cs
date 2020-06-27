using APICatalogo.DataContext;
using APICatalogo.Models;
using APICatalogo.Repositories.Interfaces;

namespace APICatalogo.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {

        public ProdutoRepository(DContext context) : base(context) { }


    }
}
