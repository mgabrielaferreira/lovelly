using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLovely.Model
{
    public class Produto
    {
        public int ProdutoId {get; set;}
        public decimal Preco {get; set;}

        public string Categoria { get; set;}

        public string Descricao {get; set;}
    }
}