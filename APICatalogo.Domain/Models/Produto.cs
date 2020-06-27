using System;

namespace APICatalogo.Domain.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string ImagemURL { get; set; }
        public int Estoque { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }


    }
}
