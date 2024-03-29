﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaPizza.Models
{
    [Table("produto", Schema = "public")]
    public class ProdutoDto
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
        public string datacadastro { get; set; }
        public int idgrupo { get; set; }
        public int idsubgrupo { get; set; }
        public int idmarca { get; set; }
        public string codigofabricante { get; set; }
        public string infadicionais { get; set; }
        public decimal saldoestoque { get; set; }
        public string unidademedida { get; set; }
        public decimal qtdeestmin { get; set; }
        public decimal qtdeestideal { get; set; }
        public decimal qtdeestmax { get; set; }
        public decimal precoanterior { get; set; }
        public decimal precoatual { get; set; }
        public bool ativo { get; set; }
    }
}
