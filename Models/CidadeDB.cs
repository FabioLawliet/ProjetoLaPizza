using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("cidade", Schema = "public")]
    public class CidadeDB
    {
        [Key]
        public int idcidade { get; set; }
        public string nome { get; set; }
        public int idestado { get; set; }
    }
}
