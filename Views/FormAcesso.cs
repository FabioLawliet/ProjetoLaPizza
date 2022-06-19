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
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            int aux = usuarioController.ValidaLogin(txtUsuario.Text, txtSenha.Text);

            //Tudo certo
            if(aux == 1)
            {                
                MessageBox.Show("Seja bem vindo(a)");
                DialogResult = DialogResult.Yes;
                Close();
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
            }          
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void pnlMostrarSenha_Click(object sender, System.EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                pnlMostrarSenha.BackgroundImage = LaPizza.Properties.Resources.SenhaVisivel;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                pnlMostrarSenha.BackgroundImage = LaPizza.Properties.Resources.SenhaOculta;
            }
        }
    }
}
