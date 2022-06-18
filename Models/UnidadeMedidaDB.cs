using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("unidademedida", Schema = "public")]
    public class UnidadeMedidaDB
    {
        [Key]
        public int idunidmedida { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }
        public bool ativa { get; set; }
    }
}
