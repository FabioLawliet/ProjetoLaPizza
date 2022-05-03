using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("movimentoestoque", Schema = "public")]
    public class MovimentoEstoqueDto
    {
        [Key]
        public int idmovimento { get; set; }
        public string descricao { get; set; }
        public string datamovimento { get; set; }
        public string usuariomovimento  { get; set; }
    }
}
