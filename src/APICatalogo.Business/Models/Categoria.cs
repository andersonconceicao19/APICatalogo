using System;
using System.Collections.Generic;

namespace APICatalogo.Business.Models
{
    public class Categoria
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public IEnumerable<Produto> Produto { get; set; }
    }
}
