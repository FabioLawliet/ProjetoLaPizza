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
    public partial class FormEstUnidadeMedidaPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public UnidadeMedidaDTO PesqUnidadeMedida;
        public FormEstUnidadeMedidaPesquisa()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MaximumSize = new System.Drawing.Size(470, 530);

            CarregarListaGrid();
            txtPesquisa.Focus();
        }


        public void CarregarListaGrid()
        {
            UnidadeMedidaController controle = new UnidadeMedidaController();
            List<UnidadeMedidaDTO> lista = controle.GetUnidadeMedidaLista();

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idunidmedida"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idunidmedida"].HeaderText = "Id";
            dbGridPesquisa.Columns["idunidmedida"].Width = 70;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].HeaderText = "Descrição";
            dbGridPesquisa.Columns["descricao"].Width = 300;

            dbGridPesquisa.Columns["sigla"].DisplayIndex = 3;
            dbGridPesquisa.Columns["sigla"].HeaderText = "Sigla";
            dbGridPesquisa.Columns["sigla"].Width = 84;

            dbGridPesquisa.Columns["ativa"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            UnidadeMedidaController controle = new UnidadeMedidaController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqUnidadeMedida = controle.GetUnidadeMedida(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            UnidadeMedidaController controle = new UnidadeMedidaController();
            List<UnidadeMedidaDTO> lista = controle.GetUnidadeMedidaPesquisaGrid(txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
