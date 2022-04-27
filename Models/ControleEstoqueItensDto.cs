using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("controleestoqueitens", Schema = "public")]
    public class ControleEstoqueItensDto
    {
        [Key]
        public int idcontroleestoque { get; set; }
        public int idproduto { get; set; }
        public decimal saldoestoqueanterior { get; set; }
        public string tipomovimento { get; set; }
        public decimal qtdemovimento { get; set; }
        public decimal saldoestoquenovo { get; set; }
    }
}
