using LaPizza.Controllers;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
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

        private void LimpaComponentes()
        {
            txtClienteId.Text = string.Empty;
            txtClienteNome.Text = string.Empty;
            txtClienteSobrenome.Text = string.Empty;
            txtClienteCpf.Text = string.Empty;
            txtClienteRg.Text = string.Empty;
            txtClienteEmail.Text = string.Empty;
            txtClienteTelefone.Text = string.Empty;
            txtClienteEndereco.Text = string.Empty;
            txtClienteNumero.Text = string.Empty;
            txtClienteBairro.Text = string.Empty;
            txtClienteCidade.Text = string.Empty;
            txtClienteEstado.Text = string.Empty;
            cbAtivo.Checked = true;
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlCliente(false);
            HabilitarAcoesIniciais();
        }

        private bool TodosOsCamposPreenchidos()
        {
            bool todosPreenchidos = true;
            int idCliente = 0;
            string auxMessage = string.Empty;
            string cpfCliente = txtClienteCpf.Text;

            ClienteController clienteControle = new ClienteController();

            if(txtClienteId.Text != string.Empty)
                idCliente = Convert.ToInt32(txtClienteId.Text);

            if(txtClienteNome.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage += "O Campo Nome não foi preenchido corretamente! \n";
            }

            if(txtClienteSobrenome.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "O campo Sobrenome não foi preenchido corretamente! \n";
            }

            if (!clienteControle.ExisteClienteCpf(cpfCliente))
            {
                todosPreenchidos = false;
                auxMessage += "* O Campo CPF não foi preenchido corretamente! \n";
            }

            if (auxMessage != string.Empty)
                MessageBox.Show(auxMessage, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return todosPreenchidos;
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlCliente(true);

            ClienteController CliControle = new ClienteController();
            txtClienteId.Text = CliControle.GetProximoId().ToString();

            if (txtClienteNome.CanFocus)
            {
                txtClienteNome.Focus();
                txtClienteNome.Select(txtClienteNome.Text.Length, 0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaComponentes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (TodosOsCamposPreenchidos())
            {
                ProdutoController Ccontrole = new ProdutoController();
                ClienteDto Cliente = new ClienteDto();

                Cliente.id = Int32.Parse(txtClienteId.Text);
                Cliente.nome = txtClienteNome.Text;
                Cliente.sobrenome = txtClienteSobrenome.Text;
                Cliente.cpf = txtClienteCpf.Text;



                LimpaComponentes();
                HabilitarComponentesPnlCliente(false);
                HabilitarAcoesIniciais();
            }

        }
    }
}
