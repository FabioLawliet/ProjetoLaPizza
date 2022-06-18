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
            try
            {
                db.produto.Add(Produto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar o produto, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(ProdutoDto Produto)
        {
            Context db = new Context();
            ProdutoDto produto = db.produto.FirstOrDefault(p => p.id == Produto.id);

            if (produto != null)
            {
                try
                {
                    produto.id = Produto.id;
                    produto.descricao = Produto.descricao;
                    produto.datacadastro = Produto.datacadastro.ToString();
                    produto.ativo = Produto.ativo;
                    produto.idgrupo = Produto.idgrupo;
                    produto.idsubgrupo = Produto.idsubgrupo;
                    produto.idmarca = Produto.idmarca;
                    produto.codigofabricante = Produto.codigofabricante;
                    produto.infadicionais = Produto.infadicionais;
                    produto.saldoestoque = Produto.saldoestoque;
                    produto.qtdeestideal = Produto.qtdeestideal;
                    produto.qtdeestmin = Produto.qtdeestmin;
                    produto.qtdeestmax = Produto.qtdeestmax;
                    produto.precoanterior = Produto.precoanterior;
                    produto.precoatual = Produto.precoatual;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar o produto, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            ProdutoDto produto = db.produto.FirstOrDefault(p => p.id == Id);

            if (produto != null)
            {
                try
                {
                    db.produto.Remove(produto);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o produto, provavelmente existem movimentações no banco de dados para este produto e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ExisteProduto(int Id)
            {
            Context db = new Context();
                 var produto = db.produto.FirstOrDefault(p => p.id == Id);

            if (produto != null)
                return true;
            else
                return false;
        }

        public ProdutoModel GetProduto(int Id)
        {
            Context db = new Context();
            List<ProdutoModel> Lista = (from produto in db.produto
                                        join marca in db.marca on produto.idmarca equals marca.idmarca
                                        join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                        join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                                 equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }
                                        where produto.id == Id
                                        select new ProdutoModel
                                        {
                                            id = produto.id,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupoDescricao = grupo.descricao,
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupoDescricao = subgrupo.descricao,
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
                                        join marca in db.marca on produto.idmarca equals marca.idmarca
                                        join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                        join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                                 equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }
                                        orderby produto.id
                                        select new ProdutoModel
                                        {
                                            id = produto.id,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupoDescricao = grupo.descricao,
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupoDescricao = subgrupo.descricao,
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

        public int GetProximoId()
        {
            Context db = new Context();
            var produto = db.produto.FirstOrDefault();

            if (produto is null)
                return 1;
            else
                return db.produto.Max(p => p.id) + 1;
        }

        public List<ProdutoModel> GetProdutoPesquisaGrid(string Descricao)
        {
            Context db = new Context();
            List<ProdutoModel> Lista = (from produto in db.produto
                                        join marca in db.marca on produto.idmarca equals marca.idmarca
                                        join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                        join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                                 equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }
                                        orderby produto.id
                                        select new ProdutoModel
                                        {
                                            id = produto.id,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupoDescricao = grupo.descricao,
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupoDescricao = subgrupo.descricao,
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

            return new List<ProdutoModel>(Lista.Where(p => p.descricao.ToUpper().Contains(Descricao.ToUpper())));
        }
    }
}
