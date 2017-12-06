using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2.Wellingthon.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoID { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }

        public virtual Socio Socio { get; set; }
        [ForeignKey]
        public int SocioID { get; set; }
    }
}