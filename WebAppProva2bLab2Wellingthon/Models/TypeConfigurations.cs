using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Wellingthon.Models
{
    public abstract class TypeConfigurations<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public TypeConfigurations()
        {
            ConfiguraPrimaryKey();
            ConfiguraForeignKey();
        }

        protected virtual void ConfiguraPrimaryKey()
        {

        }

        protected virtual void ConfiguraForeignKey()
        {

        }
    }
}