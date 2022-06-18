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
        public ProdutoDTO PProduto;

        public FormEstProdutoPesquisa()
        {
            InitializeComponent();
            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregarListaGrid()
        {
            ProdutoController Pcontrole = new ProdutoController();
            List<ProdutoDTO> Lista = Pcontrole.GetProdutoLista();

            dbGridPesquisa.DataSource = Lista;
            AjustaCampoGrid();
            dbGridPesquisa.Refresh();
        }

        private void AjustaCampoGrid()
        {
            dbGridPesquisa.Columns["idproduto"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idproduto"].HeaderText = "Id";
            dbGridPesquisa.Columns["idproduto"].Width = 50;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].HeaderText = "Descrição Produto";
            dbGridPesquisa.Columns["descricao"].Width = 244;

            dbGridPesquisa.Columns["saldoestoque"].DisplayIndex = 2;
            dbGridPesquisa.Columns["saldoestoque"].HeaderText = "Saldo Estoque";
            dbGridPesquisa.Columns["saldoestoque"].Width = 90;

            dbGridPesquisa.Columns["precoatual"].DisplayIndex = 3;
            dbGridPesquisa.Columns["precoatual"].HeaderText = "Preço Atual";
            dbGridPesquisa.Columns["precoatual"].Width = 70;

            dbGridPesquisa.Columns["datacadastro"].Visible = false;
            dbGridPesquisa.Columns["idgrupo"].Visible = false;
            dbGridPesquisa.Columns["idsubgrupo"].Visible = false;
            dbGridPesquisa.Columns["idmarca"].Visible = false;
            dbGridPesquisa.Columns["codigofabricante"].Visible = false;
            dbGridPesquisa.Columns["infadicionais"].Visible = false;
            dbGridPesquisa.Columns["idunidmedida"].Visible = false;
            dbGridPesquisa.Columns["qtdeestmin"].Visible = false;
            dbGridPesquisa.Columns["qtdeestideal"].Visible = false;
            dbGridPesquisa.Columns["qtdeestmax"].Visible = false;
            dbGridPesquisa.Columns["precoanterior"].Visible = false;
            dbGridPesquisa.Columns["ativo"].Visible = false;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            ProdutoController controle = new ProdutoController();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PProduto = controle.GetProduto(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dbGridPesquisa.DataSource = null;
            ProdutoController controle = new ProdutoController();
            List<ProdutoDTO> Lista = controle.GetProdutoPesquisaGrid(txtPesquisa.Text, (string)txtPesquisa.Tag);

            dbGridPesquisa.DataSource = Lista;
            AjustaCampoGrid();
            dbGridPesquisa.Refresh();
        }
    }
}
