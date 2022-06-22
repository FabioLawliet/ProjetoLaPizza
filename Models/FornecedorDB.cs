using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("fornecedor", Schema = "public")]
    public class FornecedorDB
    {
        public int id { get; set; }
        public string razaosocial { get; set; }
        public string nomefantasia { get; set; }
        public string cnpjcpf { get; set; }
        public string inscricaoestadual { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public bool ativo { get; set; }
    }
}
