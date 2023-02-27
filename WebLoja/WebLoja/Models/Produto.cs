using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLoja.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Quantidade { get; set; }
        public string Descrição { get; set; }
        public List<Venda> Vendas { get; set; }
    }
}
