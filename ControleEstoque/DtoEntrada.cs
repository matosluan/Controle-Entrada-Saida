using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    [Table ("entradaproduto", Schema = "public")]
    public class DtoEntrada
    {
        [Key]
        public int id { get; set; }
        public int idproduto { get; set; }
        public string nomeproduto { get; set; }
        public decimal? qteproduto { get; set; }
        public decimal? vlrcustoproduto { get; set; }
        public decimal? vlrtotalproduto { get; set; }
        public DateTime? dtcompra { get; set; }
    }
}
