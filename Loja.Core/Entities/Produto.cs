using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Core.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DescricaoCompleta { get; set; }
        public decimal Valor { get; set; }
        public string ImagemUrl { get; set; }
        public string ThumbUrl { get; set; }
        public bool Destaque { get; set; }
    }
}
