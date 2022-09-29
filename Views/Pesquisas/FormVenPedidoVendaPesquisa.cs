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
    public partial class FormVenPedidoVendaPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public PedidoVendaDTO PesqPedido;
        public FormVenPedidoVendaPesquisa()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MinimumSize = new System.Drawing.Size(470, 530);

            CarregaListaGrid();
            txtPesquisa.Focus();
        }
        public void CarregaListaGrid()
        {
            PedidoVendaController controle = new PedidoVendaController();
            List<PedidoVendaDTO> lista = controle.GetPedidos();
            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idPedido"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idPedido"].HeaderText = "Pedido";
            dbGridPesquisa.Columns["idPedido"].Width = 50;

            dbGridPesquisa.Columns["clientenome"].DisplayIndex = 1;
            dbGridPesquisa.Columns["clientenome"].HeaderText = "Cliente";
            dbGridPesquisa.Columns["clientenome"].Width = 220;

            dbGridPesquisa.Columns["dataabertura"].DisplayIndex = 2;
            dbGridPesquisa.Columns["dataabertura"].HeaderText = "Data Pedido";
            dbGridPesquisa.Columns["dataabertura"].Width = 100;

            dbGridPesquisa.Columns["vlrtotalbruto"].DisplayIndex = 3;
            dbGridPesquisa.Columns["vlrtotalbruto"].HeaderText = "Valor Total";
            dbGridPesquisa.Columns["vlrtotalbruto"].Width = 80;

            dbGridPesquisa.Columns["idficha"].Visible = false;
            dbGridPesquisa.Columns["idtipopedido"].Visible = false;
            dbGridPesquisa.Columns["tipopedidodescricao"].Visible = false;
            dbGridPesquisa.Columns["idcliente"].Visible = false;
            dbGridPesquisa.Columns["idformapagamento"].Visible = false;
            dbGridPesquisa.Columns["formapagamentodescricao"].Visible = false;
            dbGridPesquisa.Columns["vlrtotaldescontos"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            PedidoVendaController controle = new PedidoVendaController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqPedido = controle.GetPedidoId(id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
