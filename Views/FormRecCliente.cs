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
                txtClienteNomeRazao.Enabled = true;
                txtClienteCpfCnpj.Enabled = true;
                txtClienteRgIe.Enabled = true;
                txtClienteEmail.Enabled = true;
                txtClienteEndereco.Enabled = true;
                txtClienteNumero.Enabled = true;
                txtClienteBairro.Enabled = true;
                txtClienteComplemento.Enabled = true;
                txtIdCidade.Enabled = true;
                txtClienteCidade.Enabled = true;
                txtClienteEstado.Enabled = true;
                txtClienteCep.Enabled = true;
                txtClienteCelular.Enabled = true;
                txtClienteTelefone.Enabled = true;
                cbAtivo.Enabled = true;
                cbAtivo.Checked = true;
            }
            else
            {
                txtClienteId.Enabled = false;
                txtClienteNomeRazao.Enabled = true;
                txtClienteCpfCnpj.Enabled = true;
                txtClienteRgIe.Enabled = true;
                txtClienteEmail.Enabled = true;
                txtClienteEndereco.Enabled = true;
                txtClienteNumero.Enabled = true;
                txtClienteBairro.Enabled = true;
                txtClienteComplemento.Enabled = true;
                txtIdCidade.Enabled = true;
                txtClienteCidade.Enabled = true;
                txtClienteEstado.Enabled = true;
                txtClienteCep.Enabled = true;
                txtClienteCelular.Enabled = true;
                txtClienteTelefone.Enabled = true;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }
        }

        private void LimpaComponentes()
        {
            txtClienteId.Text = string.Empty;
            txtClienteNomeRazao.Text = string.Empty;
            txtClienteCpfCnpj.Text = string.Empty;
            txtClienteRgIe.Text = string.Empty;
            txtClienteEmail.Text = string.Empty;
            txtClienteEndereco.Text = string.Empty;
            txtClienteNumero.Text = string.Empty;
            txtClienteBairro.Text = string.Empty;
            txtClienteComplemento.Text = string.Empty;
            txtIdCidade.Text = string.Empty;
            txtClienteCidade.Text = string.Empty;
            txtClienteEstado.Text = string.Empty;
            txtClienteCep.Text = string.Empty;
            txtClienteTelefone.Text = string.Empty;
            txtClienteCelular.Text = string.Empty;
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

            if (txtClienteNomeRazao.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage += "O Campo Nome / Razão não foi preenchido corretamente! \n";
            }

            if(txtClienteCpfCnpj.Text == String.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O campo CPF / CNPJ não foi preenchido corretamente! \n";
            }

            if(txtClienteRgIe.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo RG / Insc. Estadual não foi preenchido corretamente! \n";
            }
            
            if(txtClienteEmail.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo E-mail não foi preenchido corretamente! \n";
            }

            if(txtClienteEndereco.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "*O Campo Endereço não foi preenchido corretamente! \n";
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

            if(txtClienteComplemento.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Complemento não foi preenchido corretamente! \n";
            }

            if(txtIdCidade.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo IdCidade não foi preenchido corretamente! \n";
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

            if(txtClienteCep.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo CEP não foi preenchido corretamente! \n";
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

            if (txtClienteNomeRazao.CanFocus)
            {
                txtClienteNomeRazao.Focus();
                txtClienteNomeRazao.Select(txtClienteNomeRazao.Text.Length, 0);
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
                ClienteDB Cliente = new ClienteDB();

                Cliente.idcliente = Int32.Parse(txtClienteId.Text);
                Cliente.nomerazao = txtClienteNomeRazao.Text;
                Cliente.cpfcnpj = txtClienteCpfCnpj.Text;
                Cliente.rgie = txtClienteRgIe.Text;
                Cliente.email = txtClienteEmail.Text;
                Cliente.endereco = txtClienteEndereco.Text;
                Cliente.numero = txtClienteNumero.Text;
                Cliente.idcidade = Int32.Parse(txtIdCidade.Text);
                Cliente.bairro = txtClienteBairro.Text;
                Cliente.complemento = txtClienteComplemento.Text;
                Cliente.telefone = txtClienteTelefone.Text;
                Cliente.celular = txtClienteCelular.Text;
                Cliente.ativo = cbAtivo.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    Ccontrole.Adicionar(Cliente);
                else if (MenuStatus == MStatus.Editando)
                    Ccontrole.Editar(Cliente);
                else if (MenuStatus == MStatus.Excluindo)
                    Ccontrole.Excluir(Cliente.idcliente);

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

                txtClienteId.Text = Pesquisa.PesqCliente.idcliente.ToString();
                txtClienteNomeRazao.Text = Pesquisa.PesqCliente.nomerazao;
                txtClienteCpfCnpj.Text = Pesquisa.PesqCliente.cpfcnpj;
                txtClienteRgIe.Text = Pesquisa.PesqCliente.rgie;
                txtClienteEmail.Text = Pesquisa.PesqCliente.email;
                txtClienteEndereco.Text = Pesquisa.PesqCliente.endereco;
                txtClienteNumero.Text = Pesquisa.PesqCliente.numero;
                txtClienteBairro.Text = Pesquisa.PesqCliente.bairro;
                txtClienteComplemento.Text = Pesquisa.PesqCliente.complemento;
                txtIdCidade.Text = Pesquisa.PesqCliente.idcidade.ToString();
                txtClienteCelular.Text = Pesquisa.PesqCliente.celular;
                txtClienteTelefone.Text = Pesquisa.PesqCliente.telefone;
                cbAtivo.Checked = Pesquisa.PesqCliente.ativo;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtClienteNomeRazao.CanFocus)
            {
                txtClienteNomeRazao.Focus();
                txtClienteNomeRazao.Select(0, txtClienteNomeRazao.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormRecClientePesquisa Pesquisa = new FormRecClientePesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlCliente(false);

                txtClienteId.Text = Pesquisa.PesqCliente.idcliente.ToString();
                txtClienteNomeRazao.Text = Pesquisa.PesqCliente.nomerazao;
                txtClienteCpfCnpj.Text = Pesquisa.PesqCliente.cpfcnpj;
                txtClienteRgIe.Text = Pesquisa.PesqCliente.rgie;
                txtClienteEmail.Text = Pesquisa.PesqCliente.email;
                txtClienteCelular.Text = Pesquisa.PesqCliente.celular;
                txtClienteTelefone.Text = Pesquisa.PesqCliente.telefone;
                txtClienteEndereco.Text = Pesquisa.PesqCliente.endereco;
                txtClienteComplemento.Text = Pesquisa.PesqCliente.complemento;
                txtClienteNumero.Text = Pesquisa.PesqCliente.numero;
                txtIdCidade.Text = Pesquisa.PesqCliente.idcidade.ToString();
                txtClienteCep.Text = Pesquisa.PesqCliente.cep;
                txtClienteBairro.Text = Pesquisa.PesqCliente.bairro;
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

                txtClienteId.Text = Pesquisa.PesqCliente.idcliente.ToString();
                txtClienteNomeRazao.Text = Pesquisa.PesqCliente.nomerazao;
                txtClienteCpfCnpj.Text = Pesquisa.PesqCliente.cpfcnpj;
                txtClienteRgIe.Text = Pesquisa.PesqCliente.rgie;
                txtClienteEmail.Text = Pesquisa.PesqCliente.email;
                txtClienteEndereco.Text = Pesquisa.PesqCliente.endereco;
                txtClienteNumero.Text = Pesquisa.PesqCliente.numero;
                txtClienteBairro.Text = Pesquisa.PesqCliente.bairro;
                txtClienteComplemento.Text = Pesquisa.PesqCliente.complemento;
                txtIdCidade.Text = Pesquisa.PesqCliente.idcidade.ToString();
                txtClienteCelular.Text = Pesquisa.PesqCliente.celular;
                txtClienteTelefone.Text = Pesquisa.PesqCliente.telefone;
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
            if (txtClienteNomeRazao.Text != String.Empty && txtClienteNomeRazao.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }

        private void txtClienteCpfCnpj_Leave(object sender, EventArgs e)
        {
            ClienteController clienteControle = new ClienteController();

            if (clienteControle.ExisteClienteCpf(txtClienteCpfCnpj.Text))
            {
                MessageBox.Show("* Já existe um Cliente com o CPF/CNPJ informado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtClienteCpfCnpj.CanFocus)
                {
                    txtClienteCpfCnpj.Focus();
                }
            }
        }
    }
}
