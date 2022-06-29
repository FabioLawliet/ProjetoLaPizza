namespace LaPizza.Models
{
    public class FormaPagamentoDTO
    {
        public int idformapagamento { get; set; }
        public string descricao { get; set; }
        public bool permitedinheiro { get; set; }
        public bool permitepix { get; set; }
        public bool permitecartaodeb { get; set; }
        public bool permitecartaocred { get; set; }
        public bool permitecheque { get; set; }
        public bool permitecrediario { get; set; }
        public bool ativa { get; set; }
    }
}
