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
            try
            {
                db.grupo.Add(Grupo);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar o grupo, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(GrupoDto Grupo)
        {
            Context db = new Context();
            GrupoDto grupo = db.grupo.FirstOrDefault(p => p.id == Grupo.id);

            if (grupo != null)
            {
                try
                {
                    grupo.id = Grupo.id;
                    grupo.descricao = Grupo.descricao;
                    grupo.ativo = Grupo.ativo;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar o grupo, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            GrupoDto grupo = db.grupo.FirstOrDefault(p => p.id == Id);

            if (grupo != null)
            {
                try
                {
                    db.grupo.Remove(grupo);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o grupo, provavelmente existem movimentações no banco de dados para este grupo e ele não poderá ser excluído! \n\n" + ex.Message, 
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public bool ExisteGrupoId(int Id)
        {
            Context db = new Context();
            GrupoDto grupo = db.grupo.Where(p => p.id == Id).FirstOrDefault();

            if (grupo != null && grupo.id == Id)
                return true;
            else
                return false;
        }
        public GrupoModel GetGrupo(int Id)
        {
            Context db = new Context();
            GrupoDto grupo = db.grupo.Where(p => p.id == Id).FirstOrDefault();
            GrupoModel grupoModel = new GrupoModel();

            if (grupo != null && grupo.id == Id)
            {
                grupoModel.id = grupo.id;
                grupoModel.descricao = grupo.descricao;
                grupoModel.ativo = grupo.ativo;

                return grupoModel;
            }
            else
                return null;          
        }

        public List<GrupoModel> GetGrupoLista()
        {
            Context db = new Context();
            List<GrupoModel> lista = (from grupo in db.grupo
                                      orderby grupo.id
                                      select new GrupoModel
                                      {
                                          id = grupo.id,
                                          descricao = grupo.descricao,
                                          ativo = grupo.ativo
                                      }).ToList();
            return lista;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var grupo = db.grupo.FirstOrDefault();

            if (grupo != null)
                return db.grupo.Max(p => p.id) + 1;
            else
                return 1;
        }
        public List<GrupoModel> GetGrupoPesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<GrupoModel> lista = (from grupo in db.grupo
                                      orderby grupo.id
                                      select new GrupoModel
                                      {
                                          id = grupo.id,
                                          descricao = grupo.descricao,
                                          ativo = grupo.ativo
                                      }).ToList();

            return new List<GrupoModel>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }
    }
}
