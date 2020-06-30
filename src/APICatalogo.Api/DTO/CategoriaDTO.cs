using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Api.DTO
{
    public class CategoriaDTO
    {   
        [Key]
        public Guid Id { get; set; }
        [MaxLength(20, ErrorMessage = "O Nome deve ter no 20 caracter!")]
        public string Nome { get; set; }
    }
}
