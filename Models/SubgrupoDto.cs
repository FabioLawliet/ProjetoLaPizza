using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("subgrupo", Schema = "public")]
    public class SubgrupoDto
    {
        [Key]
        public int id { get; set; }
        public int idsubgrupo { get; set; }
        public string descricao { get; set; }
        public int idgrupo { get; set; }
        public bool ativo { get; set; }
    }
}
