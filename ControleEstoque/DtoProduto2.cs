using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    public class DtoProduto2
    {
        public int idproduto {get; set;}
        public string nomeproduto {get; set;}
        public decimal? quantidade {get; set;}
        public decimal? valorvenda { get; set; }
        public decimal? valorcusto { get; set; }
    }
}
