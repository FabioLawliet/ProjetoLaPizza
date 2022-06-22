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
    public partial class FormRecFornecedor : LaPizza.Views.FormBaseCadastros
    {
        public FormRecFornecedor()
        {
            InitializeComponent();
            HabilitarComponentesPnlFornecedor(false);
        }

        private void HabilitarComponentesPnlFornecedor(bool Ativa)
        {
            if (Ativa)
            {
                txtFornecedorId.Enabled = false;
                txtFornecedorRazaoSocial.Enabled = true;
                txtFornecedorNomeFantasia.Enabled = true;
                txtFornecedorCnpjCpf.Enabled = true;
                txtFornecedorInscricaoEstadual.Enabled = true;
                txtFornecedorEmail.Enabled = true;
                txtFornecedorTelefone.Enabled = true;
                txtFornecedorEndereco.Enabled = true;
                txtFornecedorNumero.Enabled = true;
                txtFornecedorBairro.Enabled = true;
                txtFornecedorCidade.Enabled = true;
                txtFornecedorEstado.Enabled = true;
                cbAtivo.Enabled = true;
                cbAtivo.Checked = true;
            }
            else
            {
                txtFornecedorId.Enabled = false;
                txtFornecedorRazaoSocial.Enabled = false;
                txtFornecedorNomeFantasia.Enabled = false;
                txtFornecedorCnpjCpf.Enabled = false;
                txtFornecedorInscricaoEstadual.Enabled = false;
                txtFornecedorEmail.Enabled = false;
                txtFornecedorTelefone.Enabled = false;
                txtFornecedorEndereco.Enabled = false;
                txtFornecedorNumero.Enabled = false;
                txtFornecedorBairro.Enabled = false;
                txtFornecedorCidade.Enabled = false;
                txtFornecedorEstado.Enabled = false;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }
        }

        private void LimpaComponentes()
        {
            txtFornecedorId.Text = string.Empty;
            txtFornecedorRazaoSocial.Text = string.Empty;
            txtFornecedorNomeFantasia.Text = string.Empty;
            txtFornecedorCnpjCpf.Text = string.Empty;
            txtFornecedorInscricaoEstadual.Text = string.Empty;
            txtFornecedorEmail.Text = string.Empty;
            txtFornecedorTelefone.Text = string.Empty;
            txtFornecedorEndereco.Text = string.Empty;
            txtFornecedorNumero.Text = string.Empty;
            txtFornecedorBairro.Text = string.Empty;
            txtFornecedorCidade.Text = string.Empty;
            txtFornecedorEstado.Text = string.Empty;
            cbAtivo.Checked = true;
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlFornecedor(false);
            HabilitarAcoesIniciais();
        }

        private bool TodosOsCamposPreenchidos()
        {
            bool todosPreenchidos = true;
            int idFornecedor = 0;
            string auxMessage = string.Empty;


            FornecedorController clienteControle = new FornecedorController();

            if (txtFornecedorId.Text != string.Empty)
                idFornecedor = Convert.ToInt32(txtFornecedorId.Text);

            if (txtFornecedorRazaoSocial.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage += "O Campo Razão Social não foi preenchido corretamente! \n";
            }

            if (txtFornecedorNomeFantasia.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "O campo Nome Fantasia não foi preenchido corretamente! \n";
            }

            if (txtFornecedorCnpjCpf.Text == String.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O campo CNPJ/CPF não foi preenchido corretamente! \n";
            }

            if (txtFornecedorInscricaoEstadual.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo da Inscrição Estadual não foi preenchido corretamente! \n";
            }

            if (txtFornecedorTelefone.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Telefone não foi preenchido corretamente! \n";
            }

            if (txtFornecedorEndereco.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Endereço não foi preenchido corretamente! \n";
            }

            if (txtFornecedorNumero.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Número não foi preenchido corretamente! \n";
            }

            if (txtFornecedorEstado.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Estado não foi preenchido corretamente! \n";
            }

            if (txtFornecedorCidade.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Cidade não foi preenchido corretamente! \n";
            }

            if (txtFornecedorBairro.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Bairro não foi preenchido corretamente! \n";
            }

            if (txtFornecedorEmail.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo E-mail não foi preenchido corretamente! \n";
            }


            if (auxMessage != string.Empty)
                MessageBox.Show(auxMessage, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return todosPreenchidos;
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            FornecedorController FornControle = new FornecedorController();
            txtFornecedorId.Text = FornControle.GetProximoId().ToString();

            HabilitarComponentesPnlFornecedor(true);

            if (txtFornecedorRazaoSocial.CanFocus)
            {
                txtFornecedorRazaoSocial.Focus();
                txtFornecedorRazaoSocial.Select(txtFornecedorRazaoSocial.Text.Length, 0);
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
                FornecedorController Ccontrole = new FornecedorController();
                FornecedorDB Fornecedor = new FornecedorDB();

                Fornecedor.id = Int32.Parse(txtFornecedorId.Text);
                Fornecedor.razaosocial = txtFornecedorRazaoSocial.Text;
                Fornecedor.nomefantasia = txtFornecedorNomeFantasia.Text;
                Fornecedor.cnpjcpf = txtFornecedorCnpjCpf.Text;
                Fornecedor.inscricaoestadual = txtFornecedorInscricaoEstadual.Text;
                Fornecedor.telefone = txtFornecedorTelefone.Text;
                Fornecedor.endereco = txtFornecedorEndereco.Text;
                Fornecedor.numero = txtFornecedorNumero.Text;
                Fornecedor.estado = txtFornecedorEstado.Text;
                Fornecedor.cidade = txtFornecedorCidade.Text;
                Fornecedor.bairro = txtFornecedorBairro.Text;
                Fornecedor.email = txtFornecedorEmail.Text;
                Fornecedor.ativo = cbAtivo.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    Ccontrole.Adicionar(Fornecedor);
                else if (MenuStatus == MStatus.Editando)
                    Ccontrole.Editar(Fornecedor);
                else if (MenuStatus == MStatus.Excluindo)
                    Ccontrole.Excluir(Fornecedor.id);

                LimpaComponentes();
                HabilitarComponentesPnlFornecedor(false);
                HabilitarAcoesIniciais();
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormRecFornecedorPesquisa Pesquisa = new FormRecFornecedorPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlFornecedor(true);

                txtFornecedorId.Text = Pesquisa.PesqFornecedor.id.ToString();
                txtFornecedorRazaoSocial.Text = Pesquisa.PesqFornecedor.razaosocial;
                txtFornecedorNomeFantasia.Text = Pesquisa.PesqFornecedor.nomefantasia;
                txtFornecedorCnpjCpf.Text = Pesquisa.PesqFornecedor.cnpjcpf;
                txtFornecedorInscricaoEstadual.Text = Pesquisa.PesqFornecedor.inscricaoestadual;
                txtFornecedorTelefone.Text = Pesquisa.PesqFornecedor.telefone;
                txtFornecedorEndereco.Text = Pesquisa.PesqFornecedor.endereco;
                txtFornecedorNumero.Text = Pesquisa.PesqFornecedor.numero;
                txtFornecedorEstado.Text = Pesquisa.PesqFornecedor.estado;
                txtFornecedorCidade.Text = Pesquisa.PesqFornecedor.cidade;
                txtFornecedorBairro.Text = Pesquisa.PesqFornecedor.bairro;
                txtFornecedorEmail.Text = Pesquisa.PesqFornecedor.email;
                cbAtivo.Checked = Pesquisa.PesqFornecedor.ativo;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtFornecedorRazaoSocial.CanFocus)
            {
                txtFornecedorRazaoSocial.Focus();
                txtFornecedorRazaoSocial.Select(0, txtFornecedorRazaoSocial.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormRecFornecedorPesquisa Pesquisa = new FormRecFornecedorPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlFornecedor(false);

                txtFornecedorId.Text = Pesquisa.PesqFornecedor.id.ToString();
                txtFornecedorRazaoSocial.Text = Pesquisa.PesqFornecedor.razaosocial;
                txtFornecedorNomeFantasia.Text = Pesquisa.PesqFornecedor.nomefantasia;
                txtFornecedorCnpjCpf.Text = Pesquisa.PesqFornecedor.cnpjcpf;
                txtFornecedorInscricaoEstadual.Text = Pesquisa.PesqFornecedor.inscricaoestadual;
                txtFornecedorTelefone.Text = Pesquisa.PesqFornecedor.telefone;
                txtFornecedorEndereco.Text = Pesquisa.PesqFornecedor.endereco;
                txtFornecedorNumero.Text = Pesquisa.PesqFornecedor.numero;
                txtFornecedorEstado.Text = Pesquisa.PesqFornecedor.estado;
                txtFornecedorCidade.Text = Pesquisa.PesqFornecedor.cidade;
                txtFornecedorBairro.Text = Pesquisa.PesqFornecedor.bairro;
                txtFornecedorEmail.Text = Pesquisa.PesqFornecedor.email;
                cbAtivo.Checked = Pesquisa.PesqFornecedor.ativo;

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
            FormRecFornecedorPesquisa Pesquisa = new FormRecFornecedorPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlFornecedor(false);

                txtFornecedorId.Text = Pesquisa.PesqFornecedor.id.ToString();
                txtFornecedorRazaoSocial.Text = Pesquisa.PesqFornecedor.razaosocial;
                txtFornecedorNomeFantasia.Text = Pesquisa.PesqFornecedor.nomefantasia;
                txtFornecedorCnpjCpf.Text = Pesquisa.PesqFornecedor.cnpjcpf;
                txtFornecedorInscricaoEstadual.Text = Pesquisa.PesqFornecedor.inscricaoestadual;
                txtFornecedorTelefone.Text = Pesquisa.PesqFornecedor.telefone;
                txtFornecedorEndereco.Text = Pesquisa.PesqFornecedor.endereco;
                txtFornecedorNumero.Text = Pesquisa.PesqFornecedor.numero;
                txtFornecedorEstado.Text = Pesquisa.PesqFornecedor.estado;
                txtFornecedorCidade.Text = Pesquisa.PesqFornecedor.cidade;
                txtFornecedorBairro.Text = Pesquisa.PesqFornecedor.bairro;
                txtFornecedorEmail.Text = Pesquisa.PesqFornecedor.email;
                cbAtivo.Checked = Pesquisa.PesqFornecedor.ativo;

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

        private void txtFornecedorRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            if (txtFornecedorRazaoSocial.Text != String.Empty && txtFornecedorRazaoSocial.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }

        private void txtFornecedorCnpjCpf_Leave(object sender, EventArgs e)
        {
            FornecedorController fornecedorControle = new FornecedorController();

            if (fornecedorControle.ExisteFonecedorCnpjCpf(txtFornecedorCnpjCpf.Text))
            {
                MessageBox.Show("* Já existe um Fornecedor com o CPF/CNPJ informado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtFornecedorCnpjCpf.CanFocus)
                {
                    txtFornecedorCnpjCpf.Focus();
                }
            }
        }
    }
}
