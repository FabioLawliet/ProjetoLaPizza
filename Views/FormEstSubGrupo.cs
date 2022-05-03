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
    public partial class FormEstSubgrupo : LaPizza.Views.FormBaseCadastros
    {
        public FormEstSubgrupo()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }
        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtGrupoId.Enabled = true;
                cbAtivo.Checked = true;
            }
            else
            {
                txtGrupoId.Enabled = false;
                txtGrupoDescricao.Enabled = false;
                txtSubgrupoId.Enabled = false;
                txtSubgrupoDescricao.Enabled = false;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            if (txtGrupoId.CanFocus)
            {
                txtGrupoId.Focus();
                txtGrupoId.Select(txtGrupoId.Text.Length, 0);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            if (txtGrupoId.CanFocus)
            {
                txtGrupoId.Focus();
                txtGrupoId.Select(txtGrupoId.Text.Length, 0);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            if (txtGrupoId.CanFocus)
            {
                txtGrupoId.Focus();
                txtGrupoId.Select(txtGrupoId.Text.Length, 0);
            }
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            if (txtGrupoId.CanFocus)
            {
                txtGrupoId.Focus();
                txtGrupoId.Select(txtGrupoId.Text.Length, 0);
            }

        }

        private void LimpaComponentes()
        {
            txtGrupoId.Text = string.Empty;
            txtGrupoDescricao.Text = string.Empty;
            txtSubgrupoId.Text = string.Empty;
            txtSubgrupoDescricao.Text = string.Empty;
            cbAtivo.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtSubgrupoDescricao.Text == string.Empty)
            {
                MessageBox.Show("É necessário informar uma descrição para o subgrupo!");
                txtSubgrupoDescricao.Focus();
            }
            else
            {
                try
                {
                    SubgrupoController controle = new SubgrupoController();
                    SubgrupoDto subgrupo = new SubgrupoDto();

                    subgrupo.idsubgrupo = Int32.Parse(txtSubgrupoId.Text);
                    subgrupo.descricao = txtSubgrupoDescricao.Text;
                    subgrupo.idgrupo = Int32.Parse(txtGrupoId.Text);
                    subgrupo.ativo = cbAtivo.Checked;

                    if (MenuStatus == MStatus.Adicionando)
                        controle.Adicionar(subgrupo);
                    else if (MenuStatus == MStatus.Editando)
                        controle.Editar(subgrupo);
                    else if (MenuStatus == MStatus.Excluindo)
                        controle.Excluir(subgrupo.idgrupo, subgrupo.idsubgrupo);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
        private void CancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void txtGrupoId_TextChanged(object sender, EventArgs e)
        {
            if (txtGrupoId.Text != "")
            {
                GrupoController controleGrupo = new GrupoController();
                SubgrupoController controleSubgrupo = new SubgrupoController();

                var idGrupo = Int32.Parse(txtGrupoId.Text);

                if (controleGrupo.ExisteGrupoId(idGrupo))
                {
                    txtGrupoDescricao.Text = controleGrupo.GetGrupo(idGrupo).descricao;

                    switch (MenuStatus)
                    {
                        case MStatus.Adicionando:
                            txtSubgrupoId.Text = controleSubgrupo.GetProximoId(idGrupo).ToString();
                            txtSubgrupoDescricao.Enabled = true;
                            cbAtivo.Enabled = true;
                            break;

                        case MStatus.Editando:
                            txtSubgrupoId.Enabled = true;
                            txtSubgrupoDescricao.Enabled = false;
                            cbAtivo.Enabled = false;
                            break;

                        case MStatus.Consultando:
                            txtSubgrupoId.Enabled = true;
                            txtSubgrupoDescricao.Enabled = false;
                            cbAtivo.Enabled = false;
                            break;

                        case MStatus.Excluindo:
                            txtSubgrupoId.Enabled = true;
                            txtSubgrupoDescricao.Enabled = false;
                            cbAtivo.Enabled = false;
                            break;
                    }
                }
                else
                {
                    txtGrupoDescricao.Text = string.Empty;
                    txtSubgrupoId.Text = string.Empty;
                    txtSubgrupoDescricao.Text = String.Empty;

                    txtSubgrupoId.Enabled = false;
                    txtSubgrupoDescricao.Enabled = false;
                }
            }
            else
            {
                LimpaComponentes();
                txtSubgrupoId.Enabled = false;
                txtSubgrupoDescricao.Enabled = false;
            }
        }

        private void txtGrupoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstGrupoPesquisa Pesq = new FormEstGrupoPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtGrupoId.Text = Pesq.PesqGrupo.id.ToString();
                    txtGrupoDescricao.Text = Pesq.PesqGrupo.descricao;
                }

                if (txtSubgrupoDescricao.CanFocus)
                    txtSubgrupoDescricao.Focus();    
            }
        }
        private void txtSubgrupoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstSubgrupoPesquisa Pesq = new FormEstSubgrupoPesquisa(Int32.Parse(txtGrupoId.Text));
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtSubgrupoId.Text = Pesq.PesqSubgrupo.idsubgrupo.ToString();
                    txtSubgrupoDescricao.Text = Pesq.PesqSubgrupo.descricao;

                    if (txtSubgrupoDescricao.CanFocus)
                        txtSubgrupoDescricao.Focus();
                }
            }
        }

        private void txtSubgrupoId_TextChanged(object sender, EventArgs e)
        {
            if (txtSubgrupoId.Text != "")
            {
                SubgrupoController controle = new SubgrupoController();

                var idGrupo = Int32.Parse(txtGrupoId.Text);
                var idSubgrupo = Int32.Parse(txtSubgrupoId.Text);

                if (controle.ExisteSubgrupo(idGrupo, idSubgrupo))
                {
                    txtSubgrupoDescricao.Text = controle.GetSubgrupo(idGrupo, idSubgrupo).descricao;

                    switch (MenuStatus)
                    {
                        case MStatus.Editando:
                            txtSubgrupoDescricao.Enabled = true;
                            cbAtivo.Enabled = true;
                            break;

                        case MStatus.Consultando:
                            txtSubgrupoDescricao.Enabled = false;
                            cbAtivo.Enabled = false;
                            break;

                        case MStatus.Excluindo:
                            txtSubgrupoDescricao.Enabled = false;
                            cbAtivo.Enabled = false;
                            break;
                    }
                }
                else
                {
                    txtSubgrupoDescricao.Enabled = false;
                    txtSubgrupoDescricao.Text = String.Empty;
                    cbAtivo.Enabled = false;
                    cbAtivo.Checked = true;
                }
            }
            else
            {
                txtSubgrupoDescricao.Enabled = false;
                txtSubgrupoDescricao.Text = String.Empty;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }

        }

        private void txtSubgrupoDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtSubgrupoDescricao.Text != String.Empty && txtSubgrupoDescricao.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else if(txtSubgrupoDescricao.Text != String.Empty && MenuStatus == MStatus.Excluindo)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
