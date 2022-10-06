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

            cbFormaPagamento.Items.Add("");
            foreach (FormaPagamentoDTO pag in ListaPagamentos){
                cbFormaPagamento.Items.Add(pag.descricao);
            }
            cbFormaPagamento.SelectedIndex = -1;
        }

        public void PopularCbStatus()
        {
            cbStatus.Items.Add("");
            cbStatus.Items.Add("Aberto");
            cbStatus.Items.Add("Fechado");            
            cbStatus.SelectedIndex = 0;
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

            lista = new List<PedidoVendaDTO>(lista.Where(p =>(p.dataabertura >= dtInicial.Value.AddDays(-1) && p.dataabertura <= dtFinal.Value)));

            if (cbStatus.SelectedIndex == 1)
                lista = new List<PedidoVendaDTO>(lista.Where(p => p.status == "ABERTO"));
            else if (cbStatus.SelectedIndex == 2)
                lista = new List<PedidoVendaDTO>(lista.Where(p => p.status == "FECHADO"));

            if (cbFormaPagamento.SelectedIndex >= 1)
                lista = new List<PedidoVendaDTO>(lista.Where(p => p.idformapagamento == (cbFormaPagamento.SelectedIndex)));            

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
            
            if (GridPedidos.RowCount <= 0)
            {
                GridPedidos.DataSource = null;
                MessageBox.Show("Não foi encontrado nenhum pedido com os filtros informados!", "informação", MessageBoxButtons.OK);
            }
            else
            {
                AjustaGridPedidos();
                GridPedidos.RowHeadersVisible = true;
                GridPedidos.Enabled = true;
                AlimentaProdutosPedido(Convert.ToInt32(GridPedidos.Rows[0].Cells["idpedido"].Value));
                btnPesquisar.BackColor = btnCancelar.BackColor;
                HabilitaAcao(TipoAcao.Cancelar, true);
                BoxFiltro.Enabled = false;
            }          
        }

        private void AjustaGridPedidos()
        {
            for (int i = 0; i < GridPedidos.Columns.Count; i++)
                GridPedidos.Columns[i].Visible = false;

            GridPedidos.Columns["idpedido"].DisplayIndex = 0;
            GridPedidos.Columns["idpedido"].HeaderText = "Pedido";
            GridPedidos.Columns["idpedido"].Width = 50;
            GridPedidos.Columns["idpedido"].Visible = true;

            GridPedidos.Columns["dataabertura"].DisplayIndex = 1;
            GridPedidos.Columns["dataabertura"].HeaderText = "Data Abertura";
            GridPedidos.Columns["dataabertura"].Width = 90;
            GridPedidos.Columns["dataabertura"].Visible = true;

            GridPedidos.Columns["status"].DisplayIndex = 2;
            GridPedidos.Columns["status"].HeaderText = "Status";
            GridPedidos.Columns["status"].Width = 80;
            GridPedidos.Columns["status"].Visible = true;

            GridPedidos.Columns["clientenome"].DisplayIndex = 3;
            GridPedidos.Columns["clientenome"].HeaderText = "Cliente";
            GridPedidos.Columns["clientenome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridPedidos.Columns["clientenome"].Width = 100;
            GridPedidos.Columns["clientenome"].Visible = true;

            GridPedidos.Columns["formapagamentodescricao"].DisplayIndex = 4;
            GridPedidos.Columns["formapagamentodescricao"].HeaderText = "Form. Pagto";
            GridPedidos.Columns["formapagamentodescricao"].Width = 140;
            GridPedidos.Columns["formapagamentodescricao"].Visible = true;

            GridPedidos.Columns["tipopedidodescricao"].DisplayIndex = 5;
            GridPedidos.Columns["tipopedidodescricao"].HeaderText = "Tipo Pedido";
            GridPedidos.Columns["tipopedidodescricao"].Width = 100;
            GridPedidos.Columns["tipopedidodescricao"].Visible = true;

            GridPedidos.Columns["vlrtotaldescontos"].DisplayIndex = 6;
            GridPedidos.Columns["vlrtotaldescontos"].HeaderText = "Desconto";
            GridPedidos.Columns["vlrtotaldescontos"].Width = 90;
            GridPedidos.Columns["vlrtotaldescontos"].Visible = true;

            GridPedidos.Columns["vlrtotalbruto"].DisplayIndex = 7;
            GridPedidos.Columns["vlrtotalbruto"].HeaderText = "Valor Bruto";
            GridPedidos.Columns["vlrtotalbruto"].Width = 90;
            GridPedidos.Columns["vlrtotalbruto"].Visible = true;
        }

        private void GridPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                AlimentaProdutosPedido(Convert.ToInt32(GridPedidos.Rows[e.RowIndex].Cells["idpedido"].Value));         
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

            GridProdutos.Columns["idproduto"].DisplayIndex = 0;
            GridProdutos.Columns["idproduto"].HeaderText = "Produto";
            GridProdutos.Columns["idproduto"].Width = 50;
            GridProdutos.Columns["idproduto"].Visible = true;

            GridProdutos.Columns["produtodescricao"].DisplayIndex = 1;
            GridProdutos.Columns["produtodescricao"].HeaderText = "Descrição";
            GridProdutos.Columns["produtodescricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridProdutos.Columns["produtodescricao"].Visible = true;

            GridProdutos.Columns["qtde"].DisplayIndex = 2;
            GridProdutos.Columns["qtde"].HeaderText = "Quantidade";
            GridProdutos.Columns["qtde"].Width = 80;
            GridProdutos.Columns["qtde"].Visible = true;

            GridProdutos.Columns["vlrunitario"].DisplayIndex = 3;
            GridProdutos.Columns["vlrunitario"].HeaderText = "Vlr. Unit.";
            GridProdutos.Columns["vlrunitario"].Width = 90;
            GridProdutos.Columns["vlrunitario"].Visible = true;

            GridProdutos.Columns["vlrdesconto"].DisplayIndex = 4;
            GridProdutos.Columns["vlrdesconto"].HeaderText = "Vlr. Desc.";
            GridProdutos.Columns["vlrdesconto"].Width = 90;
            GridProdutos.Columns["vlrdesconto"].Visible = true;

            GridProdutos.Columns["vlrbruto"].DisplayIndex = 5;
            GridProdutos.Columns["vlrbruto"].HeaderText = "Vlr Bruto";
            GridProdutos.Columns["vlrbruto"].Width = 90;
            GridProdutos.Columns["vlrbruto"].Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, false);

            GridPedidos.DataSource = null;
            GridProdutos.DataSource = null;
            btnPesquisar.BackColor = btnSair.BackColor;

            BoxFiltro.Enabled = true;
        }
    }
}
