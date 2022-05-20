using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class MovimentoEstoqueController
    {
        public void Adicionar(MovimentoEstoqueModel Movimento)
        {
            Context db = new Context();
            MovimentoEstoqueDto movimento = new MovimentoEstoqueDto();

            try
            {
                movimento.descricao = Movimento.descricao;
                movimento.datamovimento = DateTime.Today.ToString(); //Movimento.datamovimento;
                movimento.usuariomovimento = "Admin"; //Movimento.usuariomovimento;
                db.movimentoestoque.Add(movimento);
                db.SaveChanges();

                foreach (var i in Movimento.itens)
                {
                    MovimentoEstoqueItensDto item = new MovimentoEstoqueItensDto();
                    item.idmovimento = movimento.idmovimento;
                    item.idproduto = i.idproduto;
                    item.saldoestoqueanterior = i.saldoestoqueanterior;
                    item.tipomovimento = i.tipomovimento;
                    item.qtdemovimento = i.qtdemovimento;
                    item.saldoestoquenovo = i.saldoestoquenovo;
                    db.movimentoestoqueitens.Add(item);

                    ProdutoDto Produto = db.produto.FirstOrDefault(p => p.id == i.idproduto);
                    Produto.saldoestoque = i.saldoestoquenovo;
                }
                db.SaveChanges();
            }catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar o movimento, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            List<MovimentoEstoqueItensDto> itens = db.movimentoestoqueitens.Where(p => p.idmovimento == Id).ToList();

            try
            {
                foreach (var i in itens)
                {
                    ProdutoDto produto = db.produto.FirstOrDefault(p => p.id == i.idproduto);

                    if (i.tipomovimento == "E")
                        produto.saldoestoque = produto.saldoestoque - i.qtdemovimento;
                    else
                        produto.saldoestoque = produto.saldoestoque + i.qtdemovimento;

                    db.movimentoestoqueitens.Remove(i);
                    db.SaveChanges();
                }

                MovimentoEstoqueDto movimento = db.movimentoestoque.FirstOrDefault(p => p.idmovimento == Id);
                db.movimentoestoque.Remove(movimento);
                db.SaveChanges();
            }catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o movimento! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var Movimento = db.movimentoestoque.FirstOrDefault();

            if (Movimento is null)
                return 1;
            else
                return db.movimentoestoque.Max(p => p.idmovimento) + 1;
        }

        public MovimentoEstoqueModel GetMovimento(int Id)
        {
            Context db = new Context();
            List<MovimentoEstoqueModel> Movimento = (from movimento in db.movimentoestoque
                                                  where movimento.idmovimento == Id
                                                  select new MovimentoEstoqueModel
                                                  {
                                                      idmovimento = movimento.idmovimento,
                                                      descricao = movimento.descricao,
                                                      datamovimento = movimento.datamovimento,
                                                      usuariomovimento = movimento.usuariomovimento
                                                  }).ToList();

            List<MovimentoEstoqueItensModel> Itens = (from itens in db.movimentoestoqueitens
                                                      join produto in db.produto on itens.idproduto equals produto.id
                                                     where itens.idmovimento == Id
                                                     select new MovimentoEstoqueItensModel
                                                     {
                                                         idmovimento = itens.idmovimento,
                                                         idproduto = itens.idproduto,
                                                         produtodescricao = produto.descricao,
                                                         saldoestoqueanterior = itens.saldoestoqueanterior,
                                                         qtdemovimento = itens.qtdemovimento,
                                                         tipomovimento = itens.tipomovimento,
                                                         saldoestoquenovo = itens.saldoestoquenovo
                                                     }).ToList();

            Movimento[0].itens.AddRange(Itens);

            return Movimento.FirstOrDefault();
        }

        public List<MovimentoEstoqueModel> GetMovimentoLista()
        {
            Context db = new Context();
            List<MovimentoEstoqueModel> movimentoLista = (from movimento in db.movimentoestoque
                                                     orderby movimento.idmovimento
                                                     select new MovimentoEstoqueModel
                                                     {
                                                         idmovimento = movimento.idmovimento,
                                                         descricao = movimento.descricao,
                                                         datamovimento = movimento.datamovimento,
                                                         usuariomovimento = movimento.usuariomovimento
                                                     }).ToList();
            foreach (var li in movimentoLista)
            {
                List<MovimentoEstoqueItensModel> itemLista = (from itens in db.movimentoestoqueitens
                                                          join produto in db.produto on itens.idproduto equals produto.id
                                                          where itens.idmovimento == li.idmovimento
                                                          orderby itens.idmovimento
                                                          select new MovimentoEstoqueItensModel
                                                          {
                                                              idmovimento = itens.idmovimento,
                                                              idproduto = itens.idproduto,
                                                              produtodescricao = produto.descricao,
                                                              saldoestoqueanterior = itens.saldoestoqueanterior,
                                                              qtdemovimento = itens.qtdemovimento,
                                                              tipomovimento = itens.tipomovimento,
                                                              saldoestoquenovo = itens.saldoestoquenovo
                                                          }).ToList();
                li.itens.AddRange(itemLista);
            }

            return movimentoLista;
        }
    }
}
