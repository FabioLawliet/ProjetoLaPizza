using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("marca", Schema = "public")]
    public class MarcaDB
    {
        [Key]
        public int idmarca { get; set; }
        public string descricao { get; set; }
        public bool ativa { get; set; }
    }
}
