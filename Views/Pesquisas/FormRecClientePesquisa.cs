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
        public ClienteDTO PesqCliente;
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
            List<ClienteDTO> lista = controle.GetClienteLista();

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idcliente"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idcliente"].HeaderText = "Id";
            dbGridPesquisa.Columns["idcliente"].Width = 70;

            dbGridPesquisa.Columns["nomerazao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["nomerazao"].HeaderText = "Nome / Razão";
            dbGridPesquisa.Columns["nomerazao"].Width = 100;//384

            dbGridPesquisa.Columns["rgie"].DisplayIndex = 2;
            dbGridPesquisa.Columns["rgie"].HeaderText = "RG / Insc. Estadual";
            dbGridPesquisa.Columns["rgie"].Width = 110;

            dbGridPesquisa.Columns["cpfcnpj"].DisplayIndex = 3;
            dbGridPesquisa.Columns["cpfcnpj"].HeaderText = "CPF/CNPJ";
            dbGridPesquisa.Columns["cpfcnpj"].Width = 90;

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
            List<ClienteDTO> lista = controle.GetClientePesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {          
             dbGridPesquisa.DataSource = null;

             ClienteController controle = new ClienteController();
             List<ClienteDTO> lista = controle.GetClientePesquisaGrid(txtPesquisa.Text);

             dbGridPesquisa.DataSource = lista;
             AjustaCamposGrid();
             dbGridPesquisa.Refresh();
        }
    }
}
