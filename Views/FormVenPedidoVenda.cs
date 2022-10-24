using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormVenPedidoVenda : LaPizza.Views.FormBaseCadastros
    {
        PedidoVendaDB FPedido = new PedidoVendaDB();
        DataTable dt = new DataTable();
        string ColumnSelected = "";
        bool ProdutosFiltrados = false;
        public FormVenPedidoVenda()
        {
            InitializeComponent();
            AlimentaProximoIdVenda();
            PopularProdutosNaGrid();
            PopularTodosComboBox();
            SetColunaPesquisa(2);
        }
        public void AlimentaProximoIdVenda()
        {
            PedidoVendaController controle = new PedidoVendaController();
            lbNumeroPedido.Text = controle.GetProximoId().ToString();
        }

        public void PopularProdutosNaGrid()
        {
            PedidoVendaController controle = new PedidoVendaController();
            List<PedidoVendaItemDTO> lista = controle.GetProdutos();

            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("check", typeof(Boolean));
            dt.Columns.Add("idproduto", typeof(string));
            dt.Columns.Add("produtodescricao", typeof(string));
            dt.Columns.Add("unidademedidasigla", typeof(string));
            dt.Columns.Add("saldoestoque", typeof(string));
            dt.Columns.Add("vlrunitario", typeof(string));
            dt.Columns.Add("qtde", typeof(string));
            dt.Columns.Add("vlrdesconto", typeof(string));
            dt.Columns.Add("vlrdescontoperc", typeof(string));
            dt.Columns.Add("vlrliquido", typeof(string));

            foreach (var i in lista)
            {
                dt.Rows.Add(i.marcado, 
                            i.idproduto, 
                            i.produtodescricao, 
                            i.unidademedidasigla,
                            i.saldoestoque,
                            i.vlrunitario,
                            i.qtde,
                            i.vlrdesconto,
                            i.vlrdescontoperc,
                            i.vlrliquido);
            }

            GridProdutos.DataSource = dt;
            AjustarCamposDaGrid();
            AtualizaTotais();
        }
        private void AjustarCamposDaGrid()
        {
            foreach (DataGridViewColumn Coluna in GridProdutos.Columns)
            {
                switch (Coluna.Name)
                {
                    case "check":
                        Coluna.DisplayIndex = 0;
                        Coluna.HeaderText = "";
                        Coluna.ReadOnly = true;
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
                        Coluna.Width = 185; //230
                        break;
                    case "unidademedidasigla":
                        Coluna.DisplayIndex = 3;
                        Coluna.HeaderText = "UN.";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 40;
                        break;
                    case "saldoestoque":
                        Coluna.DisplayIndex = 4;
                        Coluna.HeaderText = "Estoque Disp.";
                        Coluna.ReadOnly = true;
                        Coluna.Width = 80;
                        break;
                    case "vlrunitario":
                        Coluna.DisplayIndex = 6;
                        Coluna.HeaderText = "Preço";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;
                    case "qtde":
                        Coluna.DisplayIndex = 5;
                        Coluna.HeaderText = "Qtde";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;
                    case "vlrdesconto":
                        Coluna.DisplayIndex = 7;
                        Coluna.HeaderText = "Desconto";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(decimal);
                        Coluna.Width = 80;
                        break;
                    case "vlrdescontoperc":
                        Coluna.DisplayIndex = 8;
                        Coluna.HeaderText = "Desc.%";
                        Coluna.ReadOnly = true;
                        Coluna.ValueType = typeof(string);
                        Coluna.Width = 60;
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

        private void PopularTodosComboBox()
        {
            Context db = new Context();

            //Popula o Tipo de Pedido
            cbTipoPedido.DataSource = (from tp in db.tipopedido select tp.descricao).ToList();
            cbTipoPedido.SelectedIndex = 0;

            //Popula o Status
            cbStatusPedido.Items.Clear();
            cbStatusPedido.Items.Add("ABERTO");
            cbStatusPedido.Items.Add("FECHADO");
            cbStatusPedido.SelectedIndex = 0;

            //Popula as Fichas
            cbFicha.Items.Clear();
            for (int i = 1; i <= 10; i++)
                cbFicha.Items.Add("FICHA " + i);

            cbFicha.SelectedIndex = 0;

            dataPedido.Text = DateTime.Now.ToString();
        }

        private bool ExisteProdutoMarcado()
        {
            foreach (DataGridViewRow row in GridProdutos.Rows)
                if ((bool)row.Cells["check"].Value)
                    return true;
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlimentaProximoIdVenda();
            PopularProdutosNaGrid();
            LimpaCampos();
            HabilitaAcaoMenu(true);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (ProdutosFiltrados)
            {
                dv.RowFilter = ColumnSelected + " LIKE '%" + txtPesquisa.Text + "%' and check = true";
            }
            else
            {
                dv.RowFilter = ColumnSelected + " LIKE '%" + txtPesquisa.Text + "%'";
            }
            GridProdutos.DataSource = dv;
            AtualizaCoresItemSelecionado();
        }

        private void AtualizaCoresItemSelecionado()
        {
            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                if ((bool)GridProdutos.Rows[row.Index].Cells["check"].Value)
                {
                    GridProdutos.Rows[row.Index].Cells["qtde"].Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    GridProdutos.Rows[row.Index].Cells["qtde"].Style.ForeColor = Color.Red;
                }
                else
                {
                    GridProdutos.Rows[row.Index].Cells["qtde"].Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    GridProdutos.Rows[row.Index].Cells["qtde"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void SelecionarItemVenda()
        {
            ItemSelecionadoVendaDTO item = new ItemSelecionadoVendaDTO();
            AlimentaItemVenda(item);

            FormVenSelecaoItem FormItem = new FormVenSelecaoItem();
            FormItem.FItem = item;

            var Result = FormItem.ShowDialog();

            if (Result == DialogResult.OK)
            {
                if (FormItem.FItem.qtde > 0)
                    GridProdutos.CurrentRow.Cells["check"].Value = true;
                else
                    GridProdutos.CurrentRow.Cells["check"].Value = false;

                GridProdutos.CurrentRow.Cells["qtde"].Value = FormItem.FItem.qtde.ToString("N2");
                GridProdutos.CurrentRow.Cells["vlrdesconto"].Value = FormItem.FItem.vlrDesconto.ToString("N2");
                GridProdutos.CurrentRow.Cells["vlrliquido"].Value = FormItem.FItem.getVlrLiquido().ToString("N2");

                AtualizaTotais();
            }

            AtualizaCoresItemSelecionado();

            HabilitaAcao(TipoAcao.Confirmar, ExisteProdutoMarcado());
            HabilitaAcao(TipoAcao.Cancelar, ExisteProdutoMarcado());
        }
        private void GridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           SelecionarItemVenda();
        }

        private void AlimentaItemVenda(ItemSelecionadoVendaDTO itemVenda)
        {
            itemVenda.idProduto        = GridProdutos.CurrentRow.Cells["idproduto"].Value.ToString();
            itemVenda.produtoDescricao = GridProdutos.CurrentRow.Cells["produtodescricao"].Value.ToString();
            itemVenda.qtdeDisponivel   = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["saldoestoque"].Value.ToString());

            if (GridProdutos.CurrentRow.Cells["qtde"].Value.ToString() != "0,00")
                itemVenda.qtde = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["qtde"].Value.ToString());
            else
                itemVenda.qtde = 1.00m;

            itemVenda.vlrUnitario = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrunitario"].Value.ToString());
            itemVenda.vlrDesconto = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrdesconto"].Value.ToString());
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            FormRecClientePesquisa Pesq = new FormRecClientePesquisa();
            ClienteController Controle = new ClienteController();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtCliente.Text = Pesq.PesqCliente.idcliente + " - " + Pesq.PesqCliente.nomerazao;
                FPedido.idcliente = Pesq.PesqCliente.idcliente;
            }   
        }

        private void btnPesquisaFormaPagamento_Click(object sender, EventArgs e)
        {
            FormVenFormaPagamentoPesquisa Pesq = new FormVenFormaPagamentoPesquisa();
            FormaPagamentoController Controle = new FormaPagamentoController();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtFormaPagamento.Text = Pesq.PesqFormaPagamento.idformapagamento + " - " + Pesq.PesqFormaPagamento.descricao;
                FPedido.idformapagamento = Pesq.PesqFormaPagamento.idformapagamento;
            }
        }

        private void AtualizaTotais()
        {
            decimal TotalBruto    = 0m;
            decimal TotalDescontos = 0m;

            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                if (row != null)
                {
                    decimal qtde = Convert.ToDecimal(row.Cells["qtde"].Value.ToString());
                    decimal desconto = Convert.ToDecimal(row.Cells["vlrdesconto"].Value.ToString());
                    decimal vlrunitario = Convert.ToDecimal(row.Cells["vlrunitario"].Value.ToString());
                    decimal vlrliquido = Convert.ToDecimal(row.Cells["vlrliquido"].Value.ToString());

                    TotalBruto += qtde * vlrunitario;
                    TotalDescontos += desconto;
                }
            }

            lbTotalBruto.Text     = TotalBruto.ToString("C");
            lbTotalDescontos.Text = TotalDescontos.ToString("C");
            lbTotalLiquido.Text   = (TotalBruto - TotalDescontos).ToString("C");
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (!ProdutosFiltrados)
            {
                btnCarrinho.BackgroundImage = LaPizza.Properties.Resources.CarrinhoComprasHover;
                dv.RowFilter = "check = true";
                ProdutosFiltrados = true;
            }
            else
            {
                btnCarrinho.BackgroundImage = LaPizza.Properties.Resources.CarrinhoCompras;
                dv.RowFilter = "";
                ProdutosFiltrados = false;
            }
            GridProdutos.DataSource = dv;
            AtualizaCoresItemSelecionado();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidaInformacoesPedido())
                return;

            AlimentaFPedido();
            PedidoVendaController controle = new PedidoVendaController();

            if (MenuStatus == null)
            {
                controle.Adicionar(FPedido);
                MenuStatus = null;
            }                
            else if (MenuStatus == MStatus.Consultando)
            {
                controle.Consultar(FPedido);
                MenuStatus = null;
            }
            else if (MenuStatus == MStatus.Excluindo)
            {
                if (MessageBox.Show("Deseja realmente excluir o pedido?", "Excluir Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controle.Excluir(Convert.ToInt32(lbNumeroPedido.Text));
                    MenuStatus = null;
                }
                else
                {
                    return;
                }
                                    
            }                

            AlimentaProximoIdVenda();
            PopularProdutosNaGrid();
            LimpaCampos();
        }

        private void AlimentaFPedido()
        {
            FPedido.idpedido          = Convert.ToInt32(lbNumeroPedido.Text);
            FPedido.idficha           = cbFicha.SelectedIndex + 1;
            FPedido.dataabertura      = Convert.ToDateTime(dataPedido.Text);
            FPedido.idtipopedido      = cbTipoPedido.SelectedIndex + 1;
            FPedido.status            = cbStatusPedido.SelectedItem.ToString();
            FPedido.vlrtotalbruto     = Convert.ToDecimal(lbTotalBruto.Text.Replace("R$ ", ""));
            FPedido.vlrtotaldescontos = Convert.ToDecimal(lbTotalDescontos.Text.Replace("R$ ", ""));

            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                if ((bool)row.Cells["check"].Value)
                {
                    PedidoVendaItemDB itemDB = new PedidoVendaItemDB();
                    itemDB.idpedido          = Convert.ToInt32(lbNumeroPedido.Text);
                    itemDB.idproduto         = Convert.ToInt32(row.Cells["idproduto"].Value);
                    itemDB.qtde              = Convert.ToDecimal(row.Cells["qtde"].Value);
                    itemDB.vlrunitario       = Convert.ToDecimal(row.Cells["vlrunitario"].Value);
                    itemDB.vlrdesconto       = Convert.ToDecimal(row.Cells["vlrdesconto"].Value);
                    itemDB.vlrbruto          = Convert.ToDecimal(row.Cells["qtde"].Value) * Convert.ToDecimal(row.Cells["vlrunitario"].Value);

                    FPedido.items.Add(itemDB);
                }
            }
        }

        private void LimpaCampos()
        {
            txtCliente.Text = string.Empty;
            txtFormaPagamento.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
            FPedido.items.Clear();
            PopularTodosComboBox();
        }

        private void GridProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13) || e.KeyChar == Convert.ToChar(Keys.Space))
                SelecionarItemVenda();
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            FormVenPedidoVendaPesquisa Pesq = new FormVenPedidoVendaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtCliente.Text = Pesq.PesqPedido.idcliente + " - " + Pesq.PesqPedido.clientenome;
                FPedido.idcliente = Pesq.PesqPedido.idcliente;
                dataPedido.Text = Pesq.PesqPedido.dataabertura.ToString();
                txtFormaPagamento.Text = Pesq.PesqPedido.idformapagamento + " - " + Pesq.PesqPedido.formapagamentodescricao;
                FPedido.idformapagamento = Pesq.PesqPedido.idformapagamento;
                lbNumeroPedido.Text = Pesq.PesqPedido.idpedido.ToString();
                cbTipoPedido.SelectedIndex = Pesq.PesqPedido.idtipopedido - 1;

                if (Pesq.PesqPedido.idficha > 0 && Pesq.PesqPedido.idficha <= 10)
                    cbFicha.SelectedIndex = Pesq.PesqPedido.idficha - 1;
                else
                    cbFicha.SelectedIndex = 0;

                foreach (var item in cbStatusPedido.Items)
                    if (item.ToString() == Pesq.PesqPedido.status)
                        cbStatusPedido.SelectedIndex = cbStatusPedido.Items.IndexOf(item);

                foreach (DataGridViewRow row in GridProdutos.Rows)
                {
                    foreach(PedidoVendaItemDTO item in Pesq.PesqPedido.itens)
                    {
                        if (Convert.ToInt32(row.Cells["idproduto"].Value) == item.idproduto)
                        {
                            row.Cells["check"].Value       = true;
                            row.Cells["qtde"].Value        = item.qtde.ToString("N2");
                            row.Cells["vlrdesconto"].Value = item.vlrdesconto.ToString("N2");
                            row.Cells["vlrliquido"].Value  = ((item.qtde * item.vlrunitario) - item.vlrdesconto).ToString("N2");
                        }
                    }
                }

                AtualizaCoresItemSelecionado();

                lbTotalBruto.Text = Pesq.PesqPedido.vlrtotalbruto.ToString("C");
                lbTotalDescontos.Text = Pesq.PesqPedido.vlrtotaldescontos.ToString("C");
                lbTotalLiquido.Text = (Pesq.PesqPedido.vlrtotalbruto - Pesq.PesqPedido.vlrtotaldescontos).ToString("C");

                HabilitaAcao(TipoAcao.Confirmar, ExisteProdutoMarcado());
                HabilitaAcao(TipoAcao.Cancelar, ExisteProdutoMarcado());
            }
            else
            {
                btnCancelar_Click(sender, e);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            FormVenPedidoVendaPesquisa Pesq = new FormVenPedidoVendaPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtCliente.Text = Pesq.PesqPedido.idcliente + " - " + Pesq.PesqPedido.clientenome;
                FPedido.idcliente = Pesq.PesqPedido.idcliente;
                dataPedido.Text = Pesq.PesqPedido.dataabertura.ToString();
                txtFormaPagamento.Text = Pesq.PesqPedido.idformapagamento + " - " + Pesq.PesqPedido.formapagamentodescricao;
                FPedido.idformapagamento = Pesq.PesqPedido.idformapagamento;
                lbNumeroPedido.Text = Pesq.PesqPedido.idpedido.ToString();
                cbTipoPedido.SelectedIndex = Pesq.PesqPedido.idtipopedido - 1;

                if (Pesq.PesqPedido.idficha > 0 && Pesq.PesqPedido.idficha <= 10)
                    cbFicha.SelectedIndex = Pesq.PesqPedido.idficha - 1;
                else
                    cbFicha.SelectedIndex = 0;

                foreach (var item in cbStatusPedido.Items)
                    if (item.ToString() == Pesq.PesqPedido.status)
                        cbStatusPedido.SelectedIndex = cbStatusPedido.Items.IndexOf(item);

                foreach (DataGridViewRow row in GridProdutos.Rows)
                {
                    foreach (PedidoVendaItemDTO item in Pesq.PesqPedido.itens)
                    {
                        if (Convert.ToInt32(row.Cells["idproduto"].Value) == item.idproduto)
                        {
                            row.Cells["check"].Value = true;
                            row.Cells["qtde"].Value = item.qtde.ToString("N2");
                            row.Cells["vlrdesconto"].Value = item.vlrdesconto.ToString("N2");
                            row.Cells["vlrliquido"].Value = ((item.qtde * item.vlrunitario) - item.vlrdesconto).ToString("N2");
                        }
                    }
                }

                AtualizaCoresItemSelecionado();

                lbTotalBruto.Text = Pesq.PesqPedido.vlrtotalbruto.ToString("C");
                lbTotalDescontos.Text = Pesq.PesqPedido.vlrtotaldescontos.ToString("C");
                lbTotalLiquido.Text = (Pesq.PesqPedido.vlrtotalbruto - Pesq.PesqPedido.vlrtotaldescontos).ToString("C");

                HabilitaAcao(TipoAcao.Confirmar, ExisteProdutoMarcado());
                HabilitaAcao(TipoAcao.Cancelar, ExisteProdutoMarcado());
            }
            else
            {
                btnCancelar_Click(sender, e);
            }
        }

        private void GridProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetColunaPesquisa(e.ColumnIndex);
        }

        private void SetColunaPesquisa(int colunaIndex)
        {
            ColumnSelected = dt.Columns[colunaIndex].ColumnName;
            lbPesquisa.Text = "Pesquisa por (" + GridProdutos.Rows[0].Cells[colunaIndex].OwningColumn.HeaderText + ")";
        }

        private void GridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                SelecionarItemVenda();
        }

        private bool ValidaInformacoesPedido()
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Informe um cliente para confirmar o pedido!");

                if (txtCliente.CanFocus)
                    txtCliente.Focus();
                return false;
            }
            
            if (txtFormaPagamento.Text == "")
            {
                MessageBox.Show("Informe uma forma de pagamento para confirmar o pedido!");

                if (txtFormaPagamento.CanFocus)
                    txtFormaPagamento.Focus();
                return false;
            }

            if (!ExisteProdutoMarcado()){
                MessageBox.Show("Lançe um produto no pedido para confirmar o pedido!");
                if (GridProdutos.CanFocus)
                    GridProdutos.Focus();
                return false;
            }

            return true;
        }
    }
}
