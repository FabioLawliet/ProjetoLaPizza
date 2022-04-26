using System.Data.Entity; 
using LaPizza.Models;

namespace LaPizza.DAO 
{
    public class Context: DbContext
    {
        public Context() : base("BD")
        {
        }
        public DbSet<ProdutoDto> produto { get; set; }
        public DbSet<GrupoDto> grupo { get; set; }
        public DbSet<SubgrupoDto> subgrupo { get; set; }
        public DbSet<MarcaDto> marca { get; set; }
    }
}
