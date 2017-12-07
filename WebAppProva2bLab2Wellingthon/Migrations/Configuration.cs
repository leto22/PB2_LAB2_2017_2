namespace WebAppProva2bLab2Wellingthon.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppProva2bLab2.Wellingthon.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppProva2bLab2.Wellingthon.Models.LocadoraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppProva2bLab2.Wellingthon.Models.LocadoraContext context)
        {
            if (context.Socios.Any()) return;
            try
            {
                PopularDados(context);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // TODO: fazer log de erro
                ex.ToString();
            }
        }

        private void PopularDados(LocadoraContext contexto)
        {
            var socios = new List<Socio>
            {
                new Socio
                {
                    Nome = "Leto",
                    Email = "leto@gmail.com",
                    Endereco = [0]

                },
            };
            contexto.Socios.AddRange(socios);

            var enderecos = new List<Endereco>
            {
                new Endereco
                {

                }
            };
        }
    }
}
