using LaPizza.Controllers;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormEstProduto : LaPizza.Views.FormBaseCadastros
    {
        public ProdutoModel ProdutoPesquisa;
        //public GrupoModel GrupoPesquisa;
        //public SubGrupoModel SubGrupoPesquisa;
        public MarcaModel MarcaPesquisa;
        public FormEstProduto()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        { 

            if (Ativa)
            {
                txtProdutoDescricao.BackColor = Color.White;
                txtProdutoDescricao.Enabled = true;

                cbAtivo.BackColor = Color.White;
                cbAtivo.Enabled = true;

                txtGrupoId.BackColor = Color.White;
                txtGrupoId.Enabled = true;

                txtSubGrupoId.BackColor = Color.White;
                txtSubGrupoId.Enabled = true;

                txtMarcaId.BackColor = Color.White;
                txtMarcaId.Enabled = true;

                txtCodFabricante.BackColor = Color.White;
                txtCodFabricante.Enabled = true;

                txtInfAdicionais.BackColor = Color.White;
                txtInfAdicionais.Enabled = true;

                txtQtdeEstMin.BackColor = Color.White;
                txtQtdeEstMin.Enabled = true;

                txtQtdeEstIdeal.BackColor = Color.White;
                txtQtdeEstIdeal.Enabled = true;

                txtQtdeEstMax.BackColor = Color.White;
                txtQtdeEstMax.Enabled = true;

                txtPrecoAtual.BackColor = Color.White;
                txtPrecoAtual.Enabled = true;
            }
            else
            {
                txtProdutoId.BackColor = Color.LightGray;
                txtProdutoId.Enabled = false;

                txtProdutoDescricao.BackColor = Color.LightGray;
                txtProdutoDescricao.Enabled = false;

                txtDataCadastro.BackColor = Color.LightGray;
                txtDataCadastro.Enabled = false;

                cbAtivo.BackColor = Color.LightGray;
                cbAtivo.Enabled = false;

                txtGrupoId.BackColor = Color.LightGray;
                txtGrupoId.Enabled = false;
                txtGrupoDescricao.BackColor = Color.LightGray;
                txtGrupoDescricao.Enabled = false;

                txtSubGrupoId.BackColor = Color.LightGray;
                txtSubGrupoId.Enabled = false;
                txtSubGrupoDescricao.BackColor = Color.LightGray;
                txtSubGrupoDescricao.Enabled = false;

                txtMarcaId.BackColor = Color.LightGray;
                txtMarcaId.Enabled = false;
                txtMarcaDescricao.BackColor = Color.LightGray;
                txtMarcaDescricao.Enabled = false;

                txtCodFabricante.BackColor = Color.LightGray;
                txtCodFabricante.Enabled = false;

                txtInfAdicionais.BackColor = Color.LightGray;
                txtInfAdicionais.Enabled = false;

                txtSaldoEstoque.BackColor = Color.LightGray;
                txtSaldoEstoque.Enabled = false;

                txtUnidadeMedida.BackColor = Color.LightGray;
                txtUnidadeMedida.Enabled = false;

                txtQtdeEstMin.BackColor = Color.LightGray;
                txtQtdeEstMin.Enabled = false;

                txtQtdeEstIdeal.BackColor = Color.LightGray;
                txtQtdeEstIdeal.Enabled = false;

                txtQtdeEstMax.BackColor = Color.LightGray;
                txtQtdeEstMax.Enabled = false;

                txtPrecoAnterior.BackColor = Color.LightGray;
                txtPrecoAnterior.Enabled = false;
                txtPrecoAtual.BackColor = Color.LightGray;
                txtPrecoAtual.Enabled = false;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            ProdutoController PControle = new ProdutoController();
            txtProdutoId.Text = (PControle.GetProximoId() + 1).ToString();

            if (txtProdutoDescricao.CanFocus)
                txtProdutoDescricao.Focus();

        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            FormEstProdutoPesquisa pesquisaProduto = new FormEstProdutoPesquisa(this);
            pesquisaProduto.ShowDialog();

            if (MenuStatus == null)
                cancelaOperacao();

        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {

        }

        private void LimpaComponentes()
        {
            txtProdutoId.Text = string.Empty;
            txtProdutoDescricao.Text = string.Empty;
            txtDataCadastro.Text = string.Empty;
            cbAtivo.Checked = true;
            txtGrupoId.Text = string.Empty;
            txtGrupoDescricao.Text = string.Empty;
            txtSubGrupoId.Text = string.Empty;
            txtSubGrupoDescricao.Text = string.Empty;
            txtMarcaId.Text = string.Empty;
            txtMarcaDescricao.Text = string.Empty;
            txtCodFabricante.Text = string.Empty;
            txtInfAdicionais.Text = string.Empty;
            txtSaldoEstoque.Text = string.Empty;
            txtUnidadeMedida.Text = string.Empty;
            txtQtdeEstMin.Text = string.Empty;
            txtQtdeEstIdeal.Text = string.Empty;
            txtQtdeEstMax.Text = string.Empty;
            txtPrecoAnterior.Text = string.Empty;
            txtPrecoAtual.Text = string.Empty;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }
    }
}
