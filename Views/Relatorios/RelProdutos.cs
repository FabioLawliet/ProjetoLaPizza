using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
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
            Context db = new Context();
            ProdutoController ctr = new ProdutoController();

            DataTable dt = CollectionHelper.ConvertTo<ProdutoDTO>(ctr.GetProdutoLista());

            using (var frm = new RelProdutosRV(dt))
            {
                frm.ShowDialog();
            }
        }
    }
}
