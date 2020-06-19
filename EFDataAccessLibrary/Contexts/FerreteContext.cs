using Microsoft.EntityFrameworkCore;
using NCliente;
using System;
using System.Collections.Generic;
using System.Text;
using NCategoria;
using NDireccion;
using NFactura;
using NProducto;

namespace EFDataAccessLibrary.Contexts
{
    public class FerreteContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=dbFerreteria;Trusted_Connection=True;");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
    
    }


}
