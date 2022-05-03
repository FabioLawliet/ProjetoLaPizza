using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class ControleEstoqueController
    {


        /*
        public void Adicionar(ControleEstoqueModel Estoque)
        {
            Context db = new Context();
            ControleEstoqueDto EstoqueDto = new ControleEstoqueDto();
            
            //EstoqueDto.id = Estoque.id;
            EstoqueDto.descricao = Estoque.descricao;
            EstoqueDto.datamovimentacao = DateTime.Today.ToString();
            EstoqueDto.usuariomovimentacao = "Admin";
            db.controleestoque.Add(EstoqueDto);
            db.SaveChanges();

            ControleEstoqueItensDto EstoqueItensDto = new ControleEstoqueItensDto();
            //EstoqueItensDto.idcontroleestoque = Estoque.id;
            EstoqueItensDto.idproduto = Estoque.itens[0].idProduto;
            EstoqueItensDto.saldoestoqueanterior = Estoque.itens[0].saldoEstoqueAnterior;
            EstoqueItensDto.tipomovimento = Estoque.itens[0].tipoEntrada;
            EstoqueItensDto.qtdemovimento = Estoque.itens[0].qtdeMovimentada;
            EstoqueItensDto.saldoestoquenovo = Estoque.itens[0].saldoEstoqueNovo;
            db.controleestoqueitens.Add(EstoqueItensDto);
            db.SaveChanges();

            
            foreach (var i in Estoque.itens)
            {
                ControleEstoqueItensDto EstoqueItensDto = new ControleEstoqueItensDto();
                EstoqueItensDto.idcontroleestoque = Estoque.id;
                EstoqueItensDto.idproduto = i.idProduto;
                EstoqueItensDto.saldoestoqueanterior = i.saldoEstoqueAnterior;
                EstoqueItensDto.tipomovimento = i.tipoEntrada;
                EstoqueItensDto.qtdemovimento = i.qtdeMovimentada;
                EstoqueItensDto.saldoestoquenovo = i.saldoEstoqueNovo;

                db.controleestoqueitens.Add(EstoqueItensDto);

                ProdutoDto Produto = db.produto.FirstOrDefault(p => p.id == i.idProduto);
                Produto.saldoestoque = i.saldoEstoqueNovo;
                db.SaveChanges();
            }
            
        }
        public void Excluir(int Id)
        {
            Context db = new Context();
            ProdutoDto pro = db.produto.FirstOrDefault(p => p.id == Id);

            db.produto.Remove(pro);
            db.SaveChanges();
        }
        public int GetProximoId()
        {
            Context db = new Context();
            var ControleEstoque = db.controleestoque.FirstOrDefault();

            if (ControleEstoque is null)
                return 1;
            else
                return db.controleestoque.Max(c => c.id) + 1;
        }

        public ControleEstoqueModel GetControleEstoque(int Id)
        {
            Context db = new Context();
            List<ControleEstoqueModel> Estoque = (from estoque in db.controleestoque
                                                  where estoque.id == Id
                                                  select new ControleEstoqueModel
                                                  {
                                                      id = estoque.id,
                                                      descricao = estoque.descricao,
                                                      dataMovimentacao = estoque.datamovimentacao,
                                                      usuarioMovimentacao = estoque.usuariomovimentacao
                                                  }).ToList();
           
           List<ControleEstoqueItensModel> Itens = (from itens in db.controleestoqueitens
                                                     join produto in db.produto on itens.idproduto equals produto.id
                                                     where itens.idcontroleestoque == Id
                                                     select new ControleEstoqueItensModel
                                                     {
                                                         idcontroleestoque = itens.idcontroleestoque,
                                                         idProduto = itens.idproduto,
                                                         ProdutoDescricao = produto.descricao,
                                                         saldoEstoqueAnterior = itens.saldoestoqueanterior,
                                                         qtdeMovimentada = itens.qtdemovimento,
                                                         tipoEntrada = itens.tipomovimento,
                                                         saldoEstoqueNovo = itens.saldoestoquenovo
                                                     }).ToList();

            Estoque[0].itens.AddRange(Itens);

            return Estoque.FirstOrDefault();
        }
        public List<ControleEstoqueModel> GetControleEstoqueLista()
        {
            Context db = new Context();
            List<ControleEstoqueModel> Lista = (from estoque in db.controleestoque
                                                  select new ControleEstoqueModel
                                                  {
                                                      id = estoque.id,
                                                      descricao = estoque.descricao,
                                                      dataMovimentacao = estoque.datamovimentacao,
                                                      usuarioMovimentacao = estoque.usuariomovimentacao
                                                  }).ToList();

            foreach (var l in Lista)
            {
                /*List<ControleEstoqueItensModel> Itens = (from itens in db.controleestoqueitens
                                                         join produto in db.produto on itens.idproduto equals produto.id
                                                         select new ControleEstoqueItensModel
                                                         {
                                                             idcontroleestoque = itens.idcontroleestoque,
                                                             idProduto = itens.idproduto,
                                                             ProdutoDescricao = produto.descricao,
                                                             saldoEstoqueAnterior = itens.saldoestoqueanterior,
                                                             qtdeMovimentada = itens.qtdemovimento,
                                                             tipoEntrada = itens.tipomovimento,
                                                             saldoEstoqueNovo = itens.saldoestoquenovo
                                                         }).ToList();
                l.itens.AddRange(Itens);
            }

            return Lista;
        }*/
    }
}
