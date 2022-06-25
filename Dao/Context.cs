using System.Data.Entity;
using LaPizza.Models;

namespace LaPizza.DAO
{
    public class Context : DbContext
    {
        public Context() : base("db")
        {
        }
        public DbSet<GrupoDB> grupo { get; set; }
        public DbSet<SubgrupoDB> subgrupo { get; set; }
        public DbSet<MarcaDB> marca { get; set; }
        public DbSet<UnidadeMedidaDB> unidademedida { get; set; }
        public DbSet<ProdutoDB> produto { get; set; }
        public DbSet<MovimentoEstoqueDB> movimentoestoque { get; set; }
        public DbSet<MovimentoEstoqueItensDB> movimentoestoqueitens { get; set; }
        public DbSet<UsuarioDto> usuario { get; set; }
        public DbSet<ClienteDB> cliente { get; set; }
        public DbSet<CidadeDB> cidade { get; set; }
        public DbSet<EstadoDB> estado { get; set; }
        public DbSet<PedidoVendaDB> pedidovenda { get; set; }
        public DbSet<PedidoVendaItemDB> pedidovendaItem { get; set; }
        public DbSet<EntradaMercadoriaDB> entradamercadoria { get; set; }
        public DbSet<EntradaMercadoriaItemDB> entradamercadoriaitem { get; set; }
        public DbSet<FornecedorDB> fornecedor { get; set; }
        public DbSet<FormaPagamentoDB> formapagamento { get; set; }
    }
}
