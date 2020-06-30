using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Api.DTO
{
    public class ProdutoDTO
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(20, ErrorMessage = "O nome deve ter no maximo 20 catacter!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [MinLength(10, ErrorMessage = "Deve conter no minimo 10 caracter!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Estoque { get; set; }
        public string Image { get; set; }
        public string ImageUpload { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}
