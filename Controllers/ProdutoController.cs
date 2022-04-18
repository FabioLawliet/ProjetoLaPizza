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
        public void AdicionarProduto(ProdutoDto Produto)
        {
            Context db = new Context();
            db.produto.Add(Produto);
            db.SaveChanges();
        }

        public ProdutoModel GetProduto(int Id)
        {/*
            Context db = new Context();
            ProdutoModel produto = (from p in db.produto
                                    join m in db.marca on p.marca equals m.id
                                    where p.id == Id
                                    select new ProdutoModel { });

            ProdutoModel produto = new ProdutoModel();
            produto.id = produtoDto.id;
            produto.descricao = produtoDto.descricao;
            produto.dataCadastro = produtoDto.
            produto.ativo = produtoDto.ativo;

            return produto;*/
        }

        public int GetProximoId()
        {
            Context db = new Context();
            List<ProdutoModel> ListProduto = (from p in db.produto
                                          where p.id > 0
                                          select new ProdutoModel
                                          {
                                              id = p.id,
                                              descricao = p.descricao,
                                              ativo = p.ativo
                                          }).ToList();

            if (ListProduto.Count() > 0)
                return (int)db.produto.Max(p => p.id);
            else
                return 0;
        }

        public List<ProdutoModel> GetListProduto()
        {
            Context db = new Context();
            List<ProdutoModel> ListProduto = (from p in db.produto
                                          join m in db.marca on p.marca equals m.id
                                          where p.id > 0
                                          orderby p.id
                                          select new ProdutoModel
                                          {
                                              id = p.id,
                                              descricao = p.descricao,
                                              grupo = p.grupo,
                                              subgrupo = p.subgrupo,
                                              marca = p.marca,
                                              marcaDescricao = m.descricao,
                                              codFabricante = p.codfabricante,
                                              precoAtual = p.precoatual,
                                              ativo = p.ativo
                                          }).ToList();

            return new List<ProdutoModel>(ListProduto);
        }

        public List<MarcaModel> GetListMarcaWhere(string descricao)
        {
            Context db = new Context();
            List<MarcaModel> ListMarca = (from m in db.marca
                                          orderby m.id
                                          select new MarcaModel
                                          {
                                              id = m.id,
                                              descricao = m.descricao,
                                              ativa = m.ativa
                                          }).ToList();

            return new List<MarcaModel>(ListMarca.Where(p => p.descricao.Contains(descricao)));
        }

        public void SalvaEdicaoMarca(MarcaDto Marca)
        {
            Context db = new Context();
            MarcaDto mar = db.marca.FirstOrDefault(m => m.id == Marca.id);
            mar.descricao = Marca.descricao;
            mar.ativa = Marca.ativa;
            db.SaveChanges();
        }

        public bool ExisteMarca(int Id)
        {
            Context db = new Context();
            var marca = db.marca.Where(m => m.id == Id).FirstOrDefault();

            if (marca is null)
                return true;
            else
                return false;
        }

        public void ExcluirMarca(int Id)
        {
            Context db = new Context();
            MarcaDto marca = db.marca.FirstOrDefault(m => m.id == Id);
            try
            {
                db.marca.Remove(marca);
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

        public List<ProdutoModel> GetListProdutoGrid()
        {
            Context db = new Context();
            List<ProdutoModel> ListProduto = (from p in db.produto
                                              where p.id > 0
                                              orderby p.id
                                              select new ProdutoModel
                                              {
                                                  id = p.id,
                                                  descricao = p.descricao,
                                                  grupo = p.grupo,
                                                  subgrupo = p.subgrupo,
                                                  marca = p.marca,
                                                  codFabricante = p.codfabricante,
                                                  precoAtual = p.precoatual,
                                                  ativo = p.ativo
                                              }).ToList();

            return new List<ProdutoModel>(ListProduto);
        }
    }
}
