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
        public FormEstProduto()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);

        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtProdutoDescricao.Enabled = true;
                cbAtivo.Enabled = true;
                txtGrupoId.Enabled = true;
                txtSubgrupoId.Enabled = true;
                txtMarcaId.Enabled = true;
                txtCodigoFabricante.Enabled = true;
                txtInfAdicionais.Enabled = true;
                txtUnidadeMedida.Enabled = true;
                txtQtdeEstMin.Enabled = true;
                txtQtdeEstIdeal.Enabled = true;
                txtQtdeEstMax.Enabled = true;
                txtPrecoAtual.Enabled = true;
            }
            else
            {
                txtProdutoId.Enabled = false;
                txtProdutoDescricao.Enabled = false;
                txtDataCadastro.Enabled = false;
                cbAtivo.Enabled = false;
                txtGrupoId.Enabled = false;
                txtGrupoDescricao.Enabled = false;
                txtSubgrupoId.Enabled = false;
                txtSubgrupoDescricao.Enabled = false;
                txtMarcaId.Enabled = false;
                txtMarcaDescricao.Enabled = false;
                txtCodigoFabricante.Enabled = false;
                txtInfAdicionais.Enabled = false;
                txtSaldoEstoque.Enabled = false;
                txtUnidadeMedida.Enabled = false;
                txtQtdeEstMin.Enabled = false;
                txtQtdeEstIdeal.Enabled = false;
                txtQtdeEstMax.Enabled = false;
                txtPrecoAnterior.Enabled = false;
                txtPrecoAtual.Enabled = false;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            ProdutoController PControle = new ProdutoController();
            txtProdutoId.Text = PControle.GetProximoId().ToString();

            if (txtProdutoDescricao.CanFocus)
            {
                txtProdutoDescricao.Focus();
                txtMarcaDescricao.Select(txtMarcaDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtProdutoId.Text = Pesq.PProduto.id.ToString();
                txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                txtDataCadastro.Text = Pesq.PProduto.dataCadastro.ToString();
                cbAtivo.Checked = Pesq.PProduto.ativo;
                txtGrupoId.Text = Pesq.PProduto.grupo.ToString();
                txtGrupoDescricao.Text = "";//Pesq.PProduto.grupoDescricao;
                txtSubgrupoId.Text = Pesq.PProduto.subgrupo.ToString();
                txtSubgrupoDescricao.Text = "";//Pesq.PProduto.subGrupoDescricao;
                txtMarcaId.Text = Pesq.PProduto.marca.ToString();
                txtMarcaDescricao.Text = Pesq.PProduto.marcaDescricao;
                txtInfAdicionais.Text = Pesq.PProduto.infAdicionais;
                txtCodigoFabricante.Text = Pesq.PProduto.codigoFabricante;
                txtSaldoEstoque.Text = Pesq.PProduto.saldoEstoque.ToString();
                txtUnidadeMedida.Text = Pesq.PProduto.unidadeMedida;
                txtQtdeEstMin.Text = Pesq.PProduto.qtdeEstMin.ToString();
                txtQtdeEstIdeal.Text = Pesq.PProduto.qtdeEstIdeal.ToString();
                txtQtdeEstMax.Text = Pesq.PProduto.qtdeEstMax.ToString();
                txtPrecoAnterior.Text = Pesq.PProduto.precoAnterior.ToString();
                txtPrecoAtual.Text = Pesq.PProduto.precoAtual.ToString();

                HabilitarComponentesPnlPrincipal(true);
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtProdutoDescricao.CanFocus)
            {
                txtProdutoDescricao.Focus();
                txtProdutoDescricao.Select(txtMarcaDescricao.Text.Length, 0);
            }



        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {

            FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtProdutoId.Text = Pesq.PProduto.id.ToString();
                txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                txtDataCadastro.Text = Pesq.PProduto.dataCadastro.ToString();
                cbAtivo.Checked = Pesq.PProduto.ativo;
                txtGrupoId.Text = Pesq.PProduto.grupo.ToString();
                txtGrupoDescricao.Text = ""; //Pesq.PProduto.grupoDescricao;
                txtSubgrupoId.Text = Pesq.PProduto.subgrupo.ToString();
                txtSubgrupoDescricao.Text = ""; //Pesq.PProduto.subgrupoDescricao;
                txtMarcaId.Text = Pesq.PProduto.marca.ToString();
                txtMarcaDescricao.Text = Pesq.PProduto.marcaDescricao;
                txtInfAdicionais.Text = Pesq.PProduto.infAdicionais;
                txtCodigoFabricante.Text = Pesq.PProduto.codigoFabricante;
                txtSaldoEstoque.Text = Pesq.PProduto.saldoEstoque.ToString();
                txtUnidadeMedida.Text = Pesq.PProduto.unidadeMedida;
                txtQtdeEstMin.Text = Pesq.PProduto.qtdeEstMin.ToString();
                txtQtdeEstIdeal.Text = Pesq.PProduto.qtdeEstIdeal.ToString();
                txtQtdeEstMax.Text = Pesq.PProduto.qtdeEstMax.ToString();
                txtPrecoAnterior.Text = Pesq.PProduto.precoAnterior.ToString();
                txtPrecoAtual.Text = Pesq.PProduto.precoAtual.ToString();

                HabilitarComponentesPnlPrincipal(false);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();


        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtProdutoId.Text = Pesq.PProduto.id.ToString();
                txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                txtDataCadastro.Text = Pesq.PProduto.dataCadastro.ToString();
                cbAtivo.Checked = Pesq.PProduto.ativo;
                txtGrupoId.Text = Pesq.PProduto.grupo.ToString();
                txtGrupoDescricao.Text = Pesq.PProduto.grupoDescricao;
                txtSubgrupoId.Text = Pesq.PProduto.subgrupo.ToString();
                txtSubgrupoDescricao.Text = Pesq.PProduto.subgrupoDescricao;
                txtMarcaId.Text = Pesq.PProduto.marca.ToString();
                txtMarcaDescricao.Text = Pesq.PProduto.marcaDescricao;
                txtInfAdicionais.Text = Pesq.PProduto.infAdicionais;
                txtCodigoFabricante.Text = Pesq.PProduto.codigoFabricante;
                txtSaldoEstoque.Text = Pesq.PProduto.saldoEstoque.ToString();
                txtUnidadeMedida.Text = Pesq.PProduto.unidadeMedida;
                txtQtdeEstMin.Text = Pesq.PProduto.qtdeEstMin.ToString();
                txtQtdeEstIdeal.Text = Pesq.PProduto.qtdeEstIdeal.ToString();
                txtQtdeEstMax.Text = Pesq.PProduto.qtdeEstMax.ToString();
                txtPrecoAnterior.Text = Pesq.PProduto.precoAnterior.ToString();
                txtPrecoAtual.Text = Pesq.PProduto.precoAtual.ToString();

                HabilitarComponentesPnlPrincipal(false);
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();


        }

        private void LimpaComponentes()
        {
            txtProdutoId.Text = string.Empty;
            txtProdutoDescricao.Text = string.Empty;
            txtDataCadastro.Text = string.Empty;
            cbAtivo.Checked = true;
            txtGrupoId.Text = string.Empty;
            txtGrupoDescricao.Text = string.Empty;
            txtSubgrupoId.Text = string.Empty;
            txtSubgrupoDescricao.Text = string.Empty;
            txtMarcaId.Text = string.Empty;
            txtMarcaDescricao.Text = string.Empty;
            txtCodigoFabricante.Text = string.Empty;
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
            if (txtProdutoDescricao.Text == string.Empty)
            {
                MessageBox.Show("É necessário informar uma descrição");
                txtProdutoDescricao.Focus();
            }
            else
            {
                ProdutoController Pcontrole = new ProdutoController();
                ProdutoDto Produto = new ProdutoDto();

                Produto.id = Int32.Parse(txtProdutoId.Text);
                Produto.descricao = txtProdutoDescricao.Text;
                Produto.datacadastro = DateTime.Now;
                Produto.ativo = cbAtivo.Checked;
                Produto.grupo = Int32.Parse(txtGrupoId.Text);
                Produto.subgrupo = Int32.Parse(txtSubgrupoId.Text);
                Produto.marca = Int32.Parse(txtMarcaId.Text);
                Produto.codigofabricante = txtCodigoFabricante.Text;
                Produto.infadicionais = txtInfAdicionais.Text;
                Produto.saldoestoque = 0;
                Produto.unidademedida = txtUnidadeMedida.Text;
                Produto.qtdeestmin = Convert.ToDecimal(txtQtdeEstMin.Text);
                Produto.qtdeestideal = Convert.ToDecimal(txtQtdeEstIdeal.Text);
                Produto.qtdeestmax = Convert.ToDecimal(txtQtdeEstMax.Text);
                Produto.precoatual = Convert.ToDecimal(txtPrecoAtual.Text);
                Produto.precoanterior = Produto.precoatual;

                if (MenuStatus == MStatus.Adicionando)
                    Pcontrole.Adicionar(Produto);
                else if (MenuStatus == MStatus.Editando)
                    Pcontrole.Editar(Produto);
                else if (MenuStatus == MStatus.Excluindo)
                    Pcontrole.Excluir(Produto.id);
            }

            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void txtProdutoDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtProdutoDescricao.Text != String.Empty && txtProdutoDescricao.Enabled == true)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }

        private void txtMarcaId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstMarcaPesquisa Pesq = new FormEstMarcaPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtMarcaId.Text = Pesq.PMarca.id.ToString();
                    txtMarcaDescricao.Text = Pesq.PMarca.descricao;
                }
            }
        }

        private void txtMarcaId_TextChanged(object sender, EventArgs e)
        {
            MarcaController mControle = new MarcaController();
            MarcaModel Marca = new MarcaModel();

            if (txtMarcaId.Text != String.Empty && mControle.ExisteMarca(Int32.Parse(txtMarcaId.Text)))
            {
                Marca = mControle.GetMarca(Int32.Parse(txtMarcaId.Text));
                txtMarcaDescricao.Text = Marca.descricao;
            }
            else
                txtMarcaDescricao.Text = String.Empty;

        }

        private void txtGrupoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstGrupoPesquisa Pesq = new FormEstGrupoPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtGrupoId.Text = Pesq.PGrupo.id.ToString();
                    txtGrupoDescricao.Text = Pesq.PGrupo.descricao;
                }
            }
        }

        private void txtGrupoId_TextChanged(object sender, EventArgs e)
        {
            GrupoController gControle = new GrupoController();
            GrupoModel Grupo = new GrupoModel();

            if (txtGrupoId.Text != String.Empty && gControle.ExisteGrupoId(Int32.Parse(txtGrupoId.Text)))
            {
                Grupo = gControle.GetGrupo(Int32.Parse(txtGrupoId.Text));
                txtGrupoDescricao.Text = Grupo.descricao;
            }
            else
                txtGrupoDescricao.Text = String.Empty;
        }
    }
}
