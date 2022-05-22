using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    public class DtoSaida2
    {
        public int id { get; set; }
        public int idproduro { get; set; }
        public decimal? vlrpedido { get; set; }
        public decimal? qntpedido { get; set; }
        public DateTime? dtpedido { get; set; }
    }
}
