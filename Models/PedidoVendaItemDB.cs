using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("pedidoitem", Schema = "public")]
    public class PedidoVendaItemDB
    {
        [Key]
        public int iditem { get; set; }
        public int idpedido { get; set; }
        public int idproduto { get; set; }
        public decimal qtde { get; set; }
        public decimal vlrunitario { get; set; }
        public decimal vlrbruto { get; set; }
        public decimal vlrdesconto { get; set; }
      
    }
}