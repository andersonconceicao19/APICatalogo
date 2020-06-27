
using APICatalogo.Data.Context;
using APICatalogo.Domain.Interfaces;
using APICatalogo.Domain.Models;

namespace APICatalogo.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DContext context) : base(context) { }


    }
}
