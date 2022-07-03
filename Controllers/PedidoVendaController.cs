using LaPizza.DAO;
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

        /*public void Editar(SubgrupoDB Subgrupo)
        {
            Context db = new Context();
            SubgrupoDB subgrupo = db.subgrupo.Where(p => p.idgrupo == Subgrupo.idgrupo).FirstOrDefault(p => p.idsubgrupo == Subgrupo.idsubgrupo);

            if (subgrupo != null)
            {
                try
                {
                    subgrupo.idsubgrupo = Subgrupo.idsubgrupo;
                    subgrupo.descricao = Subgrupo.descricao;
                    subgrupo.idgrupo = Subgrupo.idgrupo;
                    subgrupo.ativo = Subgrupo.ativo;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar o subgrupo, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Excluir(int IdGrupo, int IdSubgrupo)
        {
            Context db = new Context();
            SubgrupoDB subgrupo = db.subgrupo.Where(p => p.idgrupo == IdGrupo).FirstOrDefault(p => p.idsubgrupo == IdSubgrupo);

            if (subgrupo != null)
            {
                try
                {
                    db.subgrupo.Remove(subgrupo);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o subgrupo, provavelmente existem movimentações no banco de dados para este subgrupo e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
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

        public int GetProximoId()
        {
            Context db = new Context();
            return db.Database.SqlQuery<int>("select last_value from public.pedidovenda_seq").Single()+1;
        }

        public List<PedidoVendaItemDTO> GetPedidoVendaItens()
        {
            Context db = new Context();
            List<PedidoVendaItemDTO> lista = (from produto in db.produto
                                              join unidade in db.unidademedida on produto.idunidmedida equals unidade.idunidmedida
                                              orderby produto.idproduto
                                              select new PedidoVendaItemDTO
                                              {
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
