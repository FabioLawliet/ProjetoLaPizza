using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LaPizza.Controllers;
using LaPizza.Models;

namespace LaPizza.Views
{
    public partial class FormEstMarca : LaPizza.Views.FormBaseCadastros
    {
        public MarcaModel MarcaPesquisa;
        
        public FormEstMarca()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtDescricao.BackColor = Color.White;
                txtDescricao.Enabled = true;
                cbAtiva.BackColor = Color.White;
                cbAtiva.Enabled = true;
            }
            else
            {
                txtId.BackColor = Color.Silver;
                txtId.Enabled = false;
                txtDescricao.BackColor = Color.Silver;
                txtDescricao.Enabled = false;
                cbAtiva.Enabled = false;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            MarcaController MControle = new MarcaController();
            txtId.Text = (MControle.GetProximoId()+1).ToString();

            if (txtDescricao.CanFocus)
                txtDescricao.Focus();
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            FormEstMarcaPesquisa pesquisaMarca = new FormEstMarcaPesquisa(this);
            pesquisaMarca.ShowDialog();

            if (MenuStatus == null)
                cancelaOperacao();

            if (txtDescricao.CanFocus)
                txtDescricao.Focus();
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            FormEstMarcaPesquisa pesquisaMarca = new FormEstMarcaPesquisa(this);
            pesquisaMarca.ShowDialog();

            if (MenuStatus == null)
                cancelaOperacao();

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(false);

            FormEstMarcaPesquisa pesquisaMarca = new FormEstMarcaPesquisa(this);
            pesquisaMarca.ShowDialog();

            if (MenuStatus == null)
                cancelaOperacao();
            else
                HabilitaAcao(TipoAcao.Confirmar, true);

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();
        }

        private void LimpaComponentes()
        {
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            cbAtiva.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text == string.Empty )
            {
                MessageBox.Show("É necessário informar uma descrição");
                txtDescricao.Focus();
            }
            else
            {
                MarcaController Mcontrole = new MarcaController();
                MarcaDto Marca = new MarcaDto();

                Marca.id = Int32.Parse(txtId.Text);
                Marca.descricao = txtDescricao.Text;
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

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (this.Text != String.Empty && txtDescricao.Enabled == true)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }

    }
}
