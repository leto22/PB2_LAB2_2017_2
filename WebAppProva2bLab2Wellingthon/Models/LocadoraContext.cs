using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Core.Metadata.Edm;

namespace WebAppProva2bLab2.Wellingthon.Models
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext() : base("name=LocadoraContext")
        {

        }

        public DbSet<Socio> Socios { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Locacao> Locadoras { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

    }
}