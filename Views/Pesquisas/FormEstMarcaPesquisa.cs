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
        public MarcaDTO PesqMarca;
        public FormEstMarcaPesquisa()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(470, 530);
            this.MinimumSize = new System.Drawing.Size(470, 530);

            CarregaListaGrid();
            txtPesquisa.Focus();
        }
        public void CarregaListaGrid()
        {
            MarcaController controle = new MarcaController();
            List<MarcaDTO> lista = controle.GetMarcaLista();
            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }

        public void AjustaCamposGrid()
        {
            dbGridPesquisa.Columns["idmarca"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idmarca"].HeaderText = "Id";
            dbGridPesquisa.Columns["idmarca"].Width = 70;

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
            List<MarcaDTO> lista = controle.GetMarcaPesquisaGrid(txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = lista;
            AjustaCamposGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
