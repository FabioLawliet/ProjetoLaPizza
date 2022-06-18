using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("grupo", Schema = "public")]
    public class GrupoDB
    {
        [Key]
        public int idgrupo { get; set; }
        public string descricao { get; set; }
        public bool ativo { get; set; }
    }
}
