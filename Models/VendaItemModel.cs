using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    public class VendaItemModel
    {
        public int id { get; set; }
        public string descricaoproduto { get; set; }
        public string datacadastro { get; set; }
        public int idgrupo { get; set; }
        public string grupodescricao { get; set; }
        public int idsubgrupo { get; set; }
        public string subgrupodescricao { get; set; }
        public int idmarca { get; set; }
        public string marcadescricao { get; set; }
        public string codigofabricante { get; set; }
        public string infadicionais { get; set; }
        public decimal saldoestoque { get; set; }
        public string unidademedida { get; set; }
        public decimal qtdeestmin { get; set; }
        public decimal qtdeestideal { get; set; }
        public decimal qtdeestmax { get; set; }
        public decimal precoanterior { get; set; }
        public decimal precoatual { get; set; }
        public bool ativo { get; set; }
    }
}
