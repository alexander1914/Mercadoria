using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMercado.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string TP_Mercadoria { get; set; }
        public string NM_Mercadoria { get; set; }
        public decimal Quantidade   { get; set; }
        public string Descrição { get; set; }
        public double Preço { get; set; }
        public string TP_Negocio { get; set; }

    }
}