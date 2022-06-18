using System.Data.Entity;
using LaPizza.Models;

namespace LaPizza.DAO
{
    public class Context : DbContext
    {
        public Context() : base("db")
        {
        }
        public DbSet<ProdutoDto> produto { get; set; }
        public DbSet<GrupoDB> grupo { get; set; }
        public DbSet<SubgrupoDB> subgrupo { get; set; }
        public DbSet<MarcaDB> marca { get; set; }
        public DbSet<MovimentoEstoqueDto> movimentoestoque { get; set; }
        public DbSet<MovimentoEstoqueItensDto> movimentoestoqueitens { get; set; }
        public DbSet<UsuarioDto> usuario { get; set; }
        public DbSet<ClienteDto> cliente { get; set; }
    }
}
