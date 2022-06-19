using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPizza.Controllers;

namespace LaPizza.Views
{
    public partial class FormBaseCadastros : Form
    {
        public MStatus? MenuStatus;
        public FormBaseCadastros()
        {
            InitializeComponent();
            HabilitarAcoesIniciais();
        }

        public enum MStatus
        {
            Adicionando,
            Editando,
            Consultando,
            Excluindo
        }

        public enum TipoAcao
        {
            Adicionar,
            Editar,
            Consultar,
            Excluir,
            Confirmar,
            Cancelar,
            Sair
        }

        public void HabilitarAcoesIniciais()
        {
            HabilitaAcao(TipoAcao.Adicionar, true);
            HabilitaAcao(TipoAcao.Editar, true);
            HabilitaAcao(TipoAcao.Consultar, true);
            HabilitaAcao(TipoAcao.Excluir, true);
            HabilitaAcao(TipoAcao.Confirmar, false);
            HabilitaAcao(TipoAcao.Cancelar, false);
            HabilitaAcao(TipoAcao.Sair, true);
            MenuStatus = null;
        }

        public void HabilitaAcaoMenu(bool HabilitaTodos)
        {
            if (HabilitaTodos)
            {
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionar;
                btnAcaoAdicionar.Enabled = true;
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditar;
                btnAcaoEditar.Enabled = true;
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultar;
                btnAcaoConsultar.Enabled = true;
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluir;
                btnAcaoExcluir.Enabled = true;
            }
            else
            {
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarDisable;
                btnAcaoAdicionar.Enabled = false;
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarDisable;
                btnAcaoEditar.Enabled = false;
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarDisable;
                btnAcaoConsultar.Enabled = false;
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirDisable;
                btnAcaoExcluir.Enabled = false;
            }
        }
        public void HabilitaAcaoMenu(bool HabAdicionar, bool HabEditar, bool HabConsultar, bool HabExcluir)
        {
            if (HabAdicionar)
            {
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionar;
                btnAcaoAdicionar.Enabled = true;
            }
            else
            {
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarDisable;
                btnAcaoAdicionar.Enabled = false;
            }

            if (HabEditar)
            {
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditar;
                btnAcaoEditar.Enabled = true;
            }
            else
            {
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarDisable;
                btnAcaoEditar.Enabled = false;
            }

            if (HabConsultar)
            {
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultar;
                btnAcaoConsultar.Enabled = true;
            }
            else
            {
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarDisable;
                btnAcaoConsultar.Enabled = false;
            }

            if (HabExcluir)
            {
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluir;
                btnAcaoExcluir.Enabled = true;
            }
            else
            {
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirDisable;
                btnAcaoExcluir.Enabled = false;
            }

        }
        public void HabilitaAcao(TipoAcao Tipo, bool HabilitaAcao)
        {
            switch ((int)Tipo)
            {
                case 0: //btnAdicionar
                    {
                        if (HabilitaAcao)
                        {
                            btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionar;
                            btnAcaoAdicionar.Enabled = true;
                        }
                        else
                        {
                            btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarDisable;
                            btnAcaoAdicionar.Enabled = false;
                        }
                        break;
                    }
                case 1: //btnEditar
                    {
                        if (HabilitaAcao)
                        {
                            btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditar;
                            btnAcaoEditar.Enabled = true;
                        }
                        else
                        {
                            btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarDisable;
                            btnAcaoEditar.Enabled = false;
                        }
                        break;
                    }
                case 2: //btnConsultar
                    {
                        if (HabilitaAcao)
                        {
                            btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultar;
                            btnAcaoConsultar.Enabled = true;
                        }
                        else
                        {
                            btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarDisable;
                            btnAcaoConsultar.Enabled = false;
                        }
                        break;
                    }
                case 3: //btnExcluir
                    {
                        if (HabilitaAcao)
                        {
                            btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluir;
                            btnAcaoExcluir.Enabled = true;
                        }
                        else
                        {
                            btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirDisable;
                            btnAcaoExcluir.Enabled = false;
                        }
                        break;
                    }
                case 4: //btnConfirmar
                    {
                        if (HabilitaAcao)
                        {
                            btnConfirmar.BackColor = Color.MediumSeaGreen;
                            btnConfirmar.Enabled = true;
                        }
                        else
                        {
                            btnConfirmar.BackColor = Color.Silver;
                            btnConfirmar.Enabled = false;
                        }
                        break;
                    }
                case 5: //btnCancelar
                    {
                        if (HabilitaAcao)
                        {
                            btnCancelar.BackColor = Color.LightSlateGray;
                            btnCancelar.Enabled = true;
                        }
                        else
                        {
                            btnCancelar.BackColor = Color.Silver;
                            btnCancelar.Enabled = false;
                        }
                        break;
                    }
                case 6: //btnSair
                    {
                        if (HabilitaAcao)
                        {
                            btnSair.BackColor = Color.IndianRed;
                            btnSair.Enabled = true;
                        }
                        else
                        {
                            btnSair.BackColor = Color.Silver;
                            btnSair.Enabled = false;
                        }
                        break;
                    }
            }
        }

