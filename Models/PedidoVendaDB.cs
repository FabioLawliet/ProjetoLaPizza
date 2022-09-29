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
        public string dataabertura { get; set; }
        public string datafechamento { get; set; }
        public string status { get; set; }
        public decimal vlrtotalbruto { get; set; }
        public decimal vlrtotaldescontos { get; set; }

        public List<PedidoVendaItemDB> items = new List<PedidoVendaItemDB>();
    }
}
