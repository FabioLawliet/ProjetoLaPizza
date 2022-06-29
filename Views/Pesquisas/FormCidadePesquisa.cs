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
    public partial class FormCidadePesquisa : LaPizza.Views.FormBasePesquisa
    {
        public CidadeDTO PesqCidade;
        public FormCidadePesquisa()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MinimumSize = new System.Drawing.Size(470, 530);

            CarregaListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregaListaGrid()
        {
            CidadeController controle = new CidadeController();
            List<CidadeDTO> lista = controle.GetCidadeLista();
            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idcidade"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idcidade"].HeaderText = "Id";
            dbGridPesquisa.Columns["idcidade"].Width = 70;

            dbGridPesquisa.Columns["nome"].DisplayIndex = 1;
            dbGridPesquisa.Columns["nome"].HeaderText = "Nome Cidade";
            dbGridPesquisa.Columns["nome"].Width = 192;

            dbGridPesquisa.Columns["estadonome"].DisplayIndex = 2;
            dbGridPesquisa.Columns["estadonome"].HeaderText = "Nome Estado";
            dbGridPesquisa.Columns["estadonome"].Width = 192;

            dbGridPesquisa.Columns["idestado"].Visible = false;
            dbGridPesquisa.Columns["sigla"].Visible = false;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CidadeController controle = new CidadeController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqCidade = controle.GetCidade(id);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            CidadeController controle = new CidadeController();
            List<CidadeDTO> lista = controle.GetCidadePesquisaGrid(txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
