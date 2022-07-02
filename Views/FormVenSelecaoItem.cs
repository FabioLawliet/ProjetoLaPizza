using LaPizza.Models;
using System;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormVenSelecaoItem : Form
    {
        public ItemSelecionadoVendaDTO FItem = null;
        public FormVenSelecaoItem()
        {
            InitializeComponent();
        }

        private void RecalculaValores()
        {
            if (txtQtde.Text == String.Empty || txtVlrDesconto.Text == String.Empty)
                return;
            else
            {
                FItem.qtde = Convert.ToDecimal(txtQtde.Text);
                FItem.vlrDesconto = Convert.ToDecimal(txtVlrDesconto.Text);
                FItem.calculaValores();

                txtVlrUnitario.Text = FItem.vlrUnitario.ToString("N2");
                txtVlrDescontoPerc.Text = FItem.descontoPerc;
                txtVlrBruto.Text = FItem.getVlrBruto().ToString("N2");
                txtVlrLiquido.Text = FItem.getVlrLiquido().ToString("N2");
            }

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            RecalculaValores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool MenorOuIgualQtdeDisponivel(decimal Qtde)
        {
            if (Qtde <= FItem.qtdeDisponivel)
                return true;
            else
                return false;
        }

        private void FormVenSelecaoItem_Load(object sender, EventArgs e)
        {
            if (FItem != null)
            {
                FItem.calculaValores();
                txtProdutoId.Text = FItem.idProduto;
                txtProdutoDescricao.Text = FItem.produtoDescricao;
                txtQtdeDisponivel.Text = FItem.qtdeDisponivel.ToString("N2");
                txtQtde.Text = FItem.qtde.ToString("N2");
                txtVlrUnitario.Text = FItem.vlrUnitario.ToString("N2");
                txtVlrDesconto.Text = FItem.vlrDesconto.ToString("N2");
                txtVlrDescontoPerc.Text = FItem.descontoPerc;
                txtVlrBruto.Text = FItem.getVlrBruto().ToString("N2");
                txtVlrLiquido.Text = FItem.getVlrLiquido().ToString("N2");
            }

            txtQtde.Focus();
        }

        private void txtVlrDesconto_Leave(object sender, EventArgs e)
        {
            RecalculaValores();
        }
    }
}
