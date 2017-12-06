using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2.Wellingthon.Models
{
    public class Filme
    {
        public int FilmeID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public virtual List<Locacao> Locacoes { get; set; }

    }
}