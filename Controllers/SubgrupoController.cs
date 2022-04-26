using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class SubgrupoController
    {
        public void Adicionar(SubgrupoDto Subgrupo)
        {
            Context db = new Context();
            db.subgrupo.Add(Subgrupo);
            db.SaveChanges();
        }

        public void Editar(SubgrupoDto Subgrupo)
        {
            Context db = new Context();
            SubgrupoDto sub = db.subgrupo.FirstOrDefault(s => s.id == Subgrupo.id);
            sub.id = Subgrupo.id;
            sub.descricao = sub.descricao;
            sub.ativo = Subgrupo.ativo;
            db.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            SubgrupoDto sub = db.subgrupo.FirstOrDefault(s => s.id == Id);
            try
            {
                db.subgrupo.Remove(sub);
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

        public bool ExisteGrupoId(int Id)
        {
            Context db = new Context();
            SubgrupoDto sub = db.subgrupo.Where(g => g.id == Id).FirstOrDefault();

            if (sub is null)
                return false;
            else
                return true;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var sub = db.subgrupo.FirstOrDefault();

            if (sub is null)
                return 1;
            else
                return db.subgrupo.Max(s => s.id) + 1;
        }

        public SubgrupoModel GetGrupo(int Id)
        {
            Context db = new Context();
            SubgrupoModel Subgrupo = (from gru in db.subgrupo
                                where gru.id == Id
                                select new SubgrupoModel
                                {
                                    id = gru.id,
                                    descricao = gru.descricao,
                                    ativo = gru.ativo
                                }).FirstOrDefault();

            return Subgrupo;
        }

        public List<SubgrupoModel> GetGrupoLista()
        {
            Context db = new Context();
            List<SubgrupoModel> Lista = (from sub in db.subgrupo
                                      select new SubgrupoModel
                                      {
                                          id = sub.id,
                                          descricao = sub.descricao,
                                          ativo = sub.ativo
                                      }).ToList();
            return Lista;
        }

        public List<GrupoModel> GetGrupoPesquisaGrid(string Descricao)
        {
            Context db = new Context();
            List<GrupoModel> Lista = (from gru in db.grupo
                                      select new GrupoModel
                                      {
                                          id = gru.id,
                                          descricao = gru.descricao,
                                          ativo = gru.ativo
                                      }).ToList();

            return new List<GrupoModel>(Lista.Where(p => p.descricao.Contains(Descricao)));
        }
    }
}
}
