using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("tipopedido", Schema = "public")]
    public class TipoPedidoDB
    {
        [Key]
        public int idtipopedido { get; set; }
        public string sigla { get; set; }
        public string descricao { get; set; }
        public bool ativo {get; set;}   

    }
}
