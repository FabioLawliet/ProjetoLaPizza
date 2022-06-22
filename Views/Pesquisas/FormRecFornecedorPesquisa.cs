using LaPizza.Controllers;
using LaPizza.Models;
using System;
using System.Collections.Generic;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormRecFornecedorPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public FornecedorDTO PesqFornecedor;
        public FormRecFornecedorPesquisa()
        {
            InitializeComponent();
            CarregaListaGrid();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MaximumSize = new System.Drawing.Size(470, 530);
            txtPesquisa.Focus();
        }

        public void CarregaListaGrid()
        {
            FornecedorController controle = new FornecedorController();
            List<FornecedorDTO> lista = controle.GetFornecedorLista();

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["id"].DisplayIndex = 0;
            dbGridPesquisa.Columns["id"].HeaderText = "Id";
            dbGridPesquisa.Columns["id"].Width = 70;

            dbGridPesquisa.Columns["razaosocial"].DisplayIndex = 1;
            dbGridPesquisa.Columns["razaosocial"].HeaderText = "Razão Social";
            dbGridPesquisa.Columns["razaosocial"].Width = 100;//384

            dbGridPesquisa.Columns["nomefantasia"].DisplayIndex = 2;
            dbGridPesquisa.Columns["nomefantasia"].HeaderText = "Nome Fantasia";
            dbGridPesquisa.Columns["nomefantasia"].Width = 100;

            dbGridPesquisa.Columns["cnpjcpf"].DisplayIndex = 3;
            dbGridPesquisa.Columns["cnpjcpf"].HeaderText = "CPF/CNPJ";
            dbGridPesquisa.Columns["cnpjcpf"].Width = 100;

            dbGridPesquisa.Columns["telefone"].DisplayIndex = 4;
            dbGridPesquisa.Columns["telefone"].HeaderText = "Telefone";
            dbGridPesquisa.Columns["telefone"].Width = 100;

            dbGridPesquisa.Columns["ativo"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FornecedorController controle = new FornecedorController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqFornecedor = controle.GetFornecedor(id);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            FornecedorController controle = new FornecedorController();
            List<FornecedorDTO> lista = controle.GetFornecedorPesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
