﻿using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormVenPedidoVenda()
        {
            InitializeComponent();
            CarregarListaGrid();
            AlimentaTodosComboBox();
            //AtualizaTotais();

            //PedidoVendaController controle = new PedidoVendaController();
            //lbNumeroPedido.Text = controle.GetProximoId().ToString();
        }

        public void CarregarListaGrid()
        {
            PedidoVendaController controle = new PedidoVendaController();
            List<PedidoVendaItemDTO> lista = controle.GetProdutos();

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
                        Coluna.ReadOnly = false;
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

        private void AlimentaTodosComboBox()
        {
            Context db = new Context();
            cbTipoPedido.DataSource = (from tp in db.tipopedido select tp.descricao).ToList();
            cbTipoPedido.SelectedIndex = 0;

            cbStatusPedido.Items.Clear();
            cbStatusPedido.Items.Add("ABERTO");
            cbStatusPedido.Items.Add("FECHADO");
            cbStatusPedido.SelectedIndex = 0;

            cbFicha.Items.Clear();
            for (int i = 1; i <= 10; i++)
                cbFicha.Items.Add("FICHA " + i);

            cbFicha.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*
            LimpaCampos();
            CarregarListaGrid();
            AlimentaTodosComboBox();

            FPedido.items.Clear();
            PedidoVendaController controle = new PedidoVendaController();
            lbNumeroPedido.Text = controle.GetProximoId().ToString();

            HabilitaAcaoMenu(true);
            AtualizaTotais();*/
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = ColumnSelected + "  LIKE '%" + txtPesquisa.Text + "%'";
            GridProdutos.DataSource = dv;
        }
        private void GridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            ItemSelecionadoVendaDTO item = new ItemSelecionadoVendaDTO();
            FormVenSelecaoItem FormItem = new FormVenSelecaoItem();

            item.idProduto        = GridProdutos.CurrentRow.Cells["idproduto"].Value.ToString();
            item.produtoDescricao = GridProdutos.CurrentRow.Cells["produtodescricao"].Value.ToString();
            item.qtdeDisponivel   = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["saldoestoque"].Value.ToString());

            if (GridProdutos.CurrentRow.Cells["qtde"].Value.ToString() != "0,00" ) 
                item.qtde = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["qtde"].Value.ToString());
            else
                item.qtde = 1.00m;

            item.vlrUnitario = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrunitario"].Value.ToString());
            item.vlrDesconto = Convert.ToDecimal(GridProdutos.CurrentRow.Cells["vlrdesconto"].Value.ToString());    

            FormItem.FItem = item;
            var Result = FormItem.ShowDialog();


            if (Result == DialogResult.OK)
            {
                if (FormItem.FItem.qtde > 0)
                {
                    GridProdutos.CurrentRow.Cells["check"].Value = LaPizza.Properties.Resources.CheckVenda;
                    GridProdutos.CurrentRow.Cells["marcado"].Value = true;
                }
                else
                {
                    GridProdutos.CurrentRow.Cells["check"].Value = LaPizza.Properties.Resources.vazio;
                    GridProdutos.CurrentRow.Cells["marcado"].Value = false;
                }

                GridProdutos.CurrentRow.Cells["qtde"].Value = FormItem.FItem.qtde.ToString("N2");
                GridProdutos.CurrentRow.Cells["vlrdesconto"].Value = FormItem.FItem.vlrDesconto.ToString("N2");
                GridProdutos.CurrentRow.Cells["vlrliquido"].Value = FormItem.FItem.getVlrLiquido().ToString("N2");

                AtualizaTotais();
            }

            HabilitaAcao(TipoAcao.Confirmar, ExisteItemLancadoPedido());
            HabilitaAcao(TipoAcao.Cancelar, ExisteItemLancadoPedido());*/
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

        private bool ExisteItemLancadoPedido()
        {
            int count = 0;
            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                if ((bool)row.Cells["marcado"].Value == true)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
                return true;
            else
                return false;
        }

        private void AtualizaTotais()
        {
            decimal TotalBruto    = 0m;
            decimal TotalDescontos = 0m;

            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                
                decimal qtde         = Convert.ToDecimal(row.Cells["qtde"].Value.ToString());
                decimal desconto     = Convert.ToDecimal(row.Cells["vlrdesconto"].Value.ToString());
                decimal vlrunitario  = Convert.ToDecimal(row.Cells["vlrunitario"].Value.ToString());
                decimal vlrliquido   = Convert.ToDecimal(row.Cells["vlrliquido"].Value.ToString());

                TotalBruto          += qtde * vlrunitario;
                TotalDescontos      += desconto;
            }

            lbTotalBruto.Text     = TotalBruto.ToString("C");
            lbTotalDescontos.Text = TotalDescontos.ToString("C");
            lbTotalLiquido.Text   = (TotalBruto - TotalDescontos).ToString("C");
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[GridProdutos.DataSource];
            cm.EndCurrentEdit();
            cm.SuspendBinding();
            cm.ResumeBinding();

            if (btnCarrinho.Tag.ToString() == "Lista")
            {
                btnCarrinho.Tag = "Carrinho";
                btnCarrinho.BackgroundImage = Properties.Resources.CarrinhoComprasHover;
            }
            else
            {
                btnCarrinho.Tag = "Lista";
                btnCarrinho.BackgroundImage = Properties.Resources.CarrinhoCompras;
            }
                
            if (btnCarrinho.Tag.ToString() == "Lista")
            {
                foreach (DataGridViewRow row in GridProdutos.Rows)
                    row.Visible = true;
            }
            else
            {
                foreach (DataGridViewRow row in GridProdutos.Rows)
                {
                    if ((bool)row.Cells["marcado"].Value == true)
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FPedido.idpedido = Convert.ToInt32(lbNumeroPedido.Text);
            FPedido.idficha = cbFicha.SelectedIndex + 1;
            FPedido.idtipopedido = cbTipoPedido.SelectedIndex + 1;
            FPedido.vlrtotalbruto = Convert.ToDecimal(lbTotalBruto.Text.Replace("R$ ", ""));
            FPedido.vlrtotaldescontos = Convert.ToDecimal(lbTotalDescontos.Text.Replace("R$ ", ""));

            foreach (DataGridViewRow row in GridProdutos.Rows)
            {
                if ((bool)row.Cells["marcado"].Value)
                {
                    PedidoVendaItemDB itemDB = new PedidoVendaItemDB();
                    itemDB.idpedido = Convert.ToInt32(lbNumeroPedido.Text);
                    itemDB.idproduto = (int)row.Cells["idproduto"].Value;
                    itemDB.qtde = (decimal)row.Cells["qtde"].Value;
                    itemDB.vlrunitario = (decimal)row.Cells["vlrunitario"].Value;
                    itemDB.vlrdesconto = (decimal)row.Cells["vlrdesconto"].Value;
                    itemDB.vlrbruto = (decimal)row.Cells["qtde"].Value * (decimal)row.Cells["vlrunitario"].Value;

                    FPedido.items.Add(itemDB);
                }
            }

            PedidoVendaController controle = new PedidoVendaController();

            if (MenuStatus == null)
                controle.Adicionar(FPedido);
            else if (MenuStatus == MStatus.Consultando)
                controle.Consultar(FPedido);
            else if (MenuStatus == MStatus.Excluindo)
                controle.Excluir(Convert.ToInt32(lbNumeroPedido.Text));

            //else if (MenuStatus == MStatus.Excluindo)
            //controle.Excluir(FPedido);


            lbNumeroPedido.Text = controle.GetProximoId().ToString();
            FPedido.items.Clear();
            CarregarListaGrid();
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtCliente.Text = string.Empty;
            txtFormaPagamento.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
            AlimentaTodosComboBox();
            AtualizaTotais();
        }

        private void GridProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                //GridProdutos_CellDoubleClick(sender, GridProdutos.CurrentCell.DataGridView.get );
            }
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
                txtFormaPagamento.Text = Pesq.PesqPedido.idformapagamento + " - " + Pesq.PesqPedido.formapagamentodescricao;
                FPedido.idformapagamento = Pesq.PesqPedido.idformapagamento;
                lbNumeroPedido.Text = Pesq.PesqPedido.idpedido.ToString();

                foreach(DataGridViewRow row in GridProdutos.Rows)
                {
                    foreach(PedidoVendaItemDTO item in Pesq.PesqPedido.itens)
                    {
                        if ((int)row.Cells["idproduto"].Value == item.idproduto)
                        {
                            row.Cells["marcado"].Value     = true;
                            row.Cells["check"].Value       = Properties.Resources.CheckVenda;
                            row.Cells["qtde"].Value        = item.qtde.ToString("N2");
                            row.Cells["vlrdesconto"].Value = item.vlrdesconto.ToString("N2");
                            row.Cells["vlrliquido"].Value  = ((item.qtde * item.vlrunitario) - item.vlrdesconto).ToString("N2");
                        }
                    }
                }

                lbTotalBruto.Text = Pesq.PesqPedido.vlrtotalbruto.ToString("C");
                lbTotalDescontos.Text = Pesq.PesqPedido.vlrtotaldescontos.ToString("C");
                lbTotalLiquido.Text = (Pesq.PesqPedido.vlrtotalbruto - Pesq.PesqPedido.vlrtotaldescontos).ToString("C");

                HabilitaAcao(TipoAcao.Confirmar, ExisteItemLancadoPedido());
                HabilitaAcao(TipoAcao.Cancelar, ExisteItemLancadoPedido());
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
                txtFormaPagamento.Text = Pesq.PesqPedido.idformapagamento + " - " + Pesq.PesqPedido.formapagamentodescricao;
                lbNumeroPedido.Text = Pesq.PesqPedido.idpedido.ToString();

                foreach (DataGridViewRow row in GridProdutos.Rows)
                {
                    foreach (PedidoVendaItemDTO item in Pesq.PesqPedido.itens)
                    {
                        if ((int)row.Cells["idproduto"].Value == item.idproduto)
                        {
                            row.Cells["marcado"].Value = true;
                            row.Cells["check"].Value = Properties.Resources.CheckVenda;
                            row.Cells["qtde"].Value = item.qtde.ToString("N2");
                            row.Cells["vlrdesconto"].Value = item.vlrdesconto.ToString("N2");
                            row.Cells["vlrliquido"].Value = ((item.qtde * item.vlrunitario) - item.vlrdesconto).ToString("N2");
                        }
                    }
                }

                lbTotalBruto.Text = Pesq.PesqPedido.vlrtotalbruto.ToString("C");
                lbTotalDescontos.Text = Pesq.PesqPedido.vlrtotaldescontos.ToString("C");
                lbTotalLiquido.Text = (Pesq.PesqPedido.vlrtotalbruto - Pesq.PesqPedido.vlrtotaldescontos).ToString("C");

                HabilitaAcao(TipoAcao.Confirmar, ExisteItemLancadoPedido());
                HabilitaAcao(TipoAcao.Cancelar, ExisteItemLancadoPedido());
            }
            else
            {
                btnCancelar_Click(sender, e);
            }
        }

        private void GridProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ColumnSelected = dt.Columns[e.ColumnIndex].ColumnName;
            lbPesquisa.Text = "Pesquisa por (";
        }
    }
}
