using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LaPizza.Models
{
    [Table("fornecedor", Schema = "public")]
    public class FornecedorDB
    {
        [Key]

        public int idfornecedor { get; set; }
        public string nomerazao { get; set; }
        public string rgie { get; set; }
        public string cpfcnpj { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public int idcidade { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public bool ativo { get; set; }
    }
}
