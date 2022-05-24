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
    public partial class FrmEstUsuario : LaPizza.Views.FormBaseCadastros
    {
        private int IdAux = 0;
        public FrmEstUsuario()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }
        public void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                lpTextNomeComp.Enabled = true;
                lpTextUsuario.Enabled = true;
                lpTextSenha.Enabled = true;
                lpTextRepSenha.Enabled = true;
                rbAtivo.Enabled = true;
                rbInativo.Enabled = true;
                rbInativo.Checked = false;
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                lpTextNomeComp.Enabled = false;
                lpTextUsuario.Enabled = false;
                lpTextSenha.Enabled = false;
                lpTextRepSenha.Enabled = false;
                rbAtivo.Enabled = false;
                rbInativo.Enabled = false;
                rbInativo.Checked = false;
            }
        }
        private bool ValidaCampos()
        {
            if (lpTextNomeComp.Text == "")
            {
                MessageBox.Show("Campo nome completo não preenchido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lpTextNomeComp.Focus();
                return false;
            }
            if (lpTextUsuario.Text == "")
            {
                MessageBox.Show("Campo usuário não preenchido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lpTextUsuario.Focus();
                return false;
            }
            if (lpTextSenha.Text == "")
            {
                MessageBox.Show("Campo senha não preenchido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lpTextSenha.Focus();
                return false;
            }
            if (lpTextRepSenha.Text == "")
            {
                MessageBox.Show("Campo repetir senha não preenchido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lpTextRepSenha.Focus();
                return false;
            }
            if (!rbAtivo.Checked && !rbInativo.Checked)
            {
                MessageBox.Show("Selecione Ativo/Inativo", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbAtivo.Focus();
                return false;
            }
            if (lpTextSenha.Text != "" && lpTextRepSenha.Text != ""
                && lpTextSenha.Text != lpTextRepSenha.Text)
            {
                MessageBox.Show("Campo repetir senha não condiz com a senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lpTextRepSenha.Focus();
                return false;
            }
            return true;
        }
       
        private void LimpaComponentes()
        {
            lpTextNomeComp.Text = "";
            lpTextUsuario.Text = "";
            lpTextSenha.Text = "";
            lpTextRepSenha.Text = "";
        }
        private void CancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void rbAtivo_Click(object sender, EventArgs e)
        {
            rbAtivo.Checked = true;
            rbInativo.Checked = false;
        }

        private void rbInativo_Click(object sender, EventArgs e)
        {
            rbInativo.Checked = true;
            rbAtivo.Checked = false;
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);
            HabilitaAcao(TipoAcao.Confirmar, true);
            if (lpTextNomeComp.CanFocus)
            {
                lpTextNomeComp.Focus();
                lpTextNomeComp.Select(0, lpTextNomeComp.Text.Length);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    UsuarioController Controle = new UsuarioController();
                    UsuarioDto Usuario = new UsuarioDto();

                    Usuario.nome = lpTextNomeComp.Text;
                    Usuario.usuario = lpTextUsuario.Text;
                    Usuario.senha = lpTextSenha.Text;
                    if (rbAtivo.Checked)
                    {
                        Usuario.ativo = true;
                    }
                    else
                    {
                        Usuario.ativo = false;
                    }

                    if (MenuStatus == MStatus.Adicionando)
                    {
                        if (!Controle.UsuarioJaExiste(lpTextUsuario.Text))
                        {
                            Controle.AdicionarUsuario(Usuario);
                            LimpaComponentes();
                            HabilitarComponentesPnlPrincipal(false);
                            HabilitarAcoesIniciais();
                        }
                        else
                        {
                            HabilitarComponentesPnlPrincipal(true);
                            lpTextUsuario.Focus();
                        }  
                    } 
                    else if (MenuStatus == MStatus.Editando)
                    {
                        Usuario.id = IdAux;
                        Controle.EditarUsuario(Usuario);
                        LimpaComponentes();
                        HabilitarComponentesPnlPrincipal(false);
                        HabilitarAcoesIniciais();
                    }
                    else if (MenuStatus == MStatus.Excluindo)
                    {
                        Controle.Excluir(IdAux);
                        LimpaComponentes();
                        HabilitarComponentesPnlPrincipal(false);
                        HabilitarAcoesIniciais();
                    }
                }
                else
                {
                    HabilitarComponentesPnlPrincipal(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcaoEditar_Click_1(object sender, EventArgs e)
        {
            FormEstUsuarioPesquisa Pesquisa = new FormEstUsuarioPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(true);

                IdAux = Pesquisa.usuario.id;
                lpTextNomeComp.Text = Pesquisa.usuario.nome;
                lpTextUsuario.Text = Pesquisa.usuario.usuario;
                lpTextSenha.Text = Pesquisa.usuario.senha;
                lpTextRepSenha.Text = Pesquisa.usuario.senha;
                rbAtivo.Checked = Pesquisa.usuario.ativo;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (lpTextNomeComp.CanFocus)
            {
                lpTextNomeComp.Focus();
                lpTextNomeComp.Select(0, lpTextNomeComp.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click_1(object sender, EventArgs e)
        {

            FormEstUsuarioPesquisa Pesquisa = new FormEstUsuarioPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                lpTextNomeComp.Text = Pesquisa.usuario.nome;
                lpTextUsuario.Text = Pesquisa.usuario.usuario;
                lpTextSenha.Text = Pesquisa.usuario.senha;
                lpTextRepSenha.Text = Pesquisa.usuario.senha;
                rbAtivo.Checked = Pesquisa.usuario.ativo;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (lpTextNomeComp.CanFocus)
            {
                lpTextNomeComp.Focus();
                lpTextNomeComp.Select(0, lpTextNomeComp.Text.Length);
            }
        }

        private void btnAcaoExcluir_Click_1(object sender, EventArgs e)
        {
            FormEstUsuarioPesquisa Pesquisa = new FormEstUsuarioPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                IdAux = Pesquisa.usuario.id;
                lpTextNomeComp.Text = Pesquisa.usuario.nome;
                lpTextUsuario.Text = Pesquisa.usuario.usuario;
                lpTextSenha.Text = Pesquisa.usuario.senha;
                lpTextRepSenha.Text = Pesquisa.usuario.senha;
                rbAtivo.Checked = Pesquisa.usuario.ativo;

                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (lpTextNomeComp.CanFocus)
            {
                lpTextNomeComp.Focus();
                lpTextNomeComp.Select(0, lpTextNomeComp.Text.Length);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            CancelaOperacao();
        }
    }
}
