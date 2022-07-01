using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormVenPedidoVenda : LaPizza.Views.FormBaseCadastros
    {
        public FormVenPedidoVenda()
        {
            InitializeComponent();
            CarregarListaGrid();
            AlimentaTodosComboBox();
        }

        public void CarregarListaGrid()
        {
            PedidoVendaController controle = new PedidoVendaController();
            List<PedidoVendaItemDTO> lista = controle.GetPedidoVendaItens();

            GridProdutos.DataSource = lista;
            AjustaCampoGrid();
        }

        private void AjustaCampoGrid()
        {

            foreach (DataGridViewColumn Coluna in GridProdutos.Columns)
            {
                switch (Coluna.Name)
                {
                    case "check":
                        Coluna.DisplayIndex = 0;
                        Coluna.HeaderText = "";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(Image);
                        Coluna.Width = 20;
                        break;
                    case "idproduto":
                        Coluna.DisplayIndex = 1;
                        Coluna.HeaderText = "Id";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 50;
                        break;
                    case "produtodescricao":
                        Coluna.DisplayIndex = 2;
                        Coluna.HeaderText = "Descrição Produto";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 172; //230
                        break;
                    case "unidademedidasigla":
                        Coluna.DisplayIndex = 3;
                        Coluna.HeaderText = "UN.";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 50;
                        break;
                    case "saldoestoque":
                        Coluna.DisplayIndex = 4;
                        Coluna.HeaderText = "Estoque Disp.";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 70;
                        break;
                    case "qtde":
                        Coluna.DisplayIndex = 5;
                        Coluna.HeaderText = "Qtde";
                        Coluna.ReadOnly = false;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;
                    case "vlrdesconto":
                        Coluna.DisplayIndex = 6;
                        Coluna.HeaderText = "Desconto";
                        Coluna.ReadOnly = false;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;
                    case "vlrdescontoperc":
                        Coluna.DisplayIndex = 7;
                        Coluna.HeaderText = "% Desconto";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(string);
                        Coluna.Width = 80;
                        break;
                    case "vlrunitario":
                        Coluna.DisplayIndex = 8;
                        Coluna.HeaderText = "Preço";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;
                    case "vlrliquido":
                        Coluna.DisplayIndex = 9;
                        Coluna.HeaderText = "Vlr. Liquido";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;

                    default:
                        Coluna.Visible = false;
                        break;
                }
            }                
        }

        private void AlimentaTodosComboBox()
        {
            Context db = new Context();
            cbTipoPedido.DataSource = (from tp in db.tipopedido select tp.descricao).ToList();
            cbTipoPedido.SelectedIndex = 0;

            cbStatusPedido.Items.Add("EM ANDAMENTO");
            cbStatusPedido.Items.Add("CONFIRMADO");
            cbStatusPedido.SelectedIndex = 0;


            for (int i = 1; i <= 10; i++)
                cbFicha.Items.Add("FICHA " + i);

            cbFicha.SelectedIndex = 0;
        }

        private void CarregaStatusPedido()
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            /*GridProdutos.DataSource = null;
            ProdutoController controle = new ProdutoController();
            List<ProdutoDTO> Lista = controle.GetProdutoPesquisaGrid(txtpesquisa);

            GridProdutos.DataSource = Lista;
            AjustaCampoGrid();
            GridProdutos.Refresh();*/
        }

        private void GridProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridProdutos_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProdutos.CurrentRow == null || e.RowIndex == -1)
                return;

            DataGridViewRow Linha   = GridProdutos.Rows[e.RowIndex];
            DataGridViewCell CellQtde = GridProdutos.Rows[e.RowIndex].Cells["qtde"];
            
            if (string.IsNullOrEmpty(CellQtde.Value.ToString()) || (Convert.ToInt64(CellQtde.Value) <= 0))
                Linha.Cells["check"].Value = LaPizza.Properties.Resources.vazio;
            else
                Linha.Cells["check"].Value = LaPizza.Properties.Resources.CheckVenda;
        }

        private void GridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProdutos.CurrentRow == null || e.RowIndex == -1)
                return;

            DataGridViewRow Linha = GridProdutos.Rows[e.RowIndex];
            DataGridViewCell CellQtde = GridProdutos.Rows[e.RowIndex].Cells["qtde"];

            if (Convert.ToDecimal(CellQtde.Value) == 0)
            {
                CellQtde.Value = 1m;
                Linha.Cells["check"].Value = LaPizza.Properties.Resources.CheckVenda;
            }                
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            FormRecClientePesquisa Pesq = new FormRecClientePesquisa();
            ClienteController Controle = new ClienteController();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
                txtCliente.Text = Pesq.PesqCliente.idcliente + " - " + Pesq.PesqCliente.nomerazao;
        }

        private void btnPesquisaFormaPagamento_Click(object sender, EventArgs e)
        {
            FormVenFormaPagamentoPesquisa Pesq = new FormVenFormaPagamentoPesquisa();
            FormaPagamentoController Controle = new FormaPagamentoController();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
                txtFormaPagamento.Text = Pesq.PesqFormaPagamento.idformapagamento + " - " + Pesq.PesqFormaPagamento.descricao;
        }

        private void GridProdutos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DataGridViewCell CellQtde = GridProdutos.Rows[e.RowIndex].Cells["qtde"];
            DataGridViewCell CellDesconto = GridProdutos.Rows[e.RowIndex].Cells["vlrdesconto"];
            DataGridViewCell CellDescontoPerc = GridProdutos.Rows[e.RowIndex].Cells["vlrdescontoperc"];

            if (String.IsNullOrEmpty((string)CellQtde.Value))
                CellQtde.Value = 0m;

            if (String.IsNullOrEmpty((string)CellDesconto.Value))
                CellDesconto.Value = 0m;

            if (String.IsNullOrEmpty((string)CellDescontoPerc.Value))
                CellDescontoPerc.Value = 0m;*/

        }

        private void GridProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            MessageBox.Show("teste123");
            if (e.KeyChar == (char)Keys.Delete)
                if (GridProdutos.SelectedRows.Count > 0)
                    GridProdutos.Rows.RemoveAt(GridProdutos.CurrentRow.Index);*/
        }

        private void ZeraCampoVazio()
        {
            if ((GridProdutos.CurrentCell.Value == null) || ((string)GridProdutos.CurrentCell.Value == String.Empty))
                return;

            if (GridProdutos.CurrentCell.ColumnIndex == GridProdutos.CurrentRow.Cells["qtde"].ColumnIndex)
                GridProdutos.CurrentCell.Value = 0m;
            else if (GridProdutos.CurrentCell.ColumnIndex == GridProdutos.CurrentRow.Cells["vlrdesconto"].ColumnIndex)
                GridProdutos.CurrentCell.Value = 0m;
            else if (GridProdutos.CurrentCell.ColumnIndex == GridProdutos.CurrentRow.Cells["vlrdescontoperc"].ColumnIndex)
                GridProdutos.CurrentCell.Value = 0m;
        }

        private void AtualizaTotais()
        {
            if (GridProdutos.CurrentRow == null || GridProdutos.CurrentRow.Index == -1)
                return;

            decimal TotalBruto    = 0m;
            decimal TotalDescontos = 0m;

            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                decimal qtde         = Convert.ToDecimal(row.Cells["qtde"].Value.ToString());
                decimal desconto     = Convert.ToDecimal(row.Cells["vlrdesconto"].Value.ToString());
                decimal vlrunitario  = Convert.ToDecimal(row.Cells["vlrunitario"].Value.ToString());
                decimal vlrliquido   = Convert.ToDecimal(row.Cells["vlrliquido"].Value.ToString());

                TotalBruto     += qtde * vlrunitario;
                TotalDescontos += desconto;
            }

            lbTotalBruto.Text     = Math.Truncate(TotalBruto).ToString("0.##");
            lbTotalDescontos.Text = Math.Truncate(TotalDescontos).ToString("0.##");
            lbTotalLiquido.Text   = Math.Truncate(TotalBruto - TotalDescontos).ToString("0.##");

        }

        private void AtualizaDescontoPercentual()
        {
            if (GridProdutos.CurrentRow == null || GridProdutos.CurrentRow.Index == -1)
                return;

            decimal qtde        = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["qtde"].Value.ToString());
            decimal desconto    = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrdesconto"].Value.ToString());
            decimal vlrunitario = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrunitario"].Value.ToString());            
            
            if (qtde != 0)
            {
                decimal descontoperc = (desconto / (qtde * vlrunitario) * 100);
                if (descontoperc == 0)
                    GridProdutos.CurrentRow.Cells["vlrdescontoperc"].Value = "0,00%";
                else
                    GridProdutos.CurrentRow.Cells["vlrdescontoperc"].Value = desconto.ToString("0.##") + "%";
            }
        }

        private void AtualizaValorUnitario()
        {
            if (GridProdutos.CurrentRow == null || GridProdutos.CurrentRow.Index == -1)
                return;

                decimal qtde = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["qtde"].Value.ToString());
                decimal desconto = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrdesconto"].Value.ToString());
                decimal vlrunitario = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrunitario"].Value.ToString());

                GridProdutos.CurrentRow.Cells["vlrliquido"].Value = (qtde * vlrunitario) - desconto;
        }

        private void GridProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //ZeraCampoVazio();

            AtualizaValorUnitario();
            AtualizaDescontoPercentual();
            AtualizaTotais();
           
        }
    }
}
