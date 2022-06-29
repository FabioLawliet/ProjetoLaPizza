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
    public partial class FormVenFormaPagamento : LaPizza.Views.FormBaseCadastros
    {
        public FormVenFormaPagamento()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
            this.MaximumSize = new System.Drawing.Size(500, 306);
            this.MinimumSize = new System.Drawing.Size(500, 306);
        }
        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtPagamentoDescricao.Enabled = true;
                cbAtiva.Checked = true;
                cbAtiva.Enabled = true;
                cbPermiteDinheiro.Checked = false;
                cbPermiteDinheiro.Enabled = true;
                cbPermitePix.Checked = false;
                cbPermitePix.Enabled = true;
                cbPermiteCartaoDebito.Checked = false;
                cbPermiteCartaoDebito.Enabled = true;
                cbPermiteCartaoCredito.Checked = false;
                cbPermiteCartaoCredito.Enabled = true;
                cbPermiteCrediario.Checked = false;
                cbPermiteCrediario.Enabled = true;
                cbPermiteCheque.Checked = false;
                cbPermiteCheque.Enabled = true;
            }
            else
            {
                txtPagamentoId.Enabled = false;
                txtPagamentoDescricao.Enabled = false;
                cbAtiva.Checked = true;
                cbAtiva.Enabled = false;
                cbPermiteDinheiro.Enabled = false;
                cbPermitePix.Enabled = false;
                cbPermiteCartaoDebito.Enabled = false;
                cbPermiteCartaoCredito.Enabled = false;
                cbPermiteCrediario.Enabled = false;
                cbPermiteCheque.Enabled = false;
            }
        }

        private void LimpaComponentes()
        {
            txtPagamentoId.Text = string.Empty;
            txtPagamentoDescricao.Text = string.Empty;
            cbAtiva.Checked = true;
        }

        private void CancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtPagamentoDescricao.Text == string.Empty)
            {
                MessageBox.Show("O campo descrição não foi preenchido!");
                txtPagamentoDescricao.Focus();
            }
            else
            {
                FormaPagamentoController Controle = new FormaPagamentoController();
                FormaPagamentoDB Pagamento = new FormaPagamentoDB();

                try
                {
                    Pagamento.idformapagamento = Int32.Parse(txtPagamentoId.Text);
                    Pagamento.descricao = txtPagamentoDescricao.Text;
                    Pagamento.ativa = cbAtiva.Checked;
                    Pagamento.permitedinheiro = cbPermiteDinheiro.Checked;
                    Pagamento.permitepix = cbPermitePix.Checked;
                    Pagamento.permitecartaodeb = cbPermiteCartaoDebito.Checked;
                    Pagamento.permitecartaocred = cbPermiteCartaoCredito.Checked;
                    Pagamento.permitecrediario = cbPermiteCrediario.Checked;
                    Pagamento.permitecheque = cbPermiteCheque.Checked;

                    if (MenuStatus == MStatus.Adicionando)
                        Controle.Adicionar(Pagamento);
                    else if (MenuStatus == MStatus.Editando)
                        Controle.Editar(Pagamento);
                    else if (MenuStatus == MStatus.Excluindo)
                        Controle.Excluir(Pagamento.idformapagamento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelaOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            FormaPagamentoController Controle = new FormaPagamentoController();
            txtPagamentoId.Text = Controle.GetProximoId().ToString();

            HabilitarComponentesPnlPrincipal(true);

            if (txtPagamentoDescricao.CanFocus)
            {
                txtPagamentoDescricao.Focus();
                txtPagamentoDescricao.Select(0, txtPagamentoDescricao.Text.Length);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormVenFormaPagamentoPesquisa Pesquisa = new FormVenFormaPagamentoPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(true);

                txtPagamentoId.Text = Pesquisa.PesqFormaPagamento.idformapagamento.ToString();
                txtPagamentoDescricao.Text = Pesquisa.PesqFormaPagamento.descricao;
                cbAtiva.Checked = Pesquisa.PesqFormaPagamento.ativa;
                cbPermiteDinheiro.Checked = Pesquisa.PesqFormaPagamento.permitedinheiro;
                cbPermitePix.Checked = Pesquisa.PesqFormaPagamento.permitepix;
                cbPermiteCartaoDebito.Checked = Pesquisa.PesqFormaPagamento.permitecartaodeb;
                cbPermiteCartaoCredito.Checked = Pesquisa.PesqFormaPagamento.permitecartaocred;
                cbPermiteCrediario.Checked = Pesquisa.PesqFormaPagamento.permitecrediario;
                cbPermiteCheque.Checked = Pesquisa.PesqFormaPagamento.permitecheque;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (txtPagamentoDescricao.CanFocus)
            {
                txtPagamentoDescricao.Focus();
                txtPagamentoDescricao.Select(0, txtPagamentoDescricao.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormVenFormaPagamentoPesquisa Pesquisa = new FormVenFormaPagamentoPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                txtPagamentoId.Text = Pesquisa.PesqFormaPagamento.idformapagamento.ToString();
                txtPagamentoDescricao.Text = Pesquisa.PesqFormaPagamento.descricao;
                cbAtiva.Checked = Pesquisa.PesqFormaPagamento.ativa;
                cbPermiteDinheiro.Checked = Pesquisa.PesqFormaPagamento.permitedinheiro;
                cbPermitePix.Checked = Pesquisa.PesqFormaPagamento.permitepix;
                cbPermiteCartaoDebito.Checked = Pesquisa.PesqFormaPagamento.permitecartaodeb;
                cbPermiteCartaoCredito.Checked = Pesquisa.PesqFormaPagamento.permitecartaocred;
                cbPermiteCrediario.Checked = Pesquisa.PesqFormaPagamento.permitecrediario;
                cbPermiteCheque.Checked = Pesquisa.PesqFormaPagamento.permitecheque;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (txtPagamentoDescricao.CanFocus)
            {
                txtPagamentoDescricao.Focus();
                txtPagamentoDescricao.Select(0, txtPagamentoDescricao.Text.Length);
            }
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormVenFormaPagamentoPesquisa Pesquisa = new FormVenFormaPagamentoPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                txtPagamentoId.Text = Pesquisa.PesqFormaPagamento.idformapagamento.ToString();
                txtPagamentoDescricao.Text = Pesquisa.PesqFormaPagamento.descricao;
                cbAtiva.Checked = Pesquisa.PesqFormaPagamento.ativa;
                cbPermiteDinheiro.Checked = Pesquisa.PesqFormaPagamento.permitedinheiro;
                cbPermitePix.Checked = Pesquisa.PesqFormaPagamento.permitepix;
                cbPermiteCartaoDebito.Checked = Pesquisa.PesqFormaPagamento.permitecartaodeb;
                cbPermiteCartaoCredito.Checked = Pesquisa.PesqFormaPagamento.permitecartaocred;
                cbPermiteCrediario.Checked = Pesquisa.PesqFormaPagamento.permitecrediario;
                cbPermiteCheque.Checked = Pesquisa.PesqFormaPagamento.permitecheque;

                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();
        }

        private void txtPagamentoDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtPagamentoDescricao.Text != String.Empty && txtPagamentoDescricao.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
