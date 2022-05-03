using System;
using System.Windows.Forms;
using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;

namespace LaPizza.Views
{
    public partial class FormEstMarca : LaPizza.Views.FormBaseCadastros
    {

        public FormEstMarca()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtMarcaDescricao.Enabled = true;
                cbAtiva.Checked = true;
                cbAtiva.Enabled = true;
            }
            else
            {
                txtMarcaId.Enabled = false;
                txtMarcaDescricao.Enabled = false;
                cbAtiva.Checked = true;
                cbAtiva.Enabled = false;
            }
        }

        private void LimpaComponentes()
        {
            txtMarcaId.Text = string.Empty;
            txtMarcaDescricao.Text = string.Empty;
            cbAtiva.Checked = true;
        }

        private void CancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            MarcaController Controle = new MarcaController();
            txtMarcaId.Text = Controle.GetProximoId().ToString();

            HabilitarComponentesPnlPrincipal(true);

            if (txtMarcaDescricao.CanFocus)
            {
                txtMarcaDescricao.Focus();
                txtMarcaDescricao.Select(0, txtMarcaDescricao.Text.Length);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormEstMarcaPesquisa Pesquisa = new FormEstMarcaPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(true);

                txtMarcaId.Text = Pesquisa.PesqMarca.id.ToString();
                txtMarcaDescricao.Text = Pesquisa.PesqMarca.descricao;
                cbAtiva.Checked = Pesquisa.PesqMarca.ativa;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (txtMarcaDescricao.CanFocus)
            {
                txtMarcaDescricao.Focus();
                txtMarcaDescricao.Select(0, txtMarcaDescricao.Text.Length);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            FormEstMarcaPesquisa Pesq = new FormEstMarcaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                txtMarcaId.Text = Pesq.PesqMarca.id.ToString();
                txtMarcaDescricao.Text = Pesq.PesqMarca.descricao;
                cbAtiva.Checked = Pesq.PesqMarca.ativa;
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormEstMarcaPesquisa Pesquisa = new FormEstMarcaPesquisa();
            var Result = Pesquisa.ShowDialog();

            if (Result == DialogResult.OK)
            {
                HabilitarComponentesPnlPrincipal(false);

                txtMarcaId.Text = Pesquisa.PesqMarca.id.ToString();
                txtMarcaDescricao.Text = Pesquisa.PesqMarca.descricao;
                cbAtiva.Checked = Pesquisa.PesqMarca.ativa;

                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                CancelaOperacao();
                return;
            }

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtMarcaDescricao.Text == string.Empty)
            {
                MessageBox.Show("O campo descrição não foi preenchido!");
                txtMarcaDescricao.Focus();
            }
            else
            {
                MarcaController Controle = new MarcaController();
                MarcaDto Marca = new MarcaDto();

                try
                {
                    Marca.id = Int32.Parse(txtMarcaId.Text);
                    Marca.descricao = txtMarcaDescricao.Text;
                    Marca.ativa = cbAtiva.Checked;

                    if (MenuStatus == MStatus.Adicionando)
                        Controle.Adicionar(Marca);
                    else if (MenuStatus == MStatus.Editando)
                        Controle.Editar(Marca);
                    else if (MenuStatus == MStatus.Excluindo)
                        Controle.Excluir(Marca.id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelaOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMarcaDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtMarcaDescricao.Text != String.Empty && txtMarcaDescricao.Enabled)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
