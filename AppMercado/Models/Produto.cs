using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMercado.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("CATEGORIA")]
        public string TP_Mercadoria { get; set; }

        [DisplayName("PRODUTO")]
        public string NM_Mercadoria { get; set; }

        [DisplayName("PREÇO")]
        public decimal Quantidade { get; set; }

        [DisplayName("MARCA")]
        public string Descrição { get; set; }

        [DisplayName("QUANTIDADE")]
        public double Preço { get; set; }

        [DisplayName("NEGOCIO")]
        public string TP_Negocio { get; set; }
        
       
    }    
}