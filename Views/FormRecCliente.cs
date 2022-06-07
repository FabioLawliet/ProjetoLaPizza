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
                txtClienteId.Enabled = false;
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


            ClienteController clienteControle = new ClienteController();

            if (txtClienteId.Text != string.Empty)
                idCliente = Convert.ToInt32(txtClienteId.Text);

            if (txtClienteNome.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage += "O Campo Nome não foi preenchido corretamente! \n";
            }

            if (txtClienteSobrenome.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "O campo Sobrenome não foi preenchido corretamente! \n";
            }

            /*if (clienteControle.ExisteClienteCpf(txtClienteCpf.Text))
            {
                todosPreenchidos = false;
                auxMessage += "* O Campo CPF já existe! \n";
            }*/

            if(txtClienteRg.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo RG não foi preenchido corretamente! \n";
            }
            
            if(txtClienteEmail.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo E-mail não foi preenchido corretamente! \n";
            }

            if(txtClienteNumero.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Número não foi preenchido corretamente! \n";
            }

            if(txtClienteBairro.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Bairro não foi preenchido corretamente! \n";
            }

            if(txtClienteCidade.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Cidade não foi preenchido corretamente! \n";
            }

            if(txtClienteEstado.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Estado não foi preenchido corretamente! \n";
            }


            if (auxMessage != string.Empty)
                MessageBox.Show(auxMessage, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return todosPreenchidos;
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            ClienteController CliControle = new ClienteController();
            txtClienteId.Text = CliControle.GetProximoId().ToString();

            HabilitarComponentesPnlCliente(true);

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
                ClienteController Ccontrole = new ClienteController();
                ClienteDto Cliente = new ClienteDto();

                Cliente.id = Int32.Parse(txtClienteId.Text);
                Cliente.nome = txtClienteNome.Text;
                Cliente.sobrenome = txtClienteSobrenome.Text;
                Cliente.cpf = txtClienteCpf.Text;
                Cliente.rg = txtClienteRg.Text;
                Cliente.email = txtClienteEmail.Text;
                Cliente.telefone = txtClienteTelefone.Text;
                Cliente.endereco = txtClienteEndereco.Text;
                Cliente.numero = txtClienteNumero.Text;
                Cliente.cidade = txtClienteCidade.Text;
                Cliente.bairro = txtClienteBairro.Text;
                Cliente.estado = txtClienteEstado.Text;
                Cliente.ativo = cbAtivo.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    Ccontrole.Adicionar(Cliente);
                else if (MenuStatus == MStatus.Editando)
                    Ccontrole.Editar(Cliente);
                else if (MenuStatus == MStatus.Excluindo)
                    Ccontrole.Excluir(Cliente.id);

                LimpaComponentes();
                HabilitarComponentesPnlCliente(false);
                HabilitarAcoesIniciais();
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormRecClientePesquisa Pesquisa = new FormRecClientePesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCliente(true);

                txtClienteId.Text = Pesquisa.PesqCliente.id.ToString();
                txtClienteNome.Text = Pesquisa.PesqCliente.nome;
                txtClienteSobrenome.Text = Pesquisa.PesqCliente.sobrenome;
                txtClienteCpf.Text = Pesquisa.PesqCliente.cpf;
                txtClienteCpf.Enabled = false;
                txtClienteRg.Text = Pesquisa.PesqCliente.rg;
                txtClienteEmail.Text = Pesquisa.PesqCliente.email;
                txtClienteTelefone.Text = Pesquisa.PesqCliente.telefone;
                txtClienteEndereco.Text = Pesquisa.PesqCliente.endereco;
                txtClienteNumero.Text = Pesquisa.PesqCliente.numero;
                txtClienteBairro.Text = Pesquisa.PesqCliente.bairro;
                txtClienteCidade.Text = Pesquisa.PesqCliente.cidade;
                txtClienteEstado.Text = Pesquisa.PesqCliente.estado;
                cbAtivo.Checked = Pesquisa.PesqCliente.ativo;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtClienteNome.CanFocus)
            {
                txtClienteNome.Focus();
                txtClienteNome.Select(0, txtClienteNome.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormRecClientePesquisa Pesquisa = new FormRecClientePesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCliente(false);

                txtClienteId.Text = Pesquisa.PesqCliente.id.ToString();
                txtClienteNome.Text = Pesquisa.PesqCliente.nome;
                txtClienteSobrenome.Text = Pesquisa.PesqCliente.sobrenome;
                txtClienteCpf.Text = Pesquisa.PesqCliente.cpf;
                txtClienteRg.Text = Pesquisa.PesqCliente.rg;
                txtClienteEmail.Text = Pesquisa.PesqCliente.email;
                txtClienteTelefone.Text = Pesquisa.PesqCliente.telefone;
                txtClienteEndereco.Text = Pesquisa.PesqCliente.endereco;
                txtClienteNumero.Text = Pesquisa.PesqCliente.numero;
                txtClienteBairro.Text = Pesquisa.PesqCliente.bairro;
                txtClienteCidade.Text = Pesquisa.PesqCliente.cidade;
                txtClienteEstado.Text = Pesquisa.PesqCliente.estado;
                cbAtivo.Checked = Pesquisa.PesqCliente.ativo;

            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormRecClientePesquisa Pesquisa = new FormRecClientePesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCliente(false);

                txtClienteId.Text = Pesquisa.PesqCliente.id.ToString();
                txtClienteNome.Text = Pesquisa.PesqCliente.nome;
                txtClienteSobrenome.Text = Pesquisa.PesqCliente.sobrenome;
                txtClienteCpf.Text = Pesquisa.PesqCliente.cpf;
                txtClienteRg.Text = Pesquisa.PesqCliente.rg;
                txtClienteEmail.Text = Pesquisa.PesqCliente.email;
                txtClienteTelefone.Text = Pesquisa.PesqCliente.telefone;
                txtClienteEndereco.Text = Pesquisa.PesqCliente.endereco;
                txtClienteNumero.Text = Pesquisa.PesqCliente.numero;
                txtClienteBairro.Text = Pesquisa.PesqCliente.bairro;
                txtClienteCidade.Text = Pesquisa.PesqCliente.cidade;
                txtClienteEstado.Text = Pesquisa.PesqCliente.estado;
                cbAtivo.Checked = Pesquisa.PesqCliente.ativo;

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

        private void txtClienteNome_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteNome.Text != String.Empty && txtClienteNome.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