        //
        // EVENTOS BOTÃO ADICIONAR
        //

        private void btnAcaoAdicionar_MouseEnter(object sender, EventArgs e)
        {
            if (btnAcaoAdicionar.Enabled)
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarHover;
        }
        private void btnAcaoAdicionar_MouseLeave(object sender, EventArgs e)
        {
            if (btnAcaoAdicionar.Enabled)
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionar;
            else
                btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarHover;
        }

        //
        // EVENTOS BOTÃO EDITAR
        //
        private void btnAcaoEditar_MouseEnter(object sender, EventArgs e)
        {
            if (btnAcaoEditar.Enabled)
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarHover;
        }

        private void btnAcaoEditar_MouseLeave(object sender, EventArgs e)
        {
            if (btnAcaoEditar.Enabled)
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditar;
            else
                btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarHover;
        }

        //
        // EVENTOS BOTÃO CONSULTAR
        //

        private void btnAcaoConsultar_MouseEnter(object sender, EventArgs e)
        {
            if (btnAcaoConsultar.Enabled)
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarHover;
        }

        private void btnAcaoConsultar_MouseLeave(object sender, EventArgs e)
        {
            if (btnAcaoConsultar.Enabled)
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultar;
            else
                btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarHover;
        }

        //
        // EVENTOS BOTÃO EXCLUIR
        //
        private void btnAcaoExcluir_MouseEnter(object sender, EventArgs e)
        {
            if (btnAcaoExcluir.Enabled)
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirHover;
        }

        private void btnAcaoExcluir_MouseLeave(object sender, EventArgs e)
        {
            if (btnAcaoExcluir.Enabled)
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluir;
            else
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirHover;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuStatus = null;
            HabilitaAcaoMenu(true);
            HabilitaAcao(TipoAcao.Cancelar, !btnCancelar.Enabled);
            HabilitaAcao(TipoAcao.Confirmar, btnCancelar.Enabled);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            HabilitaAcaoMenu(true);
            HabilitaAcao(TipoAcao.Confirmar, !btnConfirmar.Enabled);
            HabilitaAcao(TipoAcao.Cancelar, btnConfirmar.Enabled);
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            MenuStatus = MStatus.Adicionando;
            HabilitaAcaoMenu(false);
            HabilitaAcao(TipoAcao.Cancelar, true);
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            MenuStatus = MStatus.Editando;
            HabilitaAcaoMenu(false);
            HabilitaAcao(TipoAcao.Cancelar, true);
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            MenuStatus = MStatus.Consultando;
            HabilitaAcaoMenu(false);
            HabilitaAcao(TipoAcao.Cancelar, true);
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            MenuStatus = MStatus.Excluindo;
            HabilitaAcaoMenu(false);
            HabilitaAcao(TipoAcao.Cancelar, true);
        }

        private void FormBaseCadastros_Load(object sender, EventArgs e)
        {
            lbNomeRotina.Text = this.Text;
            this.Text = String.Empty;
        }
    }
}
