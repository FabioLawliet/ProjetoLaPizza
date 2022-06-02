using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{

        [Table("cliente", Schema = "public")]
        public class ClienteDto
        {
            [Key]
            public int id { get; set; }
            public string nome { get; set; }
            public string sobrenome { get; set; }
            public string rg { get; set; }
            public string cpf { get; set; }
            public string endereço { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
            public string telefone { get; set; }
            public string email { get; set; }
            public bool ativo { get; set; }
        }
}
