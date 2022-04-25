using LaPizza.Controllers;
using LaPizza.DAO;
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
    public partial class FormEstProdutoPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public ProdutoModel PProduto;

        public FormEstProdutoPesquisa()
        {
            InitializeComponent();
            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregarListaGrid()
        {
            Context db = new Context();
            ProdutoController Pcontrole = new ProdutoController();
            List<ProdutoModel> ListProduto = Pcontrole.GetProdutoLista();

            dbGridPesquisa.DataSource = ListProduto;

            dbGridPesquisa.Columns[0].HeaderText = "Id";
            dbGridPesquisa.Columns[0].Width = 50;

            dbGridPesquisa.Columns[1].HeaderText = "Descrição";
            dbGridPesquisa.Columns[1].Width = 250;

            dbGridPesquisa.Columns[2].Visible = false;
            dbGridPesquisa.Columns[3].Visible = false;
            dbGridPesquisa.Columns[4].Visible = false;
            dbGridPesquisa.Columns[5].Visible = false;
            dbGridPesquisa.Columns[6].Visible = false;
            dbGridPesquisa.Columns[7].Visible = false;
            dbGridPesquisa.Columns[8].Visible = false;
            dbGridPesquisa.Columns[9].Visible = false;
            dbGridPesquisa.Columns[10].Visible = false;

            dbGridPesquisa.Columns[11].HeaderText = "Saldo Estoque";
            dbGridPesquisa.Columns[11].Width = 100;

            dbGridPesquisa.Columns[12].Visible = false;
            dbGridPesquisa.Columns[13].Visible = false;
            dbGridPesquisa.Columns[14].Visible = false;
            dbGridPesquisa.Columns[15].Visible = false;

            dbGridPesquisa.Columns[16].HeaderText = "Preço";
            dbGridPesquisa.Columns[16].Width = 100;

            dbGridPesquisa.Columns[17].Visible = false;

            this.Width = 555;
            dbGridPesquisa.Refresh();
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            Context db = new Context();
            ProdutoController pControle = new ProdutoController();
            ProdutoModel produto = new ProdutoModel();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PProduto = pControle.GetProduto(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;
            Context db = new Context();
            ProdutoController pControle = new ProdutoController();
            List<ProdutoModel> ListProduto = pControle.GetProdutoPesquisa(txtPesquisa.Text);
            dbGridPesquisa.DataSource = ListProduto;
            dbGridPesquisa.Columns[0].HeaderText = "Id";
            dbGridPesquisa.Columns[0].Width = 50;

            dbGridPesquisa.Columns[1].HeaderText = "Descrição";
            dbGridPesquisa.Columns[1].Width = 250;

            dbGridPesquisa.Columns[2].Visible = false;
            dbGridPesquisa.Columns[3].Visible = false;
            dbGridPesquisa.Columns[4].Visible = false;
            dbGridPesquisa.Columns[5].Visible = false;
            dbGridPesquisa.Columns[6].Visible = false;
            dbGridPesquisa.Columns[7].Visible = false;
            dbGridPesquisa.Columns[8].Visible = false;
            dbGridPesquisa.Columns[9].Visible = false;
            dbGridPesquisa.Columns[10].Visible = false;

            dbGridPesquisa.Columns[11].HeaderText = "Saldo Estoque";
            dbGridPesquisa.Columns[11].Width = 100;

            dbGridPesquisa.Columns[12].Visible = false;
            dbGridPesquisa.Columns[13].Visible = false;
            dbGridPesquisa.Columns[14].Visible = false;
            dbGridPesquisa.Columns[15].Visible = false;

            dbGridPesquisa.Columns[16].HeaderText = "Preço";
            dbGridPesquisa.Columns[16].Width = 100;

            dbGridPesquisa.Columns[17].Visible = false;

            this.Width = 555;
            dbGridPesquisa.Refresh();
        }
    }
}
