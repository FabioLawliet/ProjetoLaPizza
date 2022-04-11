using System.Data.Entity; 
using LaPizza.Models;

namespace LaPizza.DAO 
{
    public class Context: DbContext
    {
        public Context() : base("BD")
        {
        }
        public DbSet<MarcaDto> marca { get; set; }
    }
}
