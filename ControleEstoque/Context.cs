using System.Data.Entity;

namespace ControleEstoque1
{
    public class Context: DbContext
    {
        public Context() : base("BD")
        {
        }
        public DbSet<DtoUsuario> usuario { get; set; }

        public DbSet<DtoProduto> produto { get; set; }
        public DbSet<DtoEntrada> entrada { get; set; }
        public DbSet<DtoSaida> saida { get; set; }
    }

    
}
