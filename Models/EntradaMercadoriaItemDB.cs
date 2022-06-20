using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    [Table("ENTRADAMERCADORIAITEM", Schema ="public")]
   public class EntradaMercadoriaItemDB
    {
        [Key]
        public int id { get; set; }
        public int identradamerc { get; set; }
        public int identradamercitem { get; set; }
        public int idproduto { get; set; }
        public int qtde { get; set; }
        public double vlrunitario { get; set; }
        public double vlrunitariototal { get; set; }
        public double vlrdesconto { get; set; }
        public double vlrliquidototal { get; set; }
        public double precovenda { get; set; }
    }
}
