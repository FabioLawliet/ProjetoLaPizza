using LaPizza.Controllers;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                        Coluna.Width = 300;
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
                        Coluna.Width = 80;
                        break;
                    case "vlrdesconto":
                        Coluna.DisplayIndex = 6;
                        Coluna.HeaderText = "Desconto";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 80;
                        break;
                    case "vlrdescontoperc":
                        Coluna.DisplayIndex = 7;
                        Coluna.HeaderText = "% Desconto";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 80;
                        break;
                    case "vlrunitario":
                        Coluna.DisplayIndex = 8;
                        Coluna.HeaderText = "Preço";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 80;
                        break;
                    default:
                        Coluna.Visible = false;
                        break;
                }
            }                
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
            DataGridViewRow Linha   = GridProdutos.Rows[e.RowIndex];
            DataGridViewCell CellQtde = GridProdutos.Rows[e.RowIndex].Cells["qtde"];
            
            if (string.IsNullOrEmpty(CellQtde.Value.ToString()) || (Convert.ToInt64(CellQtde.Value) <= 0))
                Linha.Cells["check"].Value = LaPizza.Properties.Resources.vazio;
            else
                Linha.Cells["check"].Value = LaPizza.Properties.Resources.CheckVenda;
        }
    }
}
