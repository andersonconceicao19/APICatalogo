﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string ImagemURL { get; set; }
        public int Estoque { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}
