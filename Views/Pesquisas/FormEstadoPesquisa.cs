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
    public partial class FormEstadoPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public EstadoDTO PesqEstado;
        public FormEstadoPesquisa()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MinimumSize = new System.Drawing.Size(470, 530);

            CarregaListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregaListaGrid()
        {
            EstadoController controle = new EstadoController();
            List<EstadoDTO> lista = controle.GetEstadoLista();
            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idestado"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idestado"].HeaderText = "Id";
            dbGridPesquisa.Columns["idestado"].Width = 70;

            dbGridPesquisa.Columns["nome"].DisplayIndex = 1;
            dbGridPesquisa.Columns["nome"].HeaderText = "Nome Estado";
            dbGridPesquisa.Columns["nome"].Width = 384;

            dbGridPesquisa.Columns["sigla"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EstadoController controle = new EstadoController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqEstado = controle.GetEstado(id);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            EstadoController controle = new EstadoController();
            List<EstadoDTO> lista = controle.GetEstadoPesquisaGrid(txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
