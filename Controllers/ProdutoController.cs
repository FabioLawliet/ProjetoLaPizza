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
            pro.datacadastro = Produto.datacadastro;
            pro.ativo = Produto.ativo;
            pro.grupo = Produto.grupo;
            pro.subgrupo = Produto.subgrupo;
            pro.marca = Produto.marca;
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
                return true;
            else
                return false;
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
            List<ProdutoModel> ListaProduto = (from pro in db.produto
                                                join mar in db.marca on pro.marca equals mar.id
                                                where pro.id == Id
                                                select new ProdutoModel
                                                {
                                                    id = pro.id,
                                                    descricao = pro.descricao,
                                                    //dataCadastro = pro.datacadastro,
                                                    ativo = pro.ativo,
                                                    grupo = pro.grupo,
                                                    //grupoDescricao = pro.grupo.ToString(),
                                                    subgrupo = pro.subgrupo,
                                                    //subgrupoDescricao = pro.subgrupo.ToString(),
                                                    marca = pro.marca,
                                                    marcaDescricao = mar.descricao,
                                                    codigoFabricante = pro.codigofabricante,
                                                    infAdicionais = pro.infadicionais,
                                                    saldoEstoque = pro.saldoestoque,
                                                    unidadeMedida = pro.unidademedida,
                                                    qtdeEstMin = pro.qtdeestmin,
                                                    qtdeEstIdeal = pro.qtdeestideal,
                                                    qtdeEstMax = pro.qtdeestmax,
                                                    precoAnterior = pro.precoanterior,
                                                    precoAtual = pro.precoatual
                                                }).ToList();

            return ListaProduto.FirstOrDefault(); ;
        }
        public List<ProdutoModel> GetProdutoLista()
        {
            Context db = new Context();
            List<ProdutoModel> ProdutoLista = (from pro in db.produto
                                              join mar in db.marca on pro.marca equals mar.id
                                              orderby pro.id
                                              select new ProdutoModel
                                              {
                                                  id = pro.id,
                                                  descricao = pro.descricao,
                                                  dataCadastro = pro.datacadastro,
                                                  ativo = pro.ativo,
                                                  grupo = pro.grupo,
                                                  //grupoDescricao = gru.descricao,
                                                  subgrupo = pro.subgrupo,
                                                  //subGrupoDescricao = sub.descricao,
                                                  marca = pro.marca,
                                                  marcaDescricao = mar.descricao,
                                                  codigoFabricante = pro.codigofabricante,
                                                  infAdicionais = pro.infadicionais,
                                                  saldoEstoque = pro.saldoestoque,
                                                  unidadeMedida = pro.unidademedida,
                                                  qtdeEstMin = pro.qtdeestmin,
                                                  qtdeEstIdeal = pro.qtdeestideal,
                                                  qtdeEstMax = pro.qtdeestmax,
                                                  precoAnterior = pro.precoanterior,
                                                  precoAtual = pro.precoatual
                                              }).ToList();
            return ProdutoLista;
        }

        public List<ProdutoModel> GetProdutoPesquisa(string Descricao)
        {
            Context db = new Context();
            List<ProdutoModel> ProdutoLista = (from pro in db.produto
                                               join mar in db.marca on pro.marca equals mar.id
                                               orderby pro.id
                                               select new ProdutoModel
                                               {
                                                   id = pro.id,
                                                   descricao = pro.descricao,
                                                   //dataCadastro = pro.datacadastro,
                                                   ativo = pro.ativo,
                                                   grupo = pro.grupo,
                                                   //grupoDescricao = gru.descricao,
                                                   subgrupo = pro.subgrupo,
                                                   //subGrupoDescricao = sub.descricao,
                                                   marca = pro.marca,
                                                   marcaDescricao = mar.descricao,
                                                   codigoFabricante = pro.codigofabricante,
                                                   infAdicionais = pro.infadicionais,
                                                   saldoEstoque = pro.saldoestoque,
                                                   unidadeMedida = pro.unidademedida,
                                                   qtdeEstMin = pro.qtdeestmin,
                                                   qtdeEstIdeal = pro.qtdeestideal,
                                                   qtdeEstMax = pro.qtdeestmax,
                                                   precoAnterior = pro.precoanterior,
                                                   precoAtual = pro.precoatual
                                               }).ToList();

            return new List<ProdutoModel>(ProdutoLista.Where(p => p.descricao.Contains(Descricao)));
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
