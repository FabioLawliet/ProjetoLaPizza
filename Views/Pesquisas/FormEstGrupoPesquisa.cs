using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormEstGrupoPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public GrupoModel PGrupo;
        public FormEstGrupoPesquisa()
        {
            InitializeComponent();
            CarregarListaGrid();
            txtPesquisa.Focus();
        }


        public void CarregarListaGrid()
        {
            Context db = new Context();
            GrupoController gControle = new GrupoController();
            List<GrupoModel> Lista = gControle.GetGrupoLista();

            dbGridPesquisa.DataSource = Lista;

            dbGridPesquisa.Columns[0].HeaderText = "Id";
            dbGridPesquisa.Columns[0].Width = 50;

            dbGridPesquisa.Columns[1].HeaderText = "Descrição";
            dbGridPesquisa.Columns[1].Width = 250;

            dbGridPesquisa.Columns[3].HeaderText = "Ativo?";
            dbGridPesquisa.Columns[3].Width = 100;

            this.Width = 450;
            dbGridPesquisa.Refresh();
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            Context db = new Context();
            GrupoController gControle = new GrupoController();
            GrupoModel grupo = new GrupoModel();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PGrupo = gControle.GetGrupo(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;
            Context db = new Context();
            GrupoController gControle = new GrupoController();
            List<GrupoModel> Lista = gControle.GetGrupoPesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = Lista;

            dbGridPesquisa.Columns[0].HeaderText = "Id";
            dbGridPesquisa.Columns[0].Width = 50;

            dbGridPesquisa.Columns[1].HeaderText = "Descrição";
            dbGridPesquisa.Columns[1].Width = 250;

            dbGridPesquisa.Columns[3].HeaderText = "Ativo?";
            dbGridPesquisa.Columns[3].Width = 100;

            this.Width = 450;
            dbGridPesquisa.Refresh();
        }
    }
}
