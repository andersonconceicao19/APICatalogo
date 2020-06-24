using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public string ImageURL { get; set; }
    }
}
