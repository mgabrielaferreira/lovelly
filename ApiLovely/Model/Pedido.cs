using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLovely.Model
{
    public class Pedido
    {
        public Produto Produto { get; set;}
        public int Valor { get; set;}
        public int Quantidade {get; set;}
        public Cliente Cliente { get; set;}

    }
}