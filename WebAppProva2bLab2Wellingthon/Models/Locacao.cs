using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2.Wellingthon.Models
{
    public class Locacao
    {
        public int LocacaoID { get; set; }
        public int Numero { get; set; }
        public DateTime LocacaoData { get; set; }

        public virtual Socio Socio { get; set; }
        public int SocioID { get; set; }

        public virtual List<Tipo> Tipos { get; set; }

        public virtual List<Filme> Filmes { get; set; }
    }
}