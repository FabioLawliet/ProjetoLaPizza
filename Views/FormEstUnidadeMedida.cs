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
    public partial class FormEstUnidadeMedida : LaPizza.Views.FormBaseCadastros
    {
        public FormEstUnidadeMedida()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
            this.MaximumSize = new System.Drawing.Size(500, 227);
            this.MinimumSize = new System.Drawing.Size(500, 227);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtUnidadeMedidaDescricao.Enabled = true;
                txtUnidadeMedidaSigla.Enabled = true;
                cbAtivo.Enabled = true;
                cbAtivo.Checked = true;
                
            }
            else
            {
                txtUnidadeMedidaId.Enabled = false;
                txtUnidadeMedidaDescricao.Enabled = false;
                txtUnidadeMedidaSigla.Enabled = false;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            UnidadeMedidaController controle = new UnidadeMedidaController();
            txtUnidadeMedidaId.Text = controle.GetProximoId().ToString();

            if (txtUnidadeMedidaDescricao.CanFocus)
            {
                txtUnidadeMedidaDescricao.Focus();
                txtUnidadeMedidaDescricao.Select(txtUnidadeMedidaDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormEstUnidadeMedidaPesquisa Pesq = new FormEstUnidadeMedidaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtUnidadeMedidaId.Text = Pesq.PesqUnidadeMedida.idunidmedida.ToString();
                txtUnidadeMedidaDescricao.Text = Pesq.PesqUnidadeMedida.descricao;
                txtUnidadeMedidaSigla.Text = Pesq.PesqUnidadeMedida.sigla;
                cbAtivo.Checked = Pesq.PesqUnidadeMedida.ativa;

                HabilitarComponentesPnlPrincipal(true);
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtUnidadeMedidaDescricao.CanFocus)
            {
                txtUnidadeMedidaDescricao.Focus();
                txtUnidadeMedidaDescricao.Select(txtUnidadeMedidaDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {

            FormEstUnidadeMedidaPesquisa Pesq = new FormEstUnidadeMedidaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtUnidadeMedidaId.Text = Pesq.PesqUnidadeMedida.idunidmedida.ToString();
                txtUnidadeMedidaDescricao.Text = Pesq.PesqUnidadeMedida.descricao;
                txtUnidadeMedidaSigla.Text = Pesq.PesqUnidadeMedida.sigla;
                cbAtivo.Checked = Pesq.PesqUnidadeMedida.ativa;

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
            FormEstUnidadeMedidaPesquisa Pesq = new FormEstUnidadeMedidaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtUnidadeMedidaId.Text = Pesq.PesqUnidadeMedida.idunidmedida.ToString();
                txtUnidadeMedidaDescricao.Text = Pesq.PesqUnidadeMedida.descricao;
                txtUnidadeMedidaSigla.Text = Pesq.PesqUnidadeMedida.sigla;
                cbAtivo.Checked = Pesq.PesqUnidadeMedida.ativa;

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
            txtUnidadeMedidaId.Text = string.Empty;
            txtUnidadeMedidaDescricao.Text = string.Empty;
            txtUnidadeMedidaSigla.Text = string.Empty;
            cbAtivo.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtUnidadeMedidaDescricao.Text == string.Empty)
            {
                MessageBox.Show("É necessário informar uma descrição");
                txtUnidadeMedidaDescricao.Focus();
            }
            else
            {
                UnidadeMedidaController controle = new UnidadeMedidaController();
                UnidadeMedidaDB unidade = new UnidadeMedidaDB();

                unidade.idunidmedida = Int32.Parse(txtUnidadeMedidaId.Text);
                unidade.descricao = txtUnidadeMedidaDescricao.Text;
                unidade.sigla = txtUnidadeMedidaSigla.Text;
                unidade.ativa = cbAtivo.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    controle.Adicionar(unidade);
                else if (MenuStatus == MStatus.Editando)
                    controle.Editar(unidade);
                else if (MenuStatus == MStatus.Excluindo)
                    controle.Excluir(unidade.idunidmedida);
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

        private void txtUnidadeMedidaDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtUnidadeMedidaDescricao.Text != String.Empty && txtUnidadeMedidaDescricao.Enabled == true)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
