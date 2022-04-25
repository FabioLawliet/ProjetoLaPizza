using System;

namespace LaPizza.Models
{
    public class ProdutoModel
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public DateTime dataCadastro;
        public int grupo { get; set; }
        public string grupoDescricao { get; set; }
        public int subgrupo { get; set; }
        public string subgrupoDescricao { get; set; }
        public int marca { get; set; }
        public string marcaDescricao { get; set; }
        public string codigoFabricante { get; set; }
        public string infAdicionais { get; set; }
        public decimal saldoEstoque { get; set; }
        public string unidadeMedida { get; set; }
        public decimal qtdeEstMin { get; set; }
        public decimal qtdeEstIdeal { get; set; }
        public decimal qtdeEstMax { get; set; }
        public decimal precoAnterior { get; set; }
        public decimal precoAtual { get; set; }
        public bool ativo { get; set; }
    }
}