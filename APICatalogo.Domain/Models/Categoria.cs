using System.Collections.Generic;


namespace APICatalogo.Domain.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public string ImageURL { get; set; }
        public IEnumerable<Produto> Produto { get; set; }
    }
}
