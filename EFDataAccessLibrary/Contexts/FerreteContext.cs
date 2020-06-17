using Microsoft.EntityFrameworkCore;
using NCliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Contexts
{
    public class FerreteContext : DbContext
    {
        public FerreteContext(DbContextOptions options) : base(options)
        {

        }
   
        public DbSet<Cliente> Clientes { get; set; }
        
    }


}
