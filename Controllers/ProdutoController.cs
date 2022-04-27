using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace LaPizza.Controllers
{
    public class ProdutoController
    {
        public void Adicionar(ProdutoDto Produto)
        {
            Context db = new Context();
            db.produto.Add(Produto);
            db.SaveChanges();
        }

        public void Editar(ProdutoDto Produto)
        {
            Context db = new Context();
            ProdutoDto pro = db.produto.FirstOrDefault(p => p.id == Produto.id);
            pro.id = Produto.id;
            pro.descricao = Produto.descricao;
            pro.datacadastro = Produto.datacadastro.ToString();
            pro.ativo = Produto.ativo;
            pro.idgrupo = Produto.idgrupo;
            pro.idsubgrupo = Produto.idsubgrupo;
            pro.idmarca = Produto.idmarca;
            pro.codigofabricante = Produto.codigofabricante;
            pro.infadicionais = Produto.infadicionais;
            pro.saldoestoque = Produto.saldoestoque;
            pro.qtdeestideal = Produto.qtdeestideal;
            pro.qtdeestmin = Produto.qtdeestmin;
            pro.qtdeestmax = Produto.qtdeestmax;
            pro.precoanterior = Produto.precoanterior;
            pro.precoatual = Produto.precoatual;
            db.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            ProdutoDto pro = db.produto.FirstOrDefault(p => p.id == Id);
            try
            {
                db.produto.Remove(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.SaveChanges();
            }
        }

        public bool ExisteId(int Id)
        {
            Context db = new Context();
            var pro = db.produto.Where(p => p.id == Id).FirstOrDefault();

            if (pro is null)
                return false;
            else
                return true;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var pro = db.produto.FirstOrDefault();

            if (pro is null)
                return 1;
            else
                return db.produto.Max(p => p.id) + 1;
        }

        public ProdutoModel GetProduto(int Id)
        {
            Context db = new Context();
            List<ProdutoModel> Lista = (from produto in db.produto
                                        join marca in db.marca on produto.idmarca equals marca.id
                                        join grupo in db.grupo on produto.idgrupo equals grupo.id
                                        join subgrupo in db.subgrupo on produto.idsubgrupo equals subgrupo.id
                                        where produto.id == Id
                                        select new ProdutoModel
                                        {
                                            id = produto.id,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupoDescricao = grupo.descricao.ToString(),
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupoDescricao = subgrupo.descricao.ToString(),
                                            idmarca = produto.idmarca,
                                            marcaDescricao = marca.descricao,
                                            codigoFabricante = produto.codigofabricante,
                                            infAdicionais = produto.infadicionais,
                                            saldoEstoque = produto.saldoestoque,
                                            unidadeMedida = produto.unidademedida,
                                            qtdeEstMin = produto.qtdeestmin,
                                            qtdeEstIdeal = produto.qtdeestideal,
                                            qtdeEstMax = produto.qtdeestmax,
                                            precoAnterior = produto.precoanterior,
                                            precoAtual = produto.precoatual
                                        }).ToList();

            return Lista.FirstOrDefault();
        }
        public List<ProdutoModel> GetProdutoLista()
        {
            Context db = new Context();
            List<ProdutoModel> Lista = (from produto in db.produto
                                        join marca in db.marca on produto.idmarca equals marca.id
                                        join grupo in db.grupo on produto.idgrupo equals grupo.id
                                        join subgrupo in db.subgrupo on produto.idsubgrupo equals subgrupo.id
                                        orderby produto.id
                                        select new ProdutoModel
                                        {
                                            id = produto.id,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupoDescricao = grupo.descricao.ToString(),
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupoDescricao = subgrupo.descricao.ToString(),
                                            idmarca = produto.idmarca,
                                            marcaDescricao = marca.descricao,
                                            codigoFabricante = produto.codigofabricante,
                                            infAdicionais = produto.infadicionais,
                                            saldoEstoque = produto.saldoestoque,
                                            unidadeMedida = produto.unidademedida,
                                            qtdeEstMin = produto.qtdeestmin,
                                            qtdeEstIdeal = produto.qtdeestideal,
                                            qtdeEstMax = produto.qtdeestmax,
                                            precoAnterior = produto.precoanterior,
                                            precoAtual = produto.precoatual
                                        }).ToList();
            return Lista;
        }

        public List<ProdutoModel> GetProdutoPesquisa(string Descricao)
        {
            Descricao = Descricao.ToUpper() ;

            Context db = new Context();
            List<ProdutoModel> Lista = (from produto in db.produto
                                               join marca in db.marca on produto.idmarca equals marca.id
                                               join grupo in db.grupo on produto.idgrupo equals grupo.id
                                               join subgrupo in db.subgrupo on produto.idsubgrupo equals subgrupo.id
                                               orderby produto.id
                                               select new ProdutoModel
                                               {
                                                   id = produto.id,
                                                   descricao = produto.descricao,
                                                   //dataCadastro = produto.datacadastro.ToString(),
                                                   ativo = produto.ativo,
                                                   idgrupo = produto.idgrupo,
                                                   grupoDescricao = grupo.descricao.ToString(),
                                                   idsubgrupo = produto.idsubgrupo,
                                                   subgrupoDescricao = subgrupo.descricao.ToString(),
                                                   idmarca = produto.idmarca,
                                                   marcaDescricao = marca.descricao,
                                                   codigoFabricante = produto.codigofabricante,
                                                   infAdicionais = produto.infadicionais,
                                                   saldoEstoque = produto.saldoestoque,
                                                   unidadeMedida = produto.unidademedida,
                                                   qtdeEstMin = produto.qtdeestmin,
                                                   qtdeEstIdeal = produto.qtdeestideal,
                                                   qtdeEstMax = produto.qtdeestmax,
                                                   precoAnterior = produto.precoanterior,
                                                   precoAtual = produto.precoatual
                                               }).ToList();

            return new List<ProdutoModel>(Lista.Where(p => p.descricao.Contains(Descricao)));
        }

        public List<ProdutoModel> GetProdutoPesquisaGrid(string Descricao)
        {
            Context db = new Context();
            List<ProdutoModel> ProdutoLista = (from pro in db.produto
                                               orderby pro.id
                                               select new ProdutoModel
                                               {
                                                   id = pro.id,
                                                   descricao = pro.descricao,
                                                   saldoEstoque = pro.saldoestoque,
                                                   precoAtual = pro.precoatual,
                                                   ativo = pro.ativo
                                               }).ToList();

            return new List<ProdutoModel>(ProdutoLista.Where(p => p.descricao.Contains(Descricao)));
        }
    }
}
