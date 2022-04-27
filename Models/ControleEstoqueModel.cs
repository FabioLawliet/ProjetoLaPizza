using System.Collections.Generic;

namespace LaPizza.Models
{
    public class ControleEstoqueModel
    {
        public int id { set; get; }
        public string descricao { set; get; }
        public string dataMovimentacao { set; get; }
        public string usuarioMovimentacao { set; get; }
        public List<ControleEstoqueItensModel> itens { set; get; }

        public ControleEstoqueModel()
        {
            itens = new List<ControleEstoqueItensModel>();
        }
    }
}
