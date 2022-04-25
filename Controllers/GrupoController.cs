using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class GrupoController
    {
        public void Adicionar(GrupoDto Grupo)
        {
            Context db = new Context();
            db.grupo.Add(Grupo);
            db.SaveChanges();
        }

        public void Editar(GrupoDto Grupo)
        {
            Context db = new Context();
            GrupoDto gru = db.grupo.FirstOrDefault(g => g.id == Grupo.id);
            gru.id = Grupo.id;
            gru.descricao = gru.descricao;
            gru.ativo = Grupo.ativo;
            db.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            GrupoDto gru = db.grupo.FirstOrDefault(g => g.id == Id);
            try
            {
                db.grupo.Remove(gru);
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
            GrupoDto gru = db.grupo.Where(g => g.id == Id).FirstOrDefault();

            if (gru is null)
                return true;
            else
                return false;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var gru = db.grupo.FirstOrDefault();

            if (gru is null)
                return 1;
            else
                return db.grupo.Max(g => g.id) + 1;
        }

        public GrupoModel GetGrupo(int Id)
        {
            Context db = new Context();
            List<GrupoModel> Lista = (from gru in db.grupo
                                      where gru.id == Id
                                      select new GrupoModel
                                      { 
                                        id = gru.id,
                                        descricao = gru.descricao,
                                        ativo = gru.ativo
                                      }).ToList();

            return Lista.FirstOrDefault();
        }

        public List<GrupoModel> GetGrupoLista()
        {
            Context db = new Context();
            List<GrupoModel> Lista = (from gru in db.grupo
                                      select new GrupoModel
                                      {
                                          id = gru.id,
                                          descricao = gru.descricao,
                                          ativo = gru.ativo
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
