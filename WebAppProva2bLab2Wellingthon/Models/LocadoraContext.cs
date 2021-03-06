﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration.Configuration;
using WebAppProva2bLab2Wellingthon.Models;
using System;

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

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));

            modelBuilder.Properties<DateTime>()
                .Configure(p => p.HasColumnType("datetime2"));

            modelBuilder.Types()
                .Configure(t => t.MapToStoredProcedures());

            modelBuilder.Configurations.Add(new EnderecoTypeConfigurations());
        }

    }
}