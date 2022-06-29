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
                txtFornecedorNomeRazao.Enabled = true;
                txtFornecedorCnpjCpf.Enabled = true;
                txtFornecedorRgIe.Enabled = true;
                txtFornecedorEmail.Enabled = true;
                txtFornecedorEndereco.Enabled = true;
                txtFornecedorNumero.Enabled = true;
                txtFornecedorBairro.Enabled = true;
                txtFornecedorComplemento.Enabled = true;
                txtIdCidade.Enabled = true;
                txtFornecedorCidade.Enabled = false;
                txtFornecedorEstado.Enabled = false;
                txtFornecedorCep.Enabled = true;
                txtFornecedorTelefone.Enabled = true;
                txtFornecedorCelular.Enabled = true;
                cbAtivo.Enabled = true;
                cbAtivo.Checked = true;
            }
            else
            {
                txtFornecedorId.Enabled = false;
                txtFornecedorNomeRazao.Enabled = false;
                txtFornecedorCnpjCpf.Enabled = false;
                txtFornecedorRgIe.Enabled = false;
                txtFornecedorEmail.Enabled = false;
                txtFornecedorEndereco.Enabled = false;
                txtFornecedorNumero.Enabled = false;
                txtFornecedorBairro.Enabled = false;
                txtFornecedorComplemento.Enabled = false;
                txtIdCidade.Enabled = false;
                txtFornecedorCidade.Enabled = false;
                txtFornecedorEstado.Enabled = false;
                txtFornecedorCep.Enabled = false;
                txtFornecedorTelefone.Enabled = false;
                txtFornecedorCelular.Enabled = false;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
            }
        }

        private void LimpaComponentes()
        {
            txtFornecedorId.Text = string.Empty;
            txtFornecedorNomeRazao.Text = string.Empty;
            txtFornecedorCnpjCpf.Text = string.Empty;
            txtFornecedorRgIe.Text = string.Empty;
            txtFornecedorEmail.Text = string.Empty;
            txtFornecedorEndereco.Text = string.Empty;
            txtFornecedorNumero.Text = string.Empty;
            txtFornecedorBairro.Text = string.Empty;
            txtFornecedorComplemento.Text = string.Empty;
            txtIdCidade.Text = string.Empty;
            txtFornecedorCidade.Text = string.Empty;
            txtFornecedorEstado.Text = string.Empty;
            txtFornecedorCep.Text = string.Empty;
            txtFornecedorTelefone.Text = string.Empty;
            txtFornecedorCelular.Text = string.Empty;
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

            if (txtFornecedorNomeRazao.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage += "O Campo Razão Social não foi preenchido corretamente! \n";
            }

            if (txtFornecedorCnpjCpf.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O campo CNPJ/CPF não foi preenchido corretamente! \n";
            }

            if (txtFornecedorRgIe.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo da Inscrição Estadual não foi preenchido corretamente! \n";
            }

            if (txtFornecedorEmail.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo E-mail não foi preenchido corretamente! \n";
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

            if (txtFornecedorBairro.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Bairro não foi preenchido corretamente! \n";
            }

            if(txtFornecedorComplemento.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Complemento não foi preenchido corretamente! \n";
            }

            if (txtIdCidade.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo IdCidade não foi preenchido corretamente! \n";
            }

            if(txtFornecedorCep.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo CEP não foi preenchido corretamente! \n";
            }

            if(txtFornecedorTelefone.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Telefone não foi preenchido corretamente! \n";
            }

            if (txtFornecedorCelular.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMessage = "* O Campo Celular não foi preenchido corretamente! \n";
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

            if (txtFornecedorNomeRazao.CanFocus)
            {
                txtFornecedorNomeRazao.Focus();
                txtFornecedorNomeRazao.Select(txtFornecedorNomeRazao.Text.Length, 0);
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

                Fornecedor.idfornecedor = Int32.Parse(txtFornecedorId.Text);
                Fornecedor.nomerazao = txtFornecedorNomeRazao.Text;
                Fornecedor.cpfcnpj = txtFornecedorCnpjCpf.Text;
                Fornecedor.rgie = txtFornecedorRgIe.Text;
                Fornecedor.email = txtFornecedorEmail.Text;
                Fornecedor.endereco = txtFornecedorEndereco.Text;
                Fornecedor.numero = txtFornecedorNumero.Text;
                Fornecedor.bairro = txtFornecedorBairro.Text;
                Fornecedor.complemento = txtFornecedorComplemento.Text;
                Fornecedor.idcidade = Int32.Parse(txtIdCidade.Text);
                Fornecedor.telefone = txtFornecedorTelefone.Text;
                Fornecedor.celular = txtFornecedorCelular.Text;
                Fornecedor.cep = txtFornecedorCep.Text;
                Fornecedor.ativo = cbAtivo.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    Ccontrole.Adicionar(Fornecedor);
                else if (MenuStatus == MStatus.Editando)
                    Ccontrole.Editar(Fornecedor);
                else if (MenuStatus == MStatus.Excluindo)
                    Ccontrole.Excluir(Fornecedor.idfornecedor);

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

                txtFornecedorId.Text = Pesquisa.PesqFornecedor.idfornecedor.ToString();
                txtFornecedorNomeRazao.Text = Pesquisa.PesqFornecedor.nomerazao;
                txtFornecedorCnpjCpf.Text = Pesquisa.PesqFornecedor.cpfcnpj;
                txtFornecedorRgIe.Text = Pesquisa.PesqFornecedor.rgie;
                txtFornecedorEmail.Text = Pesquisa.PesqFornecedor.email;
                txtFornecedorEndereco.Text = Pesquisa.PesqFornecedor.endereco;
                txtFornecedorNumero.Text = Pesquisa.PesqFornecedor.numero;
                txtFornecedorBairro.Text = Pesquisa.PesqFornecedor.bairro;
                txtFornecedorComplemento.Text = Pesquisa.PesqFornecedor.complemento;
                txtIdCidade.Text = Pesquisa.PesqFornecedor.idcidade.ToString();
                txtFornecedorCidade.Text = Pesquisa.PesqFornecedor.cidadenome;
                txtFornecedorEstado.Text = Pesquisa.PesqFornecedor.estadosigla;
                txtFornecedorCep.Text = Pesquisa.PesqFornecedor.cep;
                txtFornecedorTelefone.Text = Pesquisa.PesqFornecedor.telefone;
                txtFornecedorCelular.Text = Pesquisa.PesqFornecedor.celular;
                cbAtivo.Checked = Pesquisa.PesqFornecedor.ativo;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtFornecedorNomeRazao.CanFocus)
            {
                txtFornecedorNomeRazao.Focus();
                txtFornecedorNomeRazao.Select(0, txtFornecedorNomeRazao.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormRecFornecedorPesquisa Pesquisa = new FormRecFornecedorPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlFornecedor(false);

                txtFornecedorId.Text = Pesquisa.PesqFornecedor.idfornecedor.ToString();
                txtFornecedorNomeRazao.Text = Pesquisa.PesqFornecedor.nomerazao;
                txtFornecedorCnpjCpf.Text = Pesquisa.PesqFornecedor.cpfcnpj;
                txtFornecedorRgIe.Text = Pesquisa.PesqFornecedor.rgie;
                txtFornecedorEmail.Text = Pesquisa.PesqFornecedor.email;
                txtFornecedorEndereco.Text = Pesquisa.PesqFornecedor.endereco;
                txtFornecedorNumero.Text = Pesquisa.PesqFornecedor.numero;
                txtFornecedorBairro.Text = Pesquisa.PesqFornecedor.bairro;
                txtFornecedorComplemento.Text = Pesquisa.PesqFornecedor.complemento;
                txtIdCidade.Text = Pesquisa.PesqFornecedor.idcidade.ToString();
                txtFornecedorCidade.Text = Pesquisa.PesqFornecedor.cidadenome;
                txtFornecedorEstado.Text = Pesquisa.PesqFornecedor.estadosigla;
                txtFornecedorCep.Text = Pesquisa.PesqFornecedor.cep;
                txtFornecedorTelefone.Text = Pesquisa.PesqFornecedor.telefone;
                txtFornecedorCelular.Text = Pesquisa.PesqFornecedor.celular;
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

                txtFornecedorId.Text = Pesquisa.PesqFornecedor.idfornecedor.ToString();
                txtFornecedorNomeRazao.Text = Pesquisa.PesqFornecedor.nomerazao;
                txtFornecedorCnpjCpf.Text = Pesquisa.PesqFornecedor.cpfcnpj;
                txtFornecedorRgIe.Text = Pesquisa.PesqFornecedor.rgie;
                txtFornecedorEmail.Text = Pesquisa.PesqFornecedor.email;
                txtFornecedorEndereco.Text = Pesquisa.PesqFornecedor.endereco;
                txtFornecedorNumero.Text = Pesquisa.PesqFornecedor.numero;
                txtFornecedorBairro.Text = Pesquisa.PesqFornecedor.bairro;
                txtFornecedorComplemento.Text = Pesquisa.PesqFornecedor.complemento;
                txtIdCidade.Text = Pesquisa.PesqFornecedor.idcidade.ToString();
                txtFornecedorCidade.Text = Pesquisa.PesqFornecedor.cidadenome;
                txtFornecedorEstado.Text = Pesquisa.PesqFornecedor.estadosigla;
                txtFornecedorCep.Text = Pesquisa.PesqFornecedor.cep;
                txtFornecedorTelefone.Text = Pesquisa.PesqFornecedor.telefone;
                txtFornecedorCelular.Text = Pesquisa.PesqFornecedor.celular;
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

        private void txtFornecedorNomeRazao_TextChanged(object sender, EventArgs e)
        {
            if (txtFornecedorNomeRazao.Text != String.Empty && txtFornecedorNomeRazao.Enabled)
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

        private void txtIdCidade_TextChanged(object sender, EventArgs e)
        {
            if(txtIdCidade.Text != "")
            {
                var cidadeid = Int32.Parse(txtIdCidade.Text);
                CidadeController Controle = new CidadeController();

                if (Controle.ExisteCidadeId(cidadeid))
                {
                    txtFornecedorCidade.Text = Controle.GetCidade(cidadeid).nome;
                    txtFornecedorEstado.Text = Controle.GetCidade(cidadeid).sigla;
                }
                else
                {
                    txtFornecedorCidade.Text = String.Empty;
                    txtFornecedorEstado.Text = String.Empty;
                }
            }
            else
            {
                txtFornecedorCidade.Text = String.Empty;
                txtFornecedorEstado.Text = String.Empty;
            }
        }

        private void txtIdCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormCidadePesquisa Pesq = new FormCidadePesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtIdCidade.Text = Pesq.PesqCidade.idcidade.ToString();
                    txtFornecedorCidade.Text = Pesq.PesqCidade.nome;
                    txtFornecedorEstado.Text = Pesq.PesqCidade.sigla;
                }
            }
        }
    }
}
