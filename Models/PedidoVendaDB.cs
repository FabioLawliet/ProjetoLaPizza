using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LaPizza.Models
{
    [Table("pedidovenda", Schema = "public")]
    public class PedidoVendaDB
    {
        [Key]
        public int idpedido { get; set; }
        public int idficha { get; set; }
        public int idtipopedido { get; set; }
        public int idcliente { get; set; }
        public int idformapagamento { get; set; }
        public string datapedido { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalValor { get; set; }
        public List<PedidoVendaItemDB> items { get; set; }
    }
}
