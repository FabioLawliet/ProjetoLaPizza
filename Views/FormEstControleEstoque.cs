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
    public partial class FormEstControleEstoque : LaPizza.Views.FormBaseCadastros
    {
        public List<ControleEstoqueItensModel> ListaItens = new List<ControleEstoqueItensModel>();

        public FormEstControleEstoque()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtEntradaDescricao.Enabled = true;
                txtProdutoId.Enabled = true;
                txtQtdeMovimentada.Enabled = true;
                rbMovimentaEntrada.Checked = true;
                rbMovimentaEntrada.Enabled = true;
                rbMovimentaSaida.Enabled = true;
                btnInserirItem.Enabled = true;
                gridItens.Enabled = true;
            }
            else
            {
                txtEntradaId.Enabled = false;
                txtEntradaDescricao.Enabled = false;
                txtProdutoId.Enabled = false;
                txtProdutoDescricao.Enabled = false;
                txtUnidadeMedida.Enabled = false;
                txtSaldoEstoque.Enabled = false;
                txtQtdeMovimentada.Enabled = false;
                rbMovimentaEntrada.Checked = false;
                rbMovimentaEntrada.Enabled = false;
                rbMovimentaSaida.Enabled = false;
                btnInserirItem.Enabled = false;
                gridItens.Enabled = false;
            }
        }

        private void LimpaComponentes()
        {
            txtEntradaId.Text = string.Empty;
            txtEntradaDescricao.Text = string.Empty;
            txtProdutoId.Text = string.Empty;
            txtProdutoDescricao.Text = string.Empty;
            txtUnidadeMedida.Text = string.Empty;
            txtSaldoEstoque.Text = string.Empty;
            txtQtdeMovimentada.Text = string.Empty;
            rbMovimentaEntrada.Checked = true;
            gridItens.DataSource = null;
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            ControleEstoqueController Controle = new ControleEstoqueController();
            txtEntradaId.Text = Controle.GetProximoId().ToString();

            if (txtEntradaDescricao.CanFocus)
            {
                txtEntradaDescricao.Focus();
                txtEntradaDescricao.Select(txtEntradaDescricao.Text.Length, 0);
            }

        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            FormEstMovimentacaoSimplificada Pesq = new FormEstMovimentacaoSimplificada();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtEntradaId.Text = Pesq.PMovimentacaoSimplificada.id.ToString();
                txtEntradaDescricao.Text = Pesq.PMovimentacaoSimplificada.descricao;

                ListaItens.Clear();
                foreach (var item in Pesq.PMovimentacaoSimplificada.itens)
                {
                    insereItemGrid(item);
                }                
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

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ControleEstoqueModel Estoque = new ControleEstoqueModel();
            ControleEstoqueController eControle = new ControleEstoqueController();

            Estoque.id = Int32.Parse(txtEntradaId.Text);
            Estoque.descricao = txtEntradaDescricao.Text;
            Estoque.dataMovimentacao = DateTime.Today.ToString();
            Estoque.itens.AddRange(ListaItens);

            if (gridItens.Rows.Count <= 0)
            {
                MessageBox.Show("Não existe nenhuma movimentação lançada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MenuStatus == MStatus.Adicionando)
                eControle.Adicionar(Estoque);
            //else if (MenuStatus == MStatus.Excluindo);
            //eControle.Excluir(Estoque.id);

            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaOperacao();
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            if (txtProdutoDescricao.Text == string.Empty)
            {
                MessageBox.Show("O produto informado é inválido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtQtdeMovimentada.Text == string.Empty)
            {
                MessageBox.Show("A Qtde Movimentada informada é inválida", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ControleEstoqueItensModel Item = new ControleEstoqueItensModel();

            Item.idControle = Int32.Parse(txtEntradaId.Text);
            Item.idProduto = Int32.Parse(txtProdutoId.Text);
            Item.ProdutoDescricao = txtProdutoDescricao.Text;
            Item.saldoEstoqueAnterior = decimal.Parse(txtSaldoEstoque.Text);

            if (rbMovimentaEntrada.Checked)
                Item.tipoEntrada = "E";
            else
                Item.tipoEntrada = "S";

            Item.qtdeMovimentada = decimal.Parse(txtQtdeMovimentada.Text);
            Item.saldoEstoqueNovo = CalculaSaldoAtual(Item.saldoEstoqueAnterior, Item.tipoEntrada, Item.qtdeMovimentada);

            if (!ExisteProduto(Item.idProduto))
                insereItemGrid(Item);
            else
            {
                MessageBox.Show("O produto já foi inserido na lista", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gridItens.RowCount > 0)
                HabilitaAcao(TipoAcao.Confirmar, true);
        }
        private bool ExisteProduto(int Id)
        {
            foreach (var item in ListaItens)
                if (item.idProduto == Id)
                    return true;

            return false;
            
        }

        private void insereItemGrid(ControleEstoqueItensModel Item)
        {
            gridItens.DataSource = null;
            ListaItens.Add(Item);
            gridItens.DataSource = ListaItens;

            gridItens.Columns["idControle"].Visible = false;

            gridItens.Columns["idProduto"].HeaderText = "Produto";
            gridItens.Columns["idProduto"].Width = 70;

            gridItens.Columns["ProdutoDescricao"].HeaderText = "Descrição";
            gridItens.Columns["ProdutoDescricao"].Width = 150;

            gridItens.Columns["saldoEstoqueAnterior"].HeaderText = "Est. Atual";
            gridItens.Columns["saldoEstoqueAnterior"].Width = 90;

            gridItens.Columns["tipoEntrada"].HeaderText = "Tipo Mov.";
            gridItens.Columns["tipoEntrada"].Width = 70;

            gridItens.Columns["qtdeMovimentada"].HeaderText = "Qtde Mov.";
            gridItens.Columns["qtdeMovimentada"].Width = 90;

            gridItens.Columns["saldoEstoqueNovo"].HeaderText = "Est. Novo";
            gridItens.Columns["saldoEstoqueNovo"].Width = 90;
            
            gridItens.Refresh();
        }

        private decimal CalculaSaldoAtual(decimal saldoAnterior, string TipoMovimentacao, decimal qtdeMovimentada)
        {
            if (TipoMovimentacao == "E")
                return saldoAnterior + qtdeMovimentada;
            else
                return saldoAnterior - qtdeMovimentada;
        }

        private void txtUnidadeMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProdutoId_TextChanged(object sender, EventArgs e)
        {
            if (txtProdutoId.Text != "")
            {
                ProdutoController Controle = new ProdutoController();
                ProdutoModel Produto = new ProdutoModel();

                var id = Int32.Parse(txtProdutoId.Text);

                if (Controle.ExisteId(id))
                {
                    Produto = Controle.GetProduto(id);
                    txtProdutoId.Text = Produto.id.ToString();
                    txtProdutoDescricao.Text = Produto.descricao;
                    txtSaldoEstoque.Text = Produto.saldoEstoque.ToString();
                    txtUnidadeMedida.Text = Produto.unidadeMedida;
                }
                else
                    txtProdutoDescricao.Text = String.Empty;
            }
            else
                txtProdutoDescricao.Text = String.Empty;
        }

        private void txtProdutoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtProdutoId.Text = Pesq.PProduto.id.ToString();
                    txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                    txtSaldoEstoque.Text = Pesq.PProduto.saldoEstoque.ToString();
                    txtUnidadeMedida.Text = Pesq.PProduto.unidadeMedida;
                }
            }
        }

        private void txtQtdeMovimentada_Leave(object sender, EventArgs e)
        {
            if (txtQtdeMovimentada.Text != string.Empty && txtSaldoEstoque.Text != string.Empty)
            {
                decimal SaldoMovimento = decimal.Parse(txtQtdeMovimentada.Text);
                decimal SaldoAtual = decimal.Parse(txtSaldoEstoque.Text);

                if (rbMovimentaSaida.Checked && (SaldoAtual - SaldoMovimento < 0))
                    MessageBox.Show("A quantidade a ser deduzida é maior que o saldo de estoque!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
