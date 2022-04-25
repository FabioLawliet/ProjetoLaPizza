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
        public MarcaModel PMarca;
        public FormEstMarcaPesquisa()
        {
            InitializeComponent();
            CarregarListaGrid();
        }
        public void CarregarListaGrid()
        {
            Context db = new Context();
            MarcaController mControle = new MarcaController();
            List<MarcaModel> ListMarca = mControle.GetListMarca();

            dbGridPesquisa.DataSource = ListMarca;
            dbGridPesquisa.Columns[0].Width = 50;
            dbGridPesquisa.Columns[1].Width = 320;
            dbGridPesquisa.Columns[2].Width = 50;
            dbGridPesquisa.Refresh();
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            Context db = new Context();
            MarcaController mControle = new MarcaController();
            MarcaModel marca = new MarcaModel();

            int Id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PMarca = mControle.GetMarca(Id);

            Close();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;
            Context db = new Context();
            MarcaController mControle = new MarcaController();
            List<MarcaModel> ListMarca = mControle.GetListMarcaPesquisa(txtPesquisa.Text);
            dbGridPesquisa.DataSource = ListMarca;
            dbGridPesquisa.Columns[0].Width = 50;
            dbGridPesquisa.Columns[1].Width = 320;
            dbGridPesquisa.Columns[2].Width = 50;
            dbGridPesquisa.Refresh();
        }
    }
}
