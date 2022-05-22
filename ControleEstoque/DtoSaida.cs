using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    [Table("saidaproduto", Schema = "public")]
    public class DtoSaida
    {
        [Key]
        public int id { get; set; }
        public int idproduro { get; set; }
        public decimal? vlrpedido { get; set; }
        public decimal? qntpedido { get; set; }
        public DateTime? dtpedido { get; set; } 
    }
}
