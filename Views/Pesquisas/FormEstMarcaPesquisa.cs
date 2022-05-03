using LaPizza.Models;
using LaPizza.Controllers;
using System.Collections.Generic;
using System;

using LaPizza.DAO;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormEstMarcaPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public MarcaModel PesqMarca;
        public FormEstMarcaPesquisa()
        {
            InitializeComponent();
            CarregaListaGrid();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MaximumSize = new System.Drawing.Size(470, 530);
            txtPesquisa.Focus();
        }
        public void CarregaListaGrid()
        {
            MarcaController controle = new MarcaController();
            List<MarcaModel> lista = controle.GetMarcaLista();

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

            dbGridPesquisa.Columns["ativa"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            MarcaController controle = new MarcaController();

            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PesqMarca = controle.GetMarca(id);

            Close();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;

            MarcaController controle = new MarcaController();
            List<MarcaModel> lista = controle.GetMarcaPesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
