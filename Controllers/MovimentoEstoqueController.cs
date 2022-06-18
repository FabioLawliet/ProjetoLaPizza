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
        public void Adicionar(MovimentoEstoqueDTO Movimento)
        {
            Context db = new Context();
            MovimentoEstoqueDB movimento = new MovimentoEstoqueDB();

            try
            {
                movimento.descricao = Movimento.descricao;
                movimento.datamovimento = DateTime.Today.ToString(); //Movimento.datamovimento;
                movimento.usuariomovimento = "Admin"; //Movimento.usuariomovimento;
                db.movimentoestoque.Add(movimento);
                db.SaveChanges();

                foreach (var i in Movimento.itens)
                {
                    MovimentoEstoqueItensDB item = new MovimentoEstoqueItensDB();
                    item.idmovimentoestoque = movimento.idmovimentoestoque;
                    item.idproduto = i.idproduto;
                    item.saldoestoqueanterior = i.saldoestoqueanterior;
                    item.tipomovimento = i.tipomovimento;
                    item.qtdemovimento = i.qtdemovimento;
                    item.saldoestoquenovo = i.saldoestoquenovo;
                    db.movimentoestoqueitens.Add(item);

                    ProdutoDB Produto = db.produto.FirstOrDefault(p => p.idproduto == i.idproduto);
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
            List<MovimentoEstoqueItensDB> itens = db.movimentoestoqueitens.Where(p => p.idmovimentoestoque == Id).ToList();

            try
            {
                foreach (var i in itens)
                {
                    ProdutoDB produto = db.produto.FirstOrDefault(p => p.idproduto == i.idproduto);

                    if (i.tipomovimento == "E")
                        produto.saldoestoque = produto.saldoestoque - i.qtdemovimento;
                    else
                        produto.saldoestoque = produto.saldoestoque + i.qtdemovimento;

                    db.movimentoestoqueitens.Remove(i);
                    db.SaveChanges();
                }

                MovimentoEstoqueDB movimento = db.movimentoestoque.FirstOrDefault(p => p.idmovimentoestoque == Id);
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
                return db.movimentoestoque.Max(p => p.idmovimentoestoque) + 1;
        }

        public MovimentoEstoqueDTO GetMovimento(int Id)
        {
            Context db = new Context();
            List<MovimentoEstoqueDTO> Movimento = (from movimento in db.movimentoestoque
                                                  where movimento.idmovimentoestoque == Id
                                                  select new MovimentoEstoqueDTO
                                                  {
                                                      idmovimentoestoque = movimento.idmovimentoestoque,
                                                      descricao = movimento.descricao,
                                                      datamovimento = movimento.datamovimento,
                                                      usuariomovimento = movimento.usuariomovimento
                                                  }).ToList();

            List<MovimentoEstoqueItensDTO> Itens = (from itens in db.movimentoestoqueitens
                                                      join produto in db.produto on itens.idproduto equals produto.idproduto
                                                      where itens.idmovimentoestoque == Id
                                                     select new MovimentoEstoqueItensDTO
                                                     {
                                                         idmovimentoestoque = itens.idmovimentoestoque,
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

        public List<MovimentoEstoqueDTO> GetMovimentoLista()
        {
            Context db = new Context();
            List<MovimentoEstoqueDTO> movimentoLista = (from movimento in db.movimentoestoque
                                                     orderby movimento.idmovimentoestoque
                                                     select new MovimentoEstoqueDTO
                                                     {
                                                            idmovimentoestoque = movimento.idmovimentoestoque,
                                                         descricao = movimento.descricao,
                                                         datamovimento = movimento.datamovimento,
                                                         usuariomovimento = movimento.usuariomovimento
                                                     }).ToList();
            foreach (var li in movimentoLista)
            {
                List<MovimentoEstoqueItensDTO> itemLista = (from itens in db.movimentoestoqueitens
                                                            join produto in db.produto on itens.idproduto equals produto.idproduto
                                                            where itens.idmovimentoestoque == li.idmovimentoestoque
                                                            orderby itens.idmovimentoestoque
                                                            select new MovimentoEstoqueItensDTO
                                                          {
                                                              idmovimentoestoque = itens.idmovimentoestoque,
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
