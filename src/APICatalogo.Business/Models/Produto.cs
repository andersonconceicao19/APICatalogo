using System;

namespace APICatalogo.Business.Models
{
    public class Produto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public string Image { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Today;
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
