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

        [DisplayName("Mercadoria")]
        public string TP_Mercadoria { get; set; }

        [DisplayName("Marca")]
        public string NM_Mercadoria { get; set; }

        [DisplayName("Preço")]
        public decimal Quantidade { get; set; }

        public string Descrição { get; set; }

        [DisplayName("Quantidade")]
        public double Preço { get; set; }

        [DisplayName("Negocio")]
        public string TP_Negocio { get; set; }
        
       
    }    
}