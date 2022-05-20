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
    public partial class FormEstMovimentacaoSimplificada : LaPizza.Views.FormBaseCadastros
    {
        public List<MovimentoEstoqueItensModel> ListaItens = new List<MovimentoEstoqueItensModel>();

        public FormEstMovimentacaoSimplificada()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
            ListaItens.Clear();
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtMovimentoDescricao.Enabled = true;
                txtProdutoId.Enabled = true;
                txtQtdeMovimento.Enabled = true;
                rbMovimentoEntrada.Checked = true;
                rbMovimentoEntrada.Enabled = true;
                rbMovimentoSaida.Enabled = true;
                btnInserirItem.Enabled = true;
                gridMovimentos.Enabled = true;
            }
            else
            {
                txtMovimentoId.Enabled = false;
                txtMovimentoDescricao.Enabled = false;
                txtProdutoId.Enabled = false;
                txtProdutoDescricao.Enabled = false;
                txtUnidadeMedida.Enabled = false;
                txtSaldoEstoque.Enabled = false;
                txtQtdeMovimento.Enabled = false;
                rbMovimentoEntrada.Checked = false;
                rbMovimentoEntrada.Enabled = false;
                rbMovimentoSaida.Enabled = false;
                btnInserirItem.Enabled = false;
                gridMovimentos.Enabled = false;
            }
        }

        private void LimpaComponentes()
        {
            txtMovimentoId.Text = string.Empty;
            txtMovimentoDescricao.Text = string.Empty;
            txtProdutoId.Text = string.Empty;
            txtProdutoDescricao.Text = string.Empty;
            txtUnidadeMedida.Text = string.Empty;
            txtSaldoEstoque.Text = string.Empty;
            txtQtdeMovimento.Text = string.Empty;
            rbMovimentoEntrada.Checked = true;
            gridMovimentos.DataSource = null;
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            MovimentoEstoqueController controle = new MovimentoEstoqueController();
            txtMovimentoId.Text = controle.GetProximoId().ToString();

            if (txtMovimentoDescricao.CanFocus)
            {
                txtMovimentoDescricao.Focus();
                txtMovimentoDescricao.Select(txtMovimentoDescricao.Text.Length, 0);
            }

        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            Pesquisas.FormEstMovimentacaoSimplificadaPesquisa Pesq = new Pesquisas.FormEstMovimentacaoSimplificadaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtMovimentoId.Text = Pesq.PMovimentacaoSimplificada.idmovimento.ToString();
                txtMovimentoDescricao.Text = Pesq.PMovimentacaoSimplificada.descricao;

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

            gridMovimentos.Enabled = true;

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();

        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            Pesquisas.FormEstMovimentacaoSimplificadaPesquisa Pesq = new Pesquisas.FormEstMovimentacaoSimplificadaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtMovimentoId.Text = Pesq.PMovimentacaoSimplificada.idmovimento.ToString();
                txtMovimentoDescricao.Text = Pesq.PMovimentacaoSimplificada.descricao;

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

            gridMovimentos.Enabled = true;
            HabilitaAcao(TipoAcao.Confirmar, true);

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MovimentoEstoqueModel movimento = new MovimentoEstoqueModel();
            MovimentoEstoqueController controle = new MovimentoEstoqueController();

            movimento.idmovimento = Int32.Parse(txtMovimentoId.Text);
            movimento.descricao = txtMovimentoDescricao.Text;
            movimento.datamovimento = DateTime.Today.ToString();
            movimento.itens.AddRange(ListaItens);

            if (gridMovimentos.Rows.Count <= 0)
            {
                MessageBox.Show("Não existe nenhuma movimentação lançada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MenuStatus == MStatus.Adicionando)
                controle.Adicionar(movimento);
            else if (MenuStatus == MStatus.Excluindo)
                controle.Excluir(movimento.idmovimento);

            ListaItens.Clear();
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ListaItens.Clear();
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
            ListaItens.Clear();
            Close();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            if (txtProdutoDescricao.Text == string.Empty)
            {
                MessageBox.Show("O produto informado é inválido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtQtdeMovimento.Text == string.Empty)
            {
                MessageBox.Show("A Qtde Movimentada informada é inválida", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ExisteProdutoGrid(Int32.Parse(txtProdutoId.Text)))
            {
                MovimentoEstoqueItensModel item = new MovimentoEstoqueItensModel();

                item.idmovimento = Int32.Parse(txtMovimentoId.Text);
                item.idproduto = Int32.Parse(txtProdutoId.Text);
                item.produtodescricao = txtProdutoDescricao.Text;
                item.saldoestoqueanterior = decimal.Parse(txtSaldoEstoque.Text);

                if (rbMovimentoEntrada.Checked)
                    item.tipomovimento = "E";
                else
                    item.tipomovimento = "S";

                item.qtdemovimento = decimal.Parse(txtQtdeMovimento.Text);
                item.saldoestoquenovo = CalculaSaldoAtual(item.saldoestoqueanterior, item.tipomovimento, item.qtdemovimento);

                gridMovimentos.DataSource = null;
                insereItemGrid(item);
            }
            else
            {
                MessageBox.Show("O produto já foi inserido na lista", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (gridMovimentos.RowCount > 0)
                HabilitaAcao(TipoAcao.Confirmar, true);

            txtProdutoId.Text = string.Empty;
            txtProdutoDescricao.Text = string.Empty;
            txtUnidadeMedida.Text = string.Empty;
            txtSaldoEstoque.Text = string.Empty;
            txtQtdeMovimento.Text = string.Empty;
            rbMovimentoEntrada.Checked = true;

            if (txtProdutoId.CanFocus)
                txtProdutoId.Focus();
        }
        private bool ExisteProdutoGrid(int Id)
        {
            foreach (var item in ListaItens)
                if (item.idproduto == Id)
                    return true;

            return false;
            
        }

        private void insereItemGrid(MovimentoEstoqueItensModel Item)
        {
            ListaItens.Add(Item);
            gridMovimentos.DataSource = null;
            gridMovimentos.DataSource = ListaItens;

            gridMovimentos.Columns["id"].Visible = false;
            gridMovimentos.Columns["idmovimento"].Visible = false;

            gridMovimentos.Columns["idproduto"].HeaderText = "Produto";
            gridMovimentos.Columns["idproduto"].Width = 70;

            gridMovimentos.Columns["produtodescricao"].HeaderText = "Descrição";
            gridMovimentos.Columns["produtodescricao"].Width = 150;

            gridMovimentos.Columns["saldoestoqueanterior"].HeaderText = "Est. Atual";
            gridMovimentos.Columns["saldoestoqueanterior"].Width = 90;

            gridMovimentos.Columns["tipomovimento"].HeaderText = "Tipo Mov.";
            gridMovimentos.Columns["tipomovimento"].Width = 70;

            gridMovimentos.Columns["qtdemovimento"].HeaderText = "Qtde Mov.";
            gridMovimentos.Columns["qtdemovimento"].Width = 90;

            gridMovimentos.Columns["saldoestoquenovo"].HeaderText = "Est. Novo";
            gridMovimentos.Columns["saldoestoquenovo"].Width = 90;
            
            gridMovimentos.Refresh();
        }

        private decimal CalculaSaldoAtual(decimal saldoAnterior, string TipoMovimento, decimal qtdeMovimento)
        {
            if (TipoMovimento == "E")
                return saldoAnterior + qtdeMovimento;
            else
                return saldoAnterior - qtdeMovimento;
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

                if (Controle.ExisteProduto(id))
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
            if (txtQtdeMovimento.Text != string.Empty && txtSaldoEstoque.Text != string.Empty)
            {
                var saldoAtual = decimal.Parse(txtSaldoEstoque.Text);
                var movimento = decimal.Parse(txtQtdeMovimento.Text);
                var tipoMovimentacao = rbMovimentoEntrada.Checked ? "E" : "S";

                if (tipoMovimentacao == "E")
                {
                    if (saldoAtual == 0 && movimento == 0)
                    {
                        MessageBox.Show("O valor a ser movimentado informado não irá alterar o saldo de estoque do produto!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtQtdeMovimento.Focus();
                    }
                }
                else
                {
                    if (saldoAtual - movimento < 0)
                    {
                        MessageBox.Show("O valor a ser movimentado informado é maior que o saldo de estoque atual do produto!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtQtdeMovimento.Focus();
                    }
                }
            }
        }
    }
}
