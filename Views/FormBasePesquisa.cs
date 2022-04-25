using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormBasePesquisa : Form
    {
        public FormBasePesquisa()
        {
            InitializeComponent();
        }
        public enum TipoAcao
        {
            Confirmar,
            Cancelar
        }

        public void HabilitaAcao(TipoAcao Tipo, bool HabilitaAcao)
        {
            switch ((int)Tipo)
            {
                case 0: //btnConfirmar
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
                case 1: //btnCancelar
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
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
