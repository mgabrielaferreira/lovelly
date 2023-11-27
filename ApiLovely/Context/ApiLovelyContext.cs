using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLovely.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiLovely.Context
{
    public class ApiLovelyContex: DbContext
    {
        public ApiLovelyContext(DbContextOptions options) : base(options) {}
        public DbSet<Cliente> Clientes {get; set; }

        public DbSet<Pedido> Pedidos {get; set; }

        public DbSet<Produto> Produtos  {get; set; }

    }
}