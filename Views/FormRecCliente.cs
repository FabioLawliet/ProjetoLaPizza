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
    public partial class FormRecCliente : LaPizza.Views.FormBaseCadastros
    {
        public FormRecCliente()
        {
            InitializeComponent();
            HabilitarComponentesPnlCliente(false);
        }

        private void HabilitarComponentesPnlCliente(bool Ativa)
        {
            if (Ativa)
            {
                txtClienteId.Enabled = true;
                txtClienteNome.Enabled = true;
                txtClienteSobrenome.Enabled = true;
                txtClienteCpf.Enabled = true;
                txtClienteRg.Enabled = true;
                txtClienteEmail.Enabled = true;
                txtClienteTelefone.Enabled = true;
                txtClienteEndereco.Enabled = true;
                txtClienteNumero.Enabled = true;
                txtClienteBairro.Enabled = true;
                txtClienteCidade.Enabled = true;
                txtClienteEstado.Enabled = true;
                cbAtivo.Enabled = true;
                cbAtivo.Checked = true;
            }
            else
            {
                txtClienteId.Enabled = false;
                txtClienteNome.Enabled = false;
                txtClienteSobrenome.Enabled = false;
                txtClienteCpf.Enabled = false;
                txtClienteRg.Enabled = false;
                txtClienteEmail.Enabled = false;
                txtClienteTelefone.Enabled = false;
                txtClienteEndereco.Enabled = false;
                txtClienteNumero.Enabled = false;
                txtClienteBairro.Enabled = false;
                txtClienteCidade.Enabled = false;
                txtClienteEstado.Enabled = false;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlCliente(true);
        }
    }
}
