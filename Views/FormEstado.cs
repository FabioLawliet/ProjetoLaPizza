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
    public partial class FormEstado : LaPizza.Views.FormBaseCadastros
    {
        public FormEstado()
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
                txtEstadoId.Enabled = false;
                txtEstadoNome.Enabled = true;
                txtEstadoSigla.Enabled = true;
            }
            else
            {
                txtEstadoId.Enabled = false;
                txtEstadoNome.Enabled = false;
                txtEstadoSigla.Enabled = false;
            }
        }

        private void LimpaComponentes()
        {
            txtEstadoId.Text = string.Empty;
            txtEstadoNome.Text = string.Empty;
            txtEstadoSigla.Text = string.Empty;
        }
        private void CancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            EstadoController Controle = new EstadoController();
            txtEstadoId.Text = Controle.GetProximoId().ToString();

            HabilitarComponentesPnlPrincipal(true);

            if (txtEstadoNome.CanFocus)
            {
                txtEstadoNome.Focus();
                txtEstadoNome.Select(0, txtEstadoNome.Text.Length);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormEstadoPesquisa Pesquisa = new FormEstadoPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(true);

                txtEstadoId.Text = Pesquisa.PesqEstado.idestado.ToString();
                txtEstadoNome.Text = Pesquisa.PesqEstado.nome;
                txtEstadoSigla.Text = Pesquisa.PesqEstado.sigla;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (txtEstadoNome.CanFocus)
            {
                txtEstadoNome.Focus();
                txtEstadoNome.Select(0, txtEstadoNome.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormEstadoPesquisa Pesq = new FormEstadoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                txtEstadoId.Text = Pesq.PesqEstado.idestado.ToString();
                txtEstadoNome.Text = Pesq.PesqEstado.nome;
                txtEstadoSigla.Text = Pesq.PesqEstado.sigla;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormEstadoPesquisa Pesquisa = new FormEstadoPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                txtEstadoId.Text = Pesquisa.PesqEstado.idestado.ToString();
                txtEstadoNome.Text = Pesquisa.PesqEstado.nome;
                txtEstadoSigla.Text = Pesquisa.PesqEstado.sigla;

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtEstadoNome.Text == string.Empty)
            {
                MessageBox.Show("O campo Nome não foi preenchido!");
                txtEstadoNome.Focus();
            }
            else
            {
                EstadoController Controle = new EstadoController();
                EstadoDB Estado = new EstadoDB();

                try
                {
                    Estado.idestado = Int32.Parse(txtEstadoId.Text);
                    Estado.nome = txtEstadoNome.Text;
                    Estado.sigla = txtEstadoSigla.Text;

                    if (MenuStatus == MStatus.Adicionando)
                        Controle.Adicionar(Estado);
                    else if (MenuStatus == MStatus.Editando)
                        Controle.Editar(Estado);
                    else if (MenuStatus == MStatus.Excluindo)
                        Controle.Excluir(Estado.idestado);
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

        private void txtEstadoNome_TextChanged(object sender, EventArgs e)
        {
            if (txtEstadoNome.Text != String.Empty && txtEstadoNome.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
