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
        public FormEstMarca()
        {
            InitializeComponent();
            HabilitaComponentesPnlPrincipal(false);
        }

        private void HabilitaComponentesPnlPrincipal(bool Ativa)
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
            HabilitaAcao(TipoAcao.Adicionar, false);
            HabilitaAcao(TipoAcao.Editar, false);
            HabilitaAcao(TipoAcao.Consultar, false);
            HabilitaAcao(TipoAcao.Excluir, false);
            HabilitaAcao(TipoAcao.Confirmar, false);
            HabilitaAcao(TipoAcao.Cancelar, false);
            HabilitaAcao(TipoAcao.Sair, true);
            HabilitaComponentesPnlPrincipal(true);
            LimpaComponentes();
            btnAcaoAdicionar.BackgroundImage = Properties.Resources.AcaoAdicionarHover;
            MarcaController MControle = new MarcaController();
            txtId.Text = (MControle.GetProximoId()+1).ToString();

            if (txtDescricao.CanFocus)
                txtDescricao.Focus();
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Adicionar, false);
            HabilitaAcao(TipoAcao.Editar, false);
            HabilitaAcao(TipoAcao.Consultar, false);
            HabilitaAcao(TipoAcao.Excluir, false);
            HabilitaAcao(TipoAcao.Confirmar, false);
            HabilitaAcao(TipoAcao.Cancelar, false);
            HabilitaAcao(TipoAcao.Sair, true);
            
            HabilitaComponentesPnlPrincipal(true);
            FormEstMarcaPesquisa pesquisaMarca = new FormEstMarcaPesquisa(this);
            pesquisaMarca.ShowDialog();
            btnAcaoEditar.BackgroundImage = Properties.Resources.AcaoEditar;

        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {

        }

        private void LimpaComponentes()
        {
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            cbAtiva.Checked = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Informe uma descrição");
                txtDescricao.Focus();
            }
            else
            {
                MarcaController Mcontrole = new MarcaController();
                MarcaDto Marca = new MarcaDto();

                Marca.id = Int32.Parse(txtId.Text);
                Marca.descricao = txtDescricao.Text;
                Marca.ativa = cbAtiva.Checked;

                if (Mcontrole.ExisteMarca(Int32.Parse(txtId.Text)))
                    Mcontrole.AdicionarMarca(Marca);
                else
                {
                    Mcontrole.SalvaEdicaoMarca(Marca);
                }
            }

            LimpaComponentes();
            HabilitaComponentesPnlPrincipal(false);
            HabilitaAcao(TipoAcao.Adicionar, true);
            HabilitaAcao(TipoAcao.Editar, true);
            HabilitaAcao(TipoAcao.Consultar, true);
            HabilitaAcao(TipoAcao.Excluir, true);
            HabilitaAcao(TipoAcao.Confirmar, false);
            HabilitaAcao(TipoAcao.Cancelar, false);
            HabilitaAcao(TipoAcao.Sair, true);
            

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaComponentes();
            HabilitaComponentesPnlPrincipal(false);
            HabilitaAcao(TipoAcao.Adicionar, true);
            HabilitaAcao(TipoAcao.Editar, true);
            HabilitaAcao(TipoAcao.Consultar, true);
            HabilitaAcao(TipoAcao.Excluir, true);
            HabilitaAcao(TipoAcao.Confirmar, false);
            HabilitaAcao(TipoAcao.Cancelar, false);
            HabilitaAcao(TipoAcao.Sair, true);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text != String.Empty)
            {
                HabilitaAcao(TipoAcao.Confirmar, true);
                HabilitaAcao(TipoAcao.Cancelar, true);
            }
            else
            {
                HabilitaAcao(TipoAcao.Confirmar, false);
                HabilitaAcao(TipoAcao.Cancelar, false);
            }
        }
    }
}
