using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class CidadeController
    {
        public void Adicionar(CidadeDB Cidade)
        {
            Context db = new Context();
            try
            {
                db.cidade.Add(Cidade);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar o grupo, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(CidadeDB Cidade)
        {
            Context db = new Context();
            CidadeDB cidade = db.cidade.FirstOrDefault(p => p.idcidade == Cidade.idcidade);

            if (cidade != null)
            {
                try
                {
                    cidade.idcidade = Cidade.idcidade;
                    cidade.nome = Cidade.nome;
                    cidade.idestado = Cidade.idestado;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar a cidade, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            CidadeDB cidade = db.cidade.FirstOrDefault(p => p.idcidade == Id);

            if (cidade != null)
            {
                try
                {
                    db.cidade.Remove(cidade);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir a cidade, provavelmente existem movimentações no banco de dados para este grupo e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ExisteCidadeId(int Id)
        {
            Context db = new Context();
            CidadeDB cidade = db.cidade.Where(p => p.idcidade == Id).FirstOrDefault();

            if (cidade != null && cidade.idcidade == Id)
                return true;
            else
                return false;
        }

        public CidadeDTO GetCidade(int Id)
        {
            Context db = new Context();
            CidadeDTO cidadeModel = (from cidade in db.cidade
                                    join estado in db.estado on cidade.idestado equals estado.idestado
                                    where cidade.idcidade == Id
                                    select new CidadeDTO
                                    {
                                        idcidade = cidade.idcidade,
                                        nome = cidade.nome,
                                        idestado = cidade.idestado,
                                        sigla = estado.sigla,
                                        estadonome = estado.nome
                                    }).FirstOrDefault();
            return cidadeModel;
        }

        public List<CidadeDTO> GetCidadeLista()
        {
            Context db = new Context();
            List<CidadeDTO> lista = (from cidade in db.cidade
                                     join estado in db.estado on cidade.idestado equals estado.idestado
                                    orderby cidade.idcidade
                                    select new CidadeDTO
                                    {
                                        idcidade = cidade.idcidade,
                                        nome = cidade.nome,
                                        idestado = cidade.idestado,
                                        estadonome = estado.nome
                                    }).ToList();
            return lista;
        }

        public List<CidadeDTO> GetCidadeEstado(int ID)
        {
            Context db = new Context();
            List<CidadeDTO> lista = (from cidade in db.cidade
                                     join estado in db.estado on cidade.idestado equals estado.idestado
                                     where cidade.idcidade == ID
                                     orderby cidade.idcidade
                                     select new CidadeDTO
                                     {
                                         idcidade = cidade.idcidade,
                                         nome = cidade.nome,
                                         estadonome = estado.nome,
                                     }).ToList();
            return lista;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var cidade = db.cidade.FirstOrDefault();

            if (cidade != null)
                return db.cidade.Max(p => p.idcidade) + 1;
            else
                return 1;
        }

        public List<CidadeDTO> GetCidadePesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<CidadeDTO> lista = (from cidade in db.cidade
                                    orderby cidade.idcidade
                                    select new CidadeDTO
                                    {
                                        idcidade = cidade.idcidade,
                                        nome = cidade.nome,
                                        idestado = cidade.idestado
                                    }).ToList();

            switch (ColunaPesquisa)
            {
                case "idcidade":
                    return new List<CidadeDTO>(lista.Where(p => p.idcidade.ToString() == TextoPesquisa));
                case "nome":
                    return new List<CidadeDTO>(lista.Where(p => p.nome.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
