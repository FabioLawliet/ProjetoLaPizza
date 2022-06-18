using System.Collections.Generic;

namespace LaPizza.Models
{
    public class MovimentoEstoqueDTO
    {
        public int idmovimentoestoque { get; set; }
        public string descricao { get; set; }
        public string datamovimento { get; set; }
        public string usuariomovimento { get; set; }
        public List<MovimentoEstoqueItensDTO> itens;

        public MovimentoEstoqueDTO()
        {
            itens = new List<MovimentoEstoqueItensDTO>();
        }
    }
}

