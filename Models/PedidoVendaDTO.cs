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
        public string dataabertura { get; set; }
        public string datafechamento { get; set; }
        public string status { get; set; }
        public decimal vlrtotaldescontos { get; set; }
        public decimal vlrtotalbruto { get; set; }

        public List<PedidoVendaItemDTO> itens;

        public PedidoVendaDTO()
        {
            itens = new List<PedidoVendaItemDTO>();
        }
    }
}
