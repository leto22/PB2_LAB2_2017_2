using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppProva2bLab2.Wellingthon.Models;

namespace WebAppProva2bLab2Wellingthon.Models
{
    public class EnderecoTypeConfigurations : TypeConfigurations<Socio>
    {
        protected override void ConfiguraPrimaryKey()
        {
            HasKey(pk => pk.SocioID);
        }

        protected override void ConfiguraForeignKey()
        {
            HasOptional(l => l.Endereco)
                .WithRequired(fk => fk.Socio);
                
        }
    }
}