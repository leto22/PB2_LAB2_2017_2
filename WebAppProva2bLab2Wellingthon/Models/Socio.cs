using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2.Wellingthon.Models
{
    public class Socio
    {
        public int SocioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public virtual Endereco Endereco { get; set; }
        public int EnderecoID { get; set; }

        public virtual List<Locacao> Locacoes { get; set; }
    }
}