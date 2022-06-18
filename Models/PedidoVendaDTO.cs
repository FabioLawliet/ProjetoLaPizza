using System.Collections.Generic;

namespace LaPizza.Models
{
    public class PedidoVendaDTO
    {
        public int idpedido { get; set; }
        public int idficha { get; set; }
        public int idtipopedido { get; set; }
        public string tipopedidodescricao { get; set; }
        public int idcliente { get; set; }
        public string clientenome { get; set; }
        public int idformapagamento { get; set; }
        public string formapagamentodescricao { get; set; }
        public string datapedido { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalValor { get; set; }

        public List<PedidoVendaItemDTO> itens;
    }
}
