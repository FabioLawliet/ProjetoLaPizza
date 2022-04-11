using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Close();
        }
    }
}
