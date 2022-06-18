using LaPizza.Controllers;
using LaPizza.Models;
using System;
using System.Collections.Generic;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormEstSubgrupoPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public SubgrupoDTO PesqSubgrupo;
        public int Grupo;
        public FormEstSubgrupoPesquisa(int Grupo)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MaximumSize = new System.Drawing.Size(470, 530);

            this.Grupo = Grupo;
            CarregarListaGrid();
            txtPesquisa.Focus();
        }


        public void CarregarListaGrid()
        {
            SubgrupoController controle = new SubgrupoController();
            List<SubgrupoDTO> lista = controle.GetSubgrupoLista(Grupo);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idsubgrupo"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idsubgrupo"].HeaderText = "Id";
            dbGridPesquisa.Columns["idsubgrupo"].Width = 70;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].HeaderText = "Descrição";
            dbGridPesquisa.Columns["descricao"].Width = 384;

            dbGridPesquisa.Columns["ativo"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            SubgrupoController controle = new SubgrupoController();

            if (dbGridPesquisa.Rows.Count > 0)
            {
                int idSubgrupo = (int)dbGridPesquisa.CurrentRow.Cells["idsubgrupo"].Value;
                PesqSubgrupo = controle.GetSubgrupo(Grupo, idSubgrupo);
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            SubgrupoController controle = new SubgrupoController();
            List<SubgrupoDTO> lista = controle.GetSubgrupoPesquisaGrid(Grupo, txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
