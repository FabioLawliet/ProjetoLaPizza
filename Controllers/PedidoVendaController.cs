﻿using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class PedidoVendaController
    {
        public void Adicionar(PedidoVendaDB PedidoVenda)
        {
            Context db = new Context();
            try
            {
                db.pedidovenda.Add(PedidoVenda);
                db.SaveChanges();
                db.pedidovendaItem.AddRange(PedidoVenda.items);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar o pedido de venda, feche a rotina de vendas e tente novamente! \n\n" + ex.Message,
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Consultar(PedidoVendaDB PedidoVenda)
        {
            Context db = new Context();
            PedidoVendaDB Pedido = db.pedidovenda.FirstOrDefault(p => p.idpedido == PedidoVenda.idpedido);
            List<PedidoVendaItemDB> listaItemDB = db.pedidovendaItem.Where(p => p.idpedido == PedidoVenda.idpedido).ToList();
            if (Pedido != null)
            {
                try
                {
                    db.pedidovendaItem.RemoveRange(listaItemDB);
                    db.SaveChanges();

                    Pedido.idcliente = PedidoVenda.idcliente;
                    Pedido.idformapagamento = PedidoVenda.idformapagamento;
                    Pedido.idficha = PedidoVenda.idficha;
                    Pedido.idtipopedido = PedidoVenda.idtipopedido;
                    Pedido.status = PedidoVenda.status;
                    Pedido.vlrtotalbruto = PedidoVenda.vlrtotalbruto;
                    Pedido.vlrtotaldescontos = PedidoVenda.vlrtotaldescontos;

                    db.pedidovendaItem.AddRange(PedidoVenda.items);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao salvar as edições feitas na Venda, feche a rotina e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /*
        public bool ExisteSubgrupo(int IdGrupo, int IdSubgrupo)
        {
            Context db = new Context();
            SubgrupoDB subgrupo = db.subgrupo.Where(p => p.idgrupo == IdGrupo).FirstOrDefault(p => p.idsubgrupo == IdSubgrupo);

            if (subgrupo != null && subgrupo.idgrupo == IdGrupo && subgrupo.idsubgrupo == IdSubgrupo)
                return true;
            else
                return false;
        }
        public SubgrupoDTO GetSubgrupo(int IdGrupo, int IdSubgrupo)
        {
            Context db = new Context();
            SubgrupoDB subgrupo = db.subgrupo.Where(p => p.idgrupo == IdGrupo).FirstOrDefault(p => p.idsubgrupo == IdSubgrupo);
            SubgrupoDTO subgrupoModel = new SubgrupoDTO();

            if (subgrupo != null && subgrupo.idgrupo == IdGrupo && subgrupo.idsubgrupo == IdSubgrupo)
            {
                subgrupoModel.idsubgrupo = subgrupo.idsubgrupo;
                subgrupoModel.descricao = subgrupo.descricao;
                subgrupoModel.idgrupo = subgrupo.idgrupo;
                subgrupoModel.ativo = subgrupo.ativo;

                return subgrupoModel;
            }
            else
                return null;
        }

        public List<SubgrupoDTO> GetSubgrupoLista(int IdGrupo)
        {
            Context db = new Context();
            List<SubgrupoDTO> lista = (from subgrupo in db.subgrupo
                                       where subgrupo.idgrupo == IdGrupo
                                       orderby subgrupo.idsubgrupo
                                       select new SubgrupoDTO
                                       {
                                           idsubgrupo = subgrupo.idsubgrupo,
                                           descricao = subgrupo.descricao,
                                           idgrupo = subgrupo.idsubgrupo,
                                           ativo = subgrupo.ativo
                                       }).ToList();
            return lista;
        }*/

        public void Excluir(int idPedido)
        {
            Context db = new Context();
            PedidoVendaDB pedido = db.pedidovenda.FirstOrDefault(p => p.idpedido == idPedido);
            List<PedidoVendaItemDB> itens = db.pedidovendaItem.Where(p => p.idpedido == idPedido).ToList();

            if (pedido != null && itens != null)
            {
                try
                {
                    db.pedidovendaItem.RemoveRange(itens);
                    db.SaveChanges();
                    db.pedidovenda.Remove(pedido);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o pedido, provavelmente existem movimentações no banco de dados para este pedido e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public int GetProximoId()
        {
            Context db = new Context();
            return db.Database.SqlQuery<int>("select last_value from public.pedidovenda_seq").Single()+1;
        }

        public List<PedidoVendaDTO> GetPedidos()
        {
            Context db = new Context();
            List<PedidoVendaDTO> lista = (from pedido in db.pedidovenda
                                          join tp in db.tipopedido on pedido.idtipopedido equals tp.idtipopedido
                                          join cliente in db.cliente on pedido.idcliente equals cliente.idcliente
                                          join pag in db.formapagamento on pedido.idformapagamento equals pag.idformapagamento
                                          where pedido.status == "ABERTO"
                                          orderby pedido.idpedido
                                          select new PedidoVendaDTO
                                          {
                                              idpedido                = pedido.idpedido,
                                              idficha                 = pedido.idficha,
                                              idtipopedido            = pedido.idtipopedido,
                                              tipopedidodescricao     = tp.descricao,
                                              idcliente               = pedido.idcliente,
                                              clientenome             = cliente.nomerazao,
                                              idformapagamento        = pedido.idformapagamento,
                                              formapagamentodescricao = pag.descricao, 
                                              dataabertura            = pedido.dataabertura,
                                              vlrtotaldescontos       = pedido.vlrtotaldescontos,
                                              vlrtotalbruto           = pedido.vlrtotalbruto,
                                          }).ToList();

            return lista;
        }

        public PedidoVendaDTO GetPedidoId(int Id)
        {
            Context db = new Context();

            PedidoVendaDTO pedido = (from ped in db.pedidovenda
                                    join tp in db.tipopedido on ped.idtipopedido equals tp.idtipopedido
                                    join cliente in db.cliente on ped.idcliente equals cliente.idcliente
                                    join pag in db.formapagamento on ped.idformapagamento equals pag.idformapagamento
                                    where ped.idpedido == Id
                                    select new PedidoVendaDTO
                                    {
                                        idpedido = ped.idpedido,
                                        idficha = ped.idficha,
                                        status = ped.status,
                                        idtipopedido = ped.idtipopedido,
                                        tipopedidodescricao = tp.descricao,
                                        idcliente = ped.idcliente,
                                        clientenome = cliente.nomerazao,
                                        idformapagamento = ped.idformapagamento,
                                        formapagamentodescricao = pag.descricao,
                                        dataabertura = ped.dataabertura,
                                        vlrtotaldescontos = ped.vlrtotaldescontos,
                                        vlrtotalbruto = ped.vlrtotalbruto,
                                    }).FirstOrDefault();

            List<PedidoVendaItemDTO> listaItens = (from item in db.pedidovendaItem
                                                   join prod in db.produto on item.idproduto equals prod.idproduto
                                                   join unid in db.unidademedida on prod.idunidmedida equals unid.idunidmedida
                                                   where item.idpedido == Id
                                                   select new PedidoVendaItemDTO
                                                   {
                                                    marcado = false,
                                                    id = item.iditem,
                                                    idpedido = item.idpedido,
                                                    idproduto = item.idproduto,
                                                    produtodescricao = prod.descricao,
                                                    idunidmedida = prod.idunidmedida,
                                                    unidademedidasigla = unid.sigla,
                                                    saldoestoque = prod.saldoestoque,
                                                    qtde = item.qtde,
                                                    vlrunitario = item.vlrunitario,
                                                    vlrdesconto = item.vlrdesconto,
                                                    vlrliquido = item.vlrbruto - item.vlrdesconto,
                                                   }).ToList();

            if (listaItens.Count > 1)
                pedido.itens.AddRange(listaItens);
            
            return pedido;
        }

        public List<PedidoVendaItemDTO> GetProdutos()
        {
            Context db = new Context();
            List<PedidoVendaItemDTO> lista = (from produto in db.produto
                                              join unidade in db.unidademedida on produto.idunidmedida equals unidade.idunidmedida
                                              orderby produto.idproduto
                                              select new PedidoVendaItemDTO
                                              {
                                                  marcado = false,
                                                  idproduto = produto.idproduto,
                                                  produtodescricao = produto.descricao,
                                                  idunidmedida = unidade.idunidmedida,
                                                  unidademedidasigla = unidade.sigla,
                                                  saldoestoque = produto.saldoestoque,
                                                  qtde = 0.00m,
                                                  vlrunitario = produto.precoatual,
                                                  vlrdesconto = 0.00m,
                                                  vlrdescontoperc = "0,00%",
                                                  vlrliquido = 0.00m
                                              }).ToList();
            return lista;
        }
        /*
        public List<SubgrupoDTO> GetSubgrupoPesquisaGrid(int IdGrupo, string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<SubgrupoDTO> lista = (from subgrupo in db.subgrupo
                                       where subgrupo.idgrupo == IdGrupo
                                       orderby subgrupo.idsubgrupo
                                       select new SubgrupoDTO
                                       {
                                           idsubgrupo = subgrupo.idsubgrupo,
                                           descricao = subgrupo.descricao,
                                           idgrupo = subgrupo.idsubgrupo,
                                           ativo = subgrupo.ativo
                                       }).ToList();

            switch (ColunaPesquisa)
            {
                case "idsubgrupo":
                    return new List<SubgrupoDTO>(lista.Where(p => p.idgrupo.ToString() == TextoPesquisa));
                case "descricao":
                    return new List<SubgrupoDTO>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }*/
    }
}
