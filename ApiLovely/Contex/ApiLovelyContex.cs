using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLovely.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiLovely.Contex
{
    public class ApiLovelyContex: DbContext
    {
        public ApiLovelyContex(DbContextOptions options) : base(options) {}
        public DbSet<Cliente> Clientes {get; set; }

        public DbSet<Pedido> Pedidos {get; set; }

        public DbSet<Produto> Produtos  {get; set; }

    }
}