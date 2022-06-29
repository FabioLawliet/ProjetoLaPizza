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
    public partial class FormVenFormaPagamentoPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public FormaPagamentoDTO PesqFormaPagamento;
        public FormVenFormaPagamentoPesquisa()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MinimumSize = new System.Drawing.Size(470, 530);

            CarregaListaGrid();
            txtPesquisa.Focus();
        }
        public void CarregaListaGrid()
        {
            FormaPagamentoController controle = new FormaPagamentoController();
            List<FormaPagamentoDTO> lista = controle.GetFormaPagamentoLista();
            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idformapagamento"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idformapagamento"].HeaderText = "Id";
            dbGridPesquisa.Columns["idformapagamento"].Width = 70;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].HeaderText = "Descrição";
            dbGridPesquisa.Columns["descricao"].Width = 384;

            dbGridPesquisa.Columns["ativa"].Visible = false;
            dbGridPesquisa.Columns["permitedinheiro"].Visible = false;
            dbGridPesquisa.Columns["permitepix"].Visible = false;
            dbGridPesquisa.Columns["permitecartaocred"].Visible = false;
            dbGridPesquisa.Columns["permitecartaodeb"].Visible = false;
            dbGridPesquisa.Columns["permitecrediario"].Visible = false;
            dbGridPesquisa.Columns["permitecheque"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            FormaPagamentoController controle = new FormaPagamentoController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqFormaPagamento = controle.GetFormaPagamento(id);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            FormaPagamentoController controle = new FormaPagamentoController();
            List<FormaPagamentoDTO> lista = controle.GetFormaPagamentoPesquisaGrid(txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
