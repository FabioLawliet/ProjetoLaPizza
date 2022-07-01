using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    public class PedidoVendaItemDTO
    {
        public int id { get; set; }
        public int idpedido { get; set; }
        public int idproduto { get; set; }
        public string produtodescricao { get; set; }
        public int idunidmedida { get; set; }
        public string unidademedidasigla { get; set; }
        public decimal saldoestoque { get; set; }
        public decimal qtde { get; set; }
        public decimal vlrunitario { get; set; }
        public decimal vlrdesconto { get; set; }
        public string vlrdescontoperc { get; set; }
        public decimal vlrliquido { get; set; }
    }
}
