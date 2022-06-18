using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    public class SubgrupoDTO
    {
        public int id { get; set; }
        public int idsubgrupo { get; set; }
        public string descricao { get; set; }
        public int idgrupo { get; set; }
        public bool ativo { get; set; }   

    }
}
