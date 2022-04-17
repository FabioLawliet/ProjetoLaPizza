using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    [Table("produto", Schema = "public")]
    public class ProdutoDto
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }

        public DateTime dataCadastro;
        public int grupo { get; set; }
        public int subgrupo { get; set; }
        public int marca { get; set; }
        public string codFabricante { get; set; }
        public string infAdicionais { get; set; }
        public decimal SaldoEstoque { get; set; }
        public string unidadeMedida { get; set; }
        public decimal qtdeEstMin { get; set; }
        public decimal qtdeEstIdeal { get; set; }
        public decimal qtdeEstMax { get; set; }
        public decimal precoAnterior { get; set; }
        public decimal precoAtual { get; set; }
        public bool ativo { get; set; }
    }
}
