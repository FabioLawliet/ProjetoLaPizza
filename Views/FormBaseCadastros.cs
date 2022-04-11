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
        public FormBaseCadastros()
        {
            InitializeComponent();
            HabilitaAcao(TipoAcao.Adicionar, true);
            HabilitaAcao(TipoAcao.Editar, true);
            HabilitaAcao(TipoAcao.Consultar, true);
            HabilitaAcao(TipoAcao.Excluir, true);
            HabilitaAcao(TipoAcao.Confirmar, false);
            HabilitaAcao(TipoAcao.Cancelar, false);
            HabilitaAcao(TipoAcao.Sair, true);
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

        //
        // EVENTOS BOTÃO ADICIONAR
        //

        private void btnAcaoAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarHover;
        }
        private void btnAcaoAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionar;
        }
        private void btnAcaoAdicionar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarClick;
        }

        private void btnAcaoAdicionar_MouseUp(object sender, MouseEventArgs e)
        {
            btnAcaoAdicionar.BackgroundImage = LaPizza.Properties.Resources.AcaoAdicionarHover;
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
        // EVENTOS BOTÃO EDITAR
        //
        private void btnAcaoEditar_MouseEnter(object sender, EventArgs e)
        {
            btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarHover;
        }

        private void btnAcaoEditar_MouseLeave(object sender, EventArgs e)
        {
            btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditar;
        }
        private void btnAcaoEditar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarClick;
        }

        private void btnAcaoEditar_MouseUp(object sender, MouseEventArgs e)
        {
            btnAcaoEditar.BackgroundImage = LaPizza.Properties.Resources.AcaoEditarHover;
        }


        //
        // EVENTOS BOTÃO CONSULTAR
        //

        private void btnAcaoConsultar_MouseEnter(object sender, EventArgs e)
        {
            btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarHover;
        }

        private void btnAcaoConsultar_MouseLeave(object sender, EventArgs e)
        {
            btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultar;
        }
        private void btnAcaoConsultar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarClick;
        }

        private void btnAcaoConsultar_MouseUp(object sender, MouseEventArgs e)
        {
            btnAcaoConsultar.BackgroundImage = LaPizza.Properties.Resources.AcaoConsultarHover;
        }

        //
        // EVENTOS BOTÃO EXCLUIR
        //
        private void btnAcaoExcluir_MouseEnter(object sender, EventArgs e)
        {
            if (btnAcaoExcluir.Enabled == true)
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirHover;
            else
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirDisable;
        }

        private void btnAcaoExcluir_MouseLeave(object sender, EventArgs e)
        {
            if (btnAcaoExcluir.Enabled == true)
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluir;
            else
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirDisable;
        }

        private void btnAcaoExcluir_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnAcaoExcluir.Enabled == true)
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirClick;
            else
                btnAcaoExcluir.BackgroundImage = LaPizza.Properties.Resources.AcaoExcluirDisable;
        }

        private void btnAcaoExcluir_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
