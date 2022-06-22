using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("estado", Schema = "public")]
    public class EstadoDB
    {
        [Key]
        public int idestado { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
    }
}
