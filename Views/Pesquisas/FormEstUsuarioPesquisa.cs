using LaPizza.Controllers;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormEstUsuarioPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public UsuarioModel usuario;
        public FormEstUsuarioPesquisa()
        {
            InitializeComponent();
            txtPesquisa.Focus();
            CarregaLista();
        }
        private void CarregaLista()
        {
            UsuarioController controle = new UsuarioController();
            List<UsuarioModel> lista = controle.GetUsuarioLista();

            dbGridPesquisa.DataSource = lista;
            dbGridPesquisa.Refresh();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioController controle = new UsuarioController();
            int id = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;
            usuario = controle.GetUsuario(id);
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            dbGridPesquisa.DataSource = null;

            UsuarioController controle = new UsuarioController();
            List<UsuarioModel> lista = controle.GetUsuarioPesquisaGrid(txtPesquisa.Text);

            dbGridPesquisa.DataSource = lista;
            dbGridPesquisa.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
