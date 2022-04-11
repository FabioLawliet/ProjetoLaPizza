using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("marca", Schema = "public")]
    public class MarcaDto
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public bool ativa { get; set; }
    }
}
