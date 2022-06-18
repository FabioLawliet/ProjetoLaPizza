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
        public void Adicionar(ProdutoDB Produto)
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

        public void Editar(ProdutoDB Produto)
        {
            Context db = new Context();
            ProdutoDB produto = db.produto.FirstOrDefault(p => p.idproduto == Produto.idproduto);

            if (produto != null)
            {
                try
                {
                    produto.idproduto = Produto.idproduto;
                    produto.descricao = Produto.descricao;
                    produto.datacadastro = Produto.datacadastro.ToString();
                    produto.ativo = Produto.ativo;
                    produto.idgrupo = Produto.idgrupo;
                    produto.idsubgrupo = Produto.idsubgrupo;
                    produto.idmarca = Produto.idmarca;
                    produto.idunidmedida = Produto.idunidmedida;
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
            ProdutoDB produto = db.produto.FirstOrDefault(p => p.idproduto == Id);

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
                 var produto = db.produto.FirstOrDefault(p => p.idproduto == Id);

            if (produto != null)
                return true;
            else
                return false;
        }

        public ProdutoDTO GetProduto(int Id)
        {
            Context db = new Context();
            List<ProdutoDTO> Lista = (from produto in db.produto
                                        join marca in db.marca on produto.idmarca equals marca.idmarca
                                        join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                        join unidade in db.unidademedida on produto.idunidmedida equals unidade.idunidmedida
                                        join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                                 equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }
                                        where produto.idproduto == Id
                                        select new ProdutoDTO
                                        {
                                            idproduto = produto.idproduto,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupodescricao = grupo.descricao,
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupodescricao = subgrupo.descricao,
                                            idmarca = produto.idmarca,
                                            marcadescricao = marca.descricao,
                                            codigofabricante = produto.codigofabricante,
                                            infadicionais = produto.infadicionais,
                                            saldoestoque = produto.saldoestoque,
                                            idunidmedida = produto.idunidmedida,
                                            unidmedidasigla = unidade.sigla,
                                            qtdeestmin = produto.qtdeestmin,
                                            qtdeestideal = produto.qtdeestideal,
                                            qtdeestmax = produto.qtdeestmax,
                                            precoanterior = produto.precoanterior,
                                            precoatual = produto.precoatual
                                        }).ToList();

            return Lista.FirstOrDefault();
        }

        public List<ProdutoDTO> GetProdutoLista()
        {
            Context db = new Context();
            List<ProdutoDTO> Lista = (from produto in db.produto
                                      join marca in db.marca on produto.idmarca equals marca.idmarca
                                      join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                      join unidade in db.unidademedida on produto.idunidmedida equals unidade.idunidmedida
                                      join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                               equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }
                                      orderby produto.idproduto
                                      select new ProdutoDTO
                                      {
                                          idproduto = produto.idproduto,
                                          descricao = produto.descricao,
                                          //dataCadastro = produto.datacadastro.ToString(),
                                          ativo = produto.ativo,
                                          idgrupo = produto.idgrupo,
                                          grupodescricao = grupo.descricao,
                                          idsubgrupo = produto.idsubgrupo,
                                          subgrupodescricao = subgrupo.descricao,
                                          idmarca = produto.idmarca,
                                          marcadescricao = marca.descricao,
                                          codigofabricante = produto.codigofabricante,
                                          infadicionais = produto.infadicionais,
                                          saldoestoque = produto.saldoestoque,
                                          idunidmedida = produto.idunidmedida,
                                          unidmedidasigla = unidade.sigla,
                                          qtdeestmin = produto.qtdeestmin,
                                          qtdeestideal = produto.qtdeestideal,
                                          qtdeestmax = produto.qtdeestmax,
                                          precoanterior = produto.precoanterior,
                                          precoatual = produto.precoatual
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
                return db.produto.Max(p => p.idproduto) + 1;
        }

        public List<ProdutoDTO> GetProdutoPesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<ProdutoDTO> lista = (from produto in db.produto
                                        join marca in db.marca on produto.idmarca equals marca.idmarca
                                        join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                        join unidade in db.unidademedida on produto.idunidmedida equals unidade.idunidmedida
                                        join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                                 equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }
                                        orderby produto.idproduto
                                        select new ProdutoDTO
                                        {
                                            idproduto = produto.idproduto,
                                            descricao = produto.descricao,
                                            //dataCadastro = produto.datacadastro.ToString(),
                                            ativo = produto.ativo,
                                            idgrupo = produto.idgrupo,
                                            grupodescricao = grupo.descricao,
                                            idsubgrupo = produto.idsubgrupo,
                                            subgrupodescricao = subgrupo.descricao,
                                            idmarca = produto.idmarca,
                                            marcadescricao = marca.descricao,
                                            codigofabricante = produto.codigofabricante,
                                            infadicionais = produto.infadicionais,
                                            saldoestoque = produto.saldoestoque,
                                            idunidmedida = produto.idunidmedida,
                                            unidmedidasigla = unidade.sigla,
                                            qtdeestmin = produto.qtdeestmin,
                                            qtdeestideal = produto.qtdeestideal,
                                            qtdeestmax = produto.qtdeestmax,
                                            precoanterior = produto.precoanterior,
                                            precoatual = produto.precoatual
                                        }).ToList();

            switch (ColunaPesquisa)
            {
                case "idproduto":
                    return new List<ProdutoDTO>(lista.Where(p => p.idproduto.ToString() == TextoPesquisa));
                case "descricao":
                    return new List<ProdutoDTO>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
                case "saldoestoque":
                    return new List<ProdutoDTO>(lista.Where(p => p.saldoestoque.ToString().Contains(TextoPesquisa.ToUpper())));
                case "precoatual":
                    return new List<ProdutoDTO>(lista.Where(p => p.precoatual.ToString().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
