﻿using LaPizza.Controllers;
using LaPizza.Models;
using System;
using System.Collections.Generic;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormEstGrupoPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public GrupoModel PesqGrupo;
        public FormEstGrupoPesquisa()
        {
            InitializeComponent();
            CarregarListaGrid();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MaximumSize = new System.Drawing.Size(470, 530);
            txtPesquisa.Focus();
        }


        public void CarregarListaGrid()
        {
            GrupoController controle = new GrupoController();
            List<GrupoModel> lista = controle.GetGrupoLista();

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["id"].DisplayIndex = 0;
            dbGridPesquisa.Columns["id"].HeaderText = "Id";
            dbGridPesquisa.Columns["id"].Width = 70;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].HeaderText = "Descrição";
            dbGridPesquisa.Columns["descricao"].Width = 384;

            dbGridPesquisa.Columns["ativo"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            GrupoController controle = new GrupoController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqGrupo = controle.GetGrupo(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            GrupoController controle = new GrupoController();
            List<GrupoModel> lista = controle.GetGrupoPesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
