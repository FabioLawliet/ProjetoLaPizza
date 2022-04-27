using System.Data.Entity; 
using LaPizza.Models;

namespace LaPizza.DAO 
{
    public class Context: DbContext
    {
        public Context() : base("BD1")
        {
        }
        public DbSet<ProdutoDto> produto { get; set; }
        public DbSet<GrupoDto> grupo { get; set; }
        public DbSet<SubgrupoDto> subgrupo { get; set; }
        public DbSet<MarcaDto> marca { get; set; }
        public DbSet<ControleEstoqueDto> controleestoque { get; set; }
        public DbSet<ControleEstoqueItensDto> controleestoqueitens { get; set; }

    }
}
