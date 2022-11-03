using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
   public class EntradaMercadoriaDTO
    {
        public int identradamerc { get; set; }
        public int idfornecedor { get; set; }
        public DateTime dataabertura { get; set; }
        public DateTime dataconclusao { get; set; }
        public string status { get; set; }
        public string infadicionais { get; set; }
        public double vlrfrete { get; set; }
        public double outroscustos { get; set; }
        public double vlrunitariototal { get; set; }
        public double vlrliquidototal { get; set; }
        public double descontototal { get; set; }
        public string numeronf { get; set; }
        public string chavenf { get; set; }
    }
}
