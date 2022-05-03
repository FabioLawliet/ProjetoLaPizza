namespace LaPizza.Models
{
    public class ControleEstoqueItensModel
    {
        public int idcontroleestoque { get; set; }
        public int idProduto { get; set; }
        public string ProdutoDescricao { get; set; }
        public decimal saldoEstoqueAnterior { get; set; }
        public string tipoEntrada { get; set; }
        public decimal qtdeMovimentada { get; set; }
        public decimal saldoEstoqueNovo { get; set; }
    }
}
