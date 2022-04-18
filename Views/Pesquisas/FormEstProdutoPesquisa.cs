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
        public TextBox FProdId;
        public TextBox FProdDesc;
        public FormEstProduto FProduto;
        public FormEstProdutoPesquisa(TextBox id, TextBox descricao)
        {
            InitializeComponent();

            FProdId = id;
            FProdDesc = descricao;

            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public FormEstProdutoPesquisa(FormEstProduto FormProduto)
        {
            InitializeComponent();

            FProduto = FormProduto;

            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregarListaGrid()
        {
            Context db = new Context();
            ProdutoController pControle = new ProdutoController();
            List<ProdutoModel> ListProduto = pControle.GetListProduto();

            dbGridPesquisa.DataSource = ListProduto;
            dbGridPesquisa.Columns[0].Width = 50;
            dbGridPesquisa.Columns[1].Width = 320;
            dbGridPesquisa.Columns[2].Width = 50;
            dbGridPesquisa.Columns[3].Width = 50;
            dbGridPesquisa.Refresh();
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            Context db = new Context();
            ProdutoController pControle = new ProdutoController();
            ProdutoModel produto = new ProdutoModel();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            produto = pControle.GetProduto(id);

            if (FProduto == null)
            {
                FProdId.Text = produto.id.ToString();
                FProdDesc.Text = produto.descricao;
            }
            else
            {
                FProduto.txtProdutoId.Text = produto.id.ToString();
                FProduto.txtProdutoDescricao.Text = produto.descricao;
                FProduto.txtDataCadastro.Text = produto.dataCadastro.ToString();
                FProduto.cbAtivo.Enabled = produto.ativo;
                FProduto.txtGrupoId.Text = produto.grupo.ToString();
                FProduto.txtGrupoDescricao.Text = produto.grupoDescricao;
                FProduto.txtSubGrupoId.Text = produto.subgrupo.ToString();
                FProduto.txtSubGrupoDescricao.Text = produto.subGrupoDescricao;
                FProduto.txtMarcaId.Text = produto.marca.ToString();
                FProduto.txtMarcaDescricao.Text = produto.marcaDescricao;
                FProduto.txtInfAdicionais.Text = produto.infAdicionais;
                FProduto.txtCodFabricante.Text = produto.codFabricante;
                FProduto.txtSaldoEstoque.Text = produto.saldoEstoque.ToString();
                FProduto.txtUnidadeMedida.Text = produto.unidadeMedida;
                FProduto.txtQtdeEstMin.Text = produto.qtdeEstMin.ToString();
                FProduto.txtQtdeEstIdeal.Text = produto.qtdeEstIdeal.ToString();
                FProduto.txtQtdeEstMax.Text = produto.qtdeEstMax.ToString();
                FProduto.txtPrecoAnterior.Text = produto.precoAnterior.ToString();
                FProduto.txtPrecoAtual.Text = produto.precoAtual.ToString();

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
            dbGridPesquisa.Columns[3].Width = 50;
            dbGridPesquisa.Refresh();
        }
    }
}
