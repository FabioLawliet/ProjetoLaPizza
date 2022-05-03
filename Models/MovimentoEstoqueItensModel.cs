using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    public class MovimentoEstoqueItensModel
    {
        public int id { get; set; }
        public int idmovimento { get; set; }
        public int idproduto { get; set; }
        public string produtodescricao { get; set; }
        public decimal saldoestoqueanterior { get; set; }
        public string tipomovimento { get; set; }
        public decimal qtdemovimento { get; set; }
        public decimal saldoestoquenovo { get; set; }
    }
}
