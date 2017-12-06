using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2.Wellingthon.Models
{
    public class Tipo
    {
        public int TipoID { get; set; }
        public TipoPromocao Promocao { get; set; }
        public string Descricao { get; set; }

        public virtual Locacao Locacao { get; set; }
        public int LocacaoID { get; set; }
    }
}