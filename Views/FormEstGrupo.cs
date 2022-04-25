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
    public partial class FormEstGrupo : LaPizza.Views.FormBaseCadastros
    {
        public FormEstGrupo()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                cbAtivo.Enabled = true;
                txtGrupoDescricao.Enabled = true;
            }
            else
            {
                txtGrupoId.Enabled = false;
                cbAtivo.Enabled = false;
                txtGrupoDescricao.Enabled = false;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            GrupoController gControle = new GrupoController();
            txtGrupoId.Text = gControle.GetProximoId().ToString();

            if (txtGrupoDescricao.CanFocus)
            {
                txtGrupoDescricao.Focus();
                txtGrupoDescricao.Select(txtGrupoDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormEstGrupoPesquisa Pesq = new FormEstGrupoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {

                txtGrupoId.Text = Pesq.PGrupo.id.ToString();
                txtGrupoDescricao.Text = Pesq.PGrupo.descricao;
                cbAtivo.Checked = Pesq.PGrupo.ativo;

                HabilitarComponentesPnlPrincipal(true);
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtGrupoDescricao.CanFocus)
            {
                txtGrupoDescricao.Focus();
                txtGrupoDescricao.Select(txtGrupoDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {

            FormEstGrupoPesquisa Pesq = new FormEstGrupoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtGrupoId.Text = Pesq.PGrupo.id.ToString();
                txtGrupoDescricao.Text = Pesq.PGrupo.descricao;
                cbAtivo.Checked = Pesq.PGrupo.ativo;

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
            FormEstGrupoPesquisa Pesq = new FormEstGrupoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtGrupoId.Text = Pesq.PGrupo.id.ToString();
                txtGrupoDescricao.Text = Pesq.PGrupo.descricao;
                cbAtivo.Checked = Pesq.PGrupo.ativo;

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
            txtGrupoId.Text = string.Empty;
            txtGrupoDescricao.Text = string.Empty;
            cbAtivo.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtGrupoDescricao.Text == string.Empty)
            {
                MessageBox.Show("É necessário informar uma descrição");
                txtGrupoDescricao.Focus();
            }
            else
            {
                GrupoController Pcontrole = new GrupoController();
                GrupoDto Grupo = new GrupoDto();

                Grupo.id = Int32.Parse(txtGrupoId.Text);
                Grupo.descricao = txtGrupoDescricao.Text;
                Grupo.ativo = cbAtivo.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    Pcontrole.Adicionar(Grupo);
                else if (MenuStatus == MStatus.Editando)
                    Pcontrole.Editar(Grupo);
                else if (MenuStatus == MStatus.Excluindo)
                    Pcontrole.Excluir(Grupo.id);
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
            if (txtGrupoDescricao.Text != String.Empty && txtGrupoDescricao.Enabled == true)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
