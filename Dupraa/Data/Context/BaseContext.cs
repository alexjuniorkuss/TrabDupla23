using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class BaseContext : DbContext
    {
        public DbSet<Lanches> Lanches { get; set; }
        public DbSet<Bebidas> Bebidas { get; set; }

        public BaseContext():base("RefeicoesConnections")
        {
        }
    }
}
