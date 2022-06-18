using LaPizza.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormLogin : LaPizza.Views.FormBaseCadastros
    {
        private System.Windows.Forms.Panel Panel;
        public FormLogin()
        {
            InitializeComponent();
        }
        public FormLogin(System.Windows.Forms.Panel panel)
        {
            Panel = panel;
            HabilitaAcaoMenu(false, false, false, false);
            HabilitaAcao(TipoAcao.Confirmar, true);            
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            int aux = usuarioController.ValidaLogin(txtUsuario.Text, txtSenha.Text);

            //Tudo certo
            if (aux == 1)
            {
                MessageBox.Show("Seja bem vindo(a)");
                Panel.Visible = true;

                this.Dispose();
                this.Close();
            }
            else
            {
                if (aux == 2)
                {
                    MessageBox.Show("Campo Usuário não preenchido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                }
                else if (aux == 3)
                {
                    MessageBox.Show("Campo Senha não preenchido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else if (aux == 4)
                    MessageBox.Show("Campo Usuário ou Senha incorretos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                btnMostrarSenha.BackgroundImage = LaPizza.Properties.Resources.olhoAberto;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnMostrarSenha.BackgroundImage = LaPizza.Properties.Resources.olhoFechado;
            }
        }
    }
}
