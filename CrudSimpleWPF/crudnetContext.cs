using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrudSimpleWPF
{
    // Clase creada por Microsoft para conectarse con la base de datos y recoger la información
    public partial class crudnetContext : DbContext
    {
        public crudnetContext()
        {
        }


        public virtual DbSet<Persona> Personas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=crudnet;");
            }
        }

    }
}
