using System.Collections.Generic;


namespace APICatalogo.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public string ImageURL { get; set; }
        public ICollection<Produto> Produto { get; set; }
    }
}
