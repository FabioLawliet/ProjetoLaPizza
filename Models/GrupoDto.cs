using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("grupo", Schema = "public")]
    public class GrupoDto
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public bool ativo { get; set; }
    }
}
