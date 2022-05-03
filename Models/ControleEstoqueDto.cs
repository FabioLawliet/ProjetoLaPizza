using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("controleestoque", Schema = "public")]
    public class ControleEstoqueDto
    {
        [Key]
        public int id { get; set; }
        public string descricao { set; get; }
        public string datamovimentacao { set; get; }
        public string usuariomovimentacao { set; get; }
    }
}
