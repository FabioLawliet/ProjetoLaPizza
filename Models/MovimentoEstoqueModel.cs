using System.Collections.Generic;

namespace LaPizza.Models
{
    public class MovimentoEstoqueModel
    {
        public int idmovimento { get; set; }
        public string descricao { get; set; }
        public string datamovimento { get; set; }
        public string usuariomovimento { get; set; }
        public List<MovimentoEstoqueItensModel> itens;

        public MovimentoEstoqueModel()
        {
            itens = new List<MovimentoEstoqueItensModel>();
        }
    }
}

