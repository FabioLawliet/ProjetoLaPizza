using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views.Relatorios
{
    public partial class RelProdutos : LaPizza.Views.FormBaseCadastros
    {
        public RelProdutos()
        {
            InitializeComponent();
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            using(var frm = new RelProdutosRV())
            {
                frm.ShowDialog();
            }
        }
    }
}
