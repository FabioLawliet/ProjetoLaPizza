using LaPizza.Controllers;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormRecClientePesquisa : LaPizza.Views.FormBasePesquisa
    {
        public ClienteModel PesqCliente;
        public FormRecClientePesquisa()
        {
            InitializeComponent();
            CarregaListaGrid();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MaximumSize = new System.Drawing.Size(470, 530);
            txtPesquisa.Focus();
        }

        public void CarregaListaGrid()
        {
            ClienteController controle = new ClienteController();
            List<ClienteModel> lista = controle.GetClienteLista();

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["id"].DisplayIndex = 0;
            dbGridPesquisa.Columns["id"].HeaderText = "Id";
            dbGridPesquisa.Columns["id"].Width = 70;

            dbGridPesquisa.Columns["nome"].DisplayIndex = 1;
            dbGridPesquisa.Columns["nome"].HeaderText = "Nome";
            dbGridPesquisa.Columns["nome"].Width = 100;//384

            dbGridPesquisa.Columns["sobrenome"].DisplayIndex = 2;
            dbGridPesquisa.Columns["sobrenome"].HeaderText = "Sobrenome";
            dbGridPesquisa.Columns["sobrenome"].Width = 100;

            dbGridPesquisa.Columns["cpf"].DisplayIndex = 3;
            dbGridPesquisa.Columns["cpf"].HeaderText = "CPF/CNPJ";
            dbGridPesquisa.Columns["cpf"].Width = 100;

            dbGridPesquisa.Columns["telefone"].DisplayIndex = 4;
            dbGridPesquisa.Columns["telefone"].HeaderText = "Telefone";
            dbGridPesquisa.Columns["telefone"].Width = 100;

            dbGridPesquisa.Columns["ativo"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ClienteController controle = new ClienteController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqCliente = controle.GetCliente(id);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            ClienteController controle = new ClienteController();
            List<ClienteModel> lista = controle.GetClientePesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
