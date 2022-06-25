using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class FormaPagamentoController
    {
        public void Adicionar(FormaPagamentoDB FormaPagamento)
        {
            Context db = new Context();
            try
            {
                db.formapagamento.Add(FormaPagamento);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar a forma de pagamento, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(FormaPagamentoDB FormaPagamento)
        {
            Context db = new Context();
            FormaPagamentoDB formapagamento = db.formapagamento.FirstOrDefault(p => p.idformapagamento == FormaPagamento.idformapagamento);

            if (formapagamento != null)
            {
                try
                {
                    formapagamento.descricao = FormaPagamento.descricao;
                    formapagamento.permitedinheiro = FormaPagamento.permitedinheiro;
                    formapagamento.permitepix = FormaPagamento.permitepix;
                    formapagamento.permitecartaodeb = FormaPagamento.permitecartaodeb;
                    formapagamento.permitecartaocred = FormaPagamento.permitecartaocred;
                    formapagamento.permitecrediario = FormaPagamento.permitecrediario;
                    formapagamento.permitecheque = FormaPagamento.permitecheque;
                    formapagamento.ativa = FormaPagamento.ativa;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar a forma de pagamento, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            FormaPagamentoDB formapagamento = db.formapagamento.FirstOrDefault(p => p.idformapagamento == Id);

            if (formapagamento != null)
            {
                try
                {
                    db.formapagamento.Remove(formapagamento);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir a forma de pagamento, provavelmente existem movimentações no banco de dados para esta forma de pagamento e ela não poderá ser excluída! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ExisteFormaPagamento(int Id)
        {
            Context db = new Context();
            var formapagamento = db.formapagamento.Where(p => p.idformapagamento == Id).FirstOrDefault();

            if (formapagamento != null && formapagamento.idformapagamento == Id)
                return true;
            else
                return false;
        }

        public FormaPagamentoDTO GetFormaPagamento(int Id)
        {
            Context db = new Context();
            FormaPagamentoDTO formapagamento = (from pagamento in db.formapagamento
                                                where pagamento.idformapagamento == Id
                                                select new FormaPagamentoDTO
                                                {
                                                    idformapagamento = pagamento.idformapagamento,
                                                    descricao = pagamento.descricao,
                                                    permitedinheiro = pagamento.permitedinheiro,
                                                    permitepix = pagamento.permitepix,
                                                    permitecartaodeb = pagamento.permitecartaodeb,
                                                    permitecartaocred = pagamento.permitecartaocred,
                                                    permitecrediario = pagamento.permitecrediario,
                                                    permitecheque = pagamento.permitecheque,
                                                    ativa = pagamento.ativa
                                                }).FirstOrDefault();

            if (formapagamento != null)
                return formapagamento;
            else
                return null;
        }

        public List<FormaPagamentoDTO> GetFormaPagamentoLista()
        {
            Context db = new Context();
            List<FormaPagamentoDTO> lista = (from pagamento in db.formapagamento
                                            orderby pagamento.idformapagamento
                                            select new FormaPagamentoDTO
                                            {
                                                idformapagamento = pagamento.idformapagamento,
                                                descricao = pagamento.descricao,
                                                permitedinheiro = pagamento.permitedinheiro,
                                                permitepix = pagamento.permitepix,
                                                permitecartaodeb = pagamento.permitecartaodeb,
                                                permitecartaocred = pagamento.permitecartaocred,
                                                permitecrediario = pagamento.permitecrediario,
                                                permitecheque = pagamento.permitecheque,
                                                ativa = pagamento.ativa
                                            }).ToList();
            return lista;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var formapagamento = db.formapagamento.FirstOrDefault();

            if (formapagamento != null)
                return db.formapagamento.Max(p => p.idformapagamento) + 1;
            else
                return 1;
        }
        public List<FormaPagamentoDTO> GetFormaPagamentoPesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<FormaPagamentoDTO> lista = (from pagamento in db.formapagamento
                                             orderby pagamento.idformapagamento
                                             select new FormaPagamentoDTO
                                             {
                                                 idformapagamento = pagamento.idformapagamento,
                                                 descricao = pagamento.descricao,
                                                 permitedinheiro = pagamento.permitedinheiro,
                                                 permitepix = pagamento.permitepix,
                                                 permitecartaodeb = pagamento.permitecartaodeb,
                                                 permitecartaocred = pagamento.permitecartaocred,
                                                 permitecrediario = pagamento.permitecrediario,
                                                 permitecheque = pagamento.permitecheque,
                                                 ativa = pagamento.ativa
                                             }).ToList();

            switch (ColunaPesquisa)
            {
                case "idformapagamento":
                    return new List<FormaPagamentoDTO>(lista.Where(p => p.idformapagamento.ToString() == TextoPesquisa));
                case "descricao":
                    return new List<FormaPagamentoDTO>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
