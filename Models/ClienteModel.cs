﻿namespace LaPizza.Models
{
    public class ClienteModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string rg { get; set; }
        public string cpfcnpj { get; set; }
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
