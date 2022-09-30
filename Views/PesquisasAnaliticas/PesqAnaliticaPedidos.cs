using LaPizza.DAO;
using LaPizza.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LaPizza.Controllers;

namespace LaPizza.Views.PesquisasAnaliticas
{
    public partial class PesqAnaliticaPedidos : LaPizza.Views.FormBaseCadastros
    {
        public PesqAnaliticaPedidos()
        {
            InitializeComponent();
            PopularCbFormaPagamento();
            PopularCbStatus();
        }

        public void PopularCbFormaPagamento()
        {
            Context db = new Context();
            FormaPagamentoController control = new FormaPagamentoController();
            List<FormaPagamentoDTO> ListaPagamentos = control.GetFormaPagamentoLista();

            foreach(FormaPagamentoDTO pag in ListaPagamentos){
                cbFormaPagamento.Items.Add(pag.descricao);
            }
            cbFormaPagamento.SelectedIndex = -1;
        }

        public void PopularCbStatus()
        {
            cbStatus.Items.Add("Fechado");
            cbStatus.Items.Add("Aberto");
            cbStatus.SelectedIndex = -1;
        }
        public List<PedidoVendaDTO> getListaPedidos()
        {
            Context db = new Context();
            List<PedidoVendaDTO> lista = (from pedido in db.pedidovenda
                                          join tp in db.tipopedido on pedido.idtipopedido equals tp.idtipopedido
                                          join cliente in db.cliente on pedido.idcliente equals cliente.idcliente
                                          join pag in db.formapagamento on pedido.idformapagamento equals pag.idformapagamento
                                          orderby pedido.idpedido
                                          select new PedidoVendaDTO
                                          {
                                              idpedido = pedido.idpedido,
                                              idtipopedido = pedido.idtipopedido,
                                              tipopedidodescricao = tp.descricao,
                                              clientenome = pedido.idcliente + " - " + cliente.nomerazao,
                                              idformapagamento = pag.idformapagamento,
                                              formapagamentodescricao = pedido.idformapagamento + " - " + pag.descricao,
                                              dataabertura = pedido.dataabertura,
                                              datafechamento = pedido.datafechamento,
                                              status = pedido.status,
                                              vlrtotaldescontos = pedido.vlrtotaldescontos,
                                              vlrtotalbruto = pedido.vlrtotalbruto,
                                          }).ToList();

            lista = new List<PedidoVendaDTO>(lista.Where(p => p.dataabertura >= dtInicial.Value && p.dataabertura <= dtFinal.Value));

            if (cbStatus.SelectedIndex == 1)
                lista = new List<PedidoVendaDTO>(lista.Where(p => p.status == "ABR"));
            else if (cbStatus.SelectedIndex == 0)
                lista = new List<PedidoVendaDTO>(lista.Where(p => p.status == "FEC"));

            if (cbFormaPagamento.SelectedIndex >= 0)
                lista = new List<PedidoVendaDTO>(lista.Where(p => p.idformapagamento == (cbFormaPagamento.SelectedIndex + 1)));            

            return lista;
        }

        public List<PedidoVendaItemDTO> getProdutos(int PedidoId)
        {
            Context db = new Context();
            List<PedidoVendaItemDTO> listaItens = (from item in db.pedidovendaItem
                                                   join prod in db.produto on item.idproduto equals prod.idproduto
                                                   where item.idpedido == PedidoId
                                                   select new PedidoVendaItemDTO
                                                   {
                                                       idproduto = item.idproduto,
                                                       produtodescricao = prod.descricao,
                                                       qtde = item.qtde,
                                                       vlrunitario = item.vlrunitario,
                                                       vlrdesconto = item.vlrdesconto,
                                                       vlrbruto = item.vlrbruto,
                                                   }).ToList();
            return listaItens;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GridPedidos.DataSource = getListaPedidos();
            AjustaGridPedidos();

            if (GridPedidos.RowCount > 0)
                AlimentaProdutosPedido(Convert.ToInt32(GridPedidos.Rows[1].Cells["PedidoColId"].Value));

            HabilitaAcao(TipoAcao.Cancelar, true);
            BoxFiltro.Enabled = false;
        }

        private void AjustaGridPedidos()
        {
            for (int i = 0; i < GridPedidos.Columns.Count; i++)
                GridPedidos.Columns[i].Visible = false;

            GridPedidos.Columns["PedidoColId"].DisplayIndex = 0;
            GridPedidos.Columns["PedidoColId"].Visible = true;
            GridPedidos.Columns["PedidoColAbertura"].DisplayIndex = 1;
            GridPedidos.Columns["PedidoColAbertura"].Visible = true;
            GridPedidos.Columns["PedidoColFechamento"].DisplayIndex = 2;
            GridPedidos.Columns["PedidoColFechamento"].Visible = true;
            GridPedidos.Columns["PedidoColCliente"].DisplayIndex = 3;
            GridPedidos.Columns["PedidoColCliente"].Visible = true;
            GridPedidos.Columns["PedidoColPagamento"].DisplayIndex = 4;
            GridPedidos.Columns["PedidoColPagamento"].Visible = true;
            GridPedidos.Columns["PedidoColTipoPedido"].DisplayIndex = 5;
            GridPedidos.Columns["PedidoColTipoPedido"].Visible = true;
            GridPedidos.Columns["PedidoColDescontos"].DisplayIndex = 6;
            GridPedidos.Columns["PedidoColDescontos"].Visible = true;
            GridPedidos.Columns["PedidoColVlrBruto"].DisplayIndex = 7;
            GridPedidos.Columns["PedidoColVlrBruto"].Visible = true;
        }

        private void GridPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AlimentaProdutosPedido(Convert.ToInt32(GridPedidos.Rows[e.RowIndex].Cells["PedidoColId"].Value));         
        }

        private void AlimentaProdutosPedido(int PedidoId)
        {
            GridProdutos.DataSource = getProdutos(PedidoId);
            AjustaGridProdutos();
        }

        private void AjustaGridProdutos()
        {
            for (int i = 0; i < GridProdutos.Columns.Count; i++)
                GridProdutos.Columns[i].Visible = false;

            GridProdutos.Columns["ProdutoColId"].DisplayIndex = 0;
            GridProdutos.Columns["ProdutoColId"].Visible = true;
            GridProdutos.Columns["ProdutoColDescricao"].DisplayIndex = 1;
            GridProdutos.Columns["ProdutoColDescricao"].Visible = true;
            GridProdutos.Columns["ProdutoColqtde"].DisplayIndex = 2;
            GridProdutos.Columns["ProdutoColqtde"].Visible = true;
            GridProdutos.Columns["ProdutoColVlrUnitario"].DisplayIndex = 3;
            GridProdutos.Columns["ProdutoColVlrUnitario"].Visible = true;
            GridProdutos.Columns["ProdutoColVlrDesconto"].DisplayIndex = 4;
            GridProdutos.Columns["ProdutoColVlrDesconto"].Visible = true;
            GridProdutos.Columns["ProdutoColVlrBruto"].DisplayIndex = 5;
            GridProdutos.Columns["ProdutoColVlrBruto"].Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, false);

            GridPedidos.DataSource = new List<PedidoVendaDTO>();
            GridProdutos.DataSource = new List<PedidoVendaItemDTO>();

            BoxFiltro.Enabled = true;
        }
    }
}
