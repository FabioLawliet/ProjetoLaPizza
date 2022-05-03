using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("teste", Schema = "public")]
    public class TesteDto
    {
        [Key]
        public int id { get; set; }
        public int numero { get; set; }
    }
}