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
    public partial class FormCidade : LaPizza.Views.FormBaseCadastros
    {
        public FormCidade()
        {
            InitializeComponent();
            HabilitarComponentesPnlCidade(false);
            this.MaximumSize = new System.Drawing.Size(500, 227);
            this.MinimumSize = new System.Drawing.Size(500, 227);
        }

        private void HabilitarComponentesPnlCidade(bool Ativa)
        {
            if (Ativa)
            {
                txtCidadeId.Enabled = false;
                txtCidadeNome.Enabled = true;
                txtCidadeIdEstado.Enabled = true;
                txtCidadeNomeEstado.Enabled = false;
            }
            else
            {
                txtCidadeId.Enabled = false;
                txtCidadeNome.Enabled = false;
                txtCidadeIdEstado.Enabled = false;
                txtCidadeNomeEstado.Enabled = false;
            }
        }

        private void LimpaComponentes()
        {
            txtCidadeId.Text = string.Empty;
            txtCidadeNome.Text = string.Empty;
            txtCidadeIdEstado.Text = string.Empty;
            txtCidadeNomeEstado.Text = string.Empty;
        }
        private void CancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlCidade(false);
            HabilitarAcoesIniciais();
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            CidadeController Controle = new CidadeController();
            txtCidadeId.Text = Controle.GetProximoId().ToString();

            HabilitarComponentesPnlCidade(true);

            if (txtCidadeNome.CanFocus)
            {
                txtCidadeNome.Focus();
                txtCidadeNome.Select(txtCidadeNome.Text.Length, 0);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormCidadePesquisa Pesquisa = new FormCidadePesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCidade(true);

                txtCidadeId.Text = Pesquisa.PesqCidade.idcidade.ToString();
                txtCidadeNome.Text = Pesquisa.PesqCidade.nome;
                txtCidadeIdEstado.Text = Pesquisa.PesqCidade.idestado.ToString();
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (txtCidadeNome.CanFocus)
            {
                txtCidadeNome.Focus();
                txtCidadeNome.Select(0, txtCidadeNome.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormCidadePesquisa Pesq = new FormCidadePesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCidade(false);

                txtCidadeId.Text = Pesq.PesqCidade.idcidade.ToString();
                txtCidadeNome.Text = Pesq.PesqCidade.nome;
                txtCidadeIdEstado.Text = Pesq.PesqCidade.idestado.ToString();
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
            FormCidadePesquisa Pesquisa = new FormCidadePesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCidade(false);

                txtCidadeId.Text = Pesquisa.PesqCidade.idcidade.ToString();
                txtCidadeNome.Text = Pesquisa.PesqCidade.nome;
                txtCidadeIdEstado.Text = Pesquisa.PesqCidade.idestado.ToString();

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
            if (txtCidadeNome.Text == string.Empty)
            {
                MessageBox.Show("O campo Nome não foi preenchido!");
                txtCidadeNome.Focus();
            }
            else
            {
                CidadeController Controle = new CidadeController();
                CidadeDB Cidade = new CidadeDB();

                try
                {
                    Cidade.idcidade = Int32.Parse(txtCidadeId.Text);
                    Cidade.nome = txtCidadeNome.Text;
                    Cidade.idestado = Int32.Parse(txtCidadeIdEstado.Text);

                    if (MenuStatus == MStatus.Adicionando)
                        Controle.Adicionar(Cidade);
                    else if (MenuStatus == MStatus.Editando)
                        Controle.Editar(Cidade);
                    else if (MenuStatus == MStatus.Excluindo)
                        Controle.Excluir(Cidade.idcidade);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimpaComponentes();
            HabilitarComponentesPnlCidade(false);
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

        private void txtCidadeNome_TextChanged(object sender, EventArgs e)
        {
            if (txtCidadeNome.Text != String.Empty && txtCidadeNome.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }

        private void txtCidadeIdEstado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstadoPesquisa Pesq = new FormEstadoPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtCidadeIdEstado.Text = Pesq.PesqEstado.idestado.ToString();
                    txtCidadeNomeEstado.Text = Pesq.PesqEstado.nome;
                }
            }
        }

        private void txtCidadeIdEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtCidadeIdEstado.Text != "")
            {
                EstadoController Controle = new EstadoController();

                var id = Int32.Parse(txtCidadeIdEstado.Text);

                if (Controle.ExisteEstado(id))
                    txtCidadeNomeEstado.Text = Controle.GetEstado(id).nome;
                else
                {
                    txtCidadeNomeEstado.Text = String.Empty;
                }
            }
            else
            {
                 txtCidadeNomeEstado.Text = String.Empty;
            }
        }
    }
}
