namespace LaPizza.Models
{
    public class ItemSelecionadoVendaDTO
    {
        public string idProduto { get; set; }
        public string produtoDescricao { get; set; }
        public decimal qtdeDisponivel { get; set; }
        public decimal qtde { get; set; }
        public decimal vlrDesconto { get; set; }
        public string descontoPerc { get; set; }
        public decimal vlrUnitario { get; set; }
        private decimal vlrBruto { get; set; }
        private decimal vlrLiquido { get; set; }


        public void calculaValores()
        {
            vlrBruto = (qtde * vlrUnitario);
            vlrLiquido = vlrBruto - vlrDesconto;
            if (vlrBruto > 0)
                descontoPerc = ((vlrDesconto / vlrBruto) * 100).ToString("N2") + "%";
            else
                descontoPerc = "0,00%";
        }

        public decimal getVlrBruto()
        {
            return vlrBruto;
        }

        public decimal getVlrLiquido()
        {
            return vlrLiquido;
        }
    }
}
