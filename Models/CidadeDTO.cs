using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    public class CidadeDTO
    {
        public int idcidade { get; set; }
        public string nome { get; set; }
        public int idestado { get; set; }
        public string sigla { get; set; }
        public string estadonome { get; set; }
    }
}
