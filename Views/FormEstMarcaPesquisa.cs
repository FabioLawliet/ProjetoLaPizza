using LaPizza.Models;
using LaPizza.Controllers;
using System.Collections.Generic;
using System;

using LaPizza.DAO;

namespace LaPizza.Views
{
    public partial class FormEstMarcaPesquisa : LaPizza.Views.FormBasePesquisa
    {
        FormEstMarca FMarca = null;
        public FormEstMarcaPesquisa(FormEstMarca Marca)
        {
            InitializeComponent();
            FMarca = Marca;

            CarregarListaGrid();
            txtPesquisa.Focus();
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
            MarcaDto marca = new MarcaDto();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            marca = mControle.GetMarca(id);
            FMarca.txtId.Text = marca.id.ToString();
            FMarca.txtDescricao.Text = marca.descricao;
            FMarca.cbAtiva.Checked = marca.ativa;
            FMarca.btnConfirmar.Enabled = true;
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
            List<MarcaModel> ListMarca = mControle.GetListMarcaWhere(txtPesquisa.Text);
            dbGridPesquisa.DataSource = ListMarca;
            dbGridPesquisa.Columns[0].Width = 50;
            dbGridPesquisa.Columns[1].Width = 320;
            dbGridPesquisa.Columns[2].Width = 50;
            dbGridPesquisa.Refresh();
        }
    }
}
