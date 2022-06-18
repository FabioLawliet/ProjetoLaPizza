using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("pedidovendaitem", Schema = "public")]
    public class PedidoVendaItemDB
    {
        [Key]
        public int id { get; set; }
        public int idpedido { get; set; }
        public int idproduto { get; set; }
        public int idunidmedida { get; set; }
        public double qtde { get; set; }
        public double vlrunitario { get; set; }
        public double vlrdesconto { get; set; }
        public double vlrdescontoperc { get; set; }
        public double vlrtotal { get; set; }
        
    }
}
