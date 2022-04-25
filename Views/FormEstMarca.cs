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

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            MarcaController MControle = new MarcaController();
            txtMarcaId.Text = (MControle.GetProximoId() + 1).ToString();

            if (txtMarcaDescricao.CanFocus)
                txtMarcaDescricao.Focus();
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            FormEstMarcaPesquisa Pesq = new FormEstMarcaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtMarcaId.Text = Pesq.PMarca.id.ToString();
                txtMarcaDescricao.Text = Pesq.PMarca.descricao;
                cbAtiva.Enabled = Pesq.PMarca.ativa;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtMarcaDescricao.CanFocus)
                txtMarcaDescricao.Focus();
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            FormEstMarcaPesquisa Pesq = new FormEstMarcaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtMarcaId.Text = Pesq.PMarca.id.ToString();
                txtMarcaDescricao.Text = Pesq.PMarca.descricao;
                cbAtiva.Enabled = Pesq.PMarca.ativa;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            FormEstMarcaPesquisa Pesq = new FormEstMarcaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtMarcaId.Text = Pesq.PMarca.id.ToString();
                txtMarcaDescricao.Text = Pesq.PMarca.descricao;
                cbAtiva.Enabled = Pesq.PMarca.ativa;

                btnConfirmar.Enabled = true;
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();
        }

        private void LimpaComponentes()
        {
            txtMarcaId.Text = string.Empty;
            txtMarcaDescricao.Text = string.Empty;
            cbAtiva.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtMarcaDescricao.Text == string.Empty)
            {
                MessageBox.Show("É necessário informar uma descrição");
                txtMarcaDescricao.Focus();
            }
            else
            {
                MarcaController Mcontrole = new MarcaController();
                MarcaDto Marca = new MarcaDto();

                Marca.id = Int32.Parse(txtMarcaId.Text);
                Marca.descricao = txtMarcaDescricao.Text;
                Marca.ativa = cbAtiva.Checked;

                if (MenuStatus == MStatus.Adicionando)
                    Mcontrole.AdicionarMarca(Marca);
                else if (MenuStatus == MStatus.Editando)
                    Mcontrole.EditarMarca(Marca);
                else if (MenuStatus == MStatus.Excluindo)
                    Mcontrole.ExcluirMarca(Marca.id);
            }

            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void txtMarcaDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtMarcaDescricao.Text != String.Empty && txtMarcaDescricao.Enabled == true)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }
    }
}
