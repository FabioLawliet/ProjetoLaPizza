using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("movimentoestoqueitens", Schema = "public")]
    public class MovimentoEstoqueItensDto
    {
        [Key]
        public int id { get; set; }
        public int idmovimento { get; set; }
        public int idproduto { get; set; }
        public decimal saldoestoqueanterior { get; set; }
        public string tipomovimento { get; set; }
        public decimal qtdemovimento { get; set; }
        public decimal saldoestoquenovo { get; set; }

    }
}
