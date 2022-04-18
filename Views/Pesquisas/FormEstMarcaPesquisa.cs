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
        public TextBox FMarcaId;
        public TextBox FMarcaDesc;
        public FormEstMarca FMarca;

        public FormEstMarcaPesquisa(TextBox id, TextBox descricao)
        {
            FMarcaId = id;
            FMarcaDesc = descricao;

            InitializeComponent();

            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public FormEstMarcaPesquisa(FormEstMarca FormMarca)
        {
            FMarca = FormMarca;

            InitializeComponent();

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
            MarcaModel marca = new MarcaModel();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            marca = mControle.GetMarca(id);

            if (FMarca == null)
            {
                FMarcaId.Text = marca.id.ToString();
                FMarcaDesc.Text = marca.descricao;
            }
            else
            {
                FMarca.txtId.Text = marca.id.ToString();
                FMarca.txtDescricao.Text = marca.descricao;
                FMarca.cbAtiva.Enabled = marca.ativa;
            }

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
