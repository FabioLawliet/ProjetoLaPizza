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

            SubgrupoDto subgrupo = db.subgrupo.Where(p => p.idgrupo == Subgrupo.idgrupo).FirstOrDefault(p => p.idsubgrupo == Subgrupo.idsubgrupo);
            if (subgrupo != null)
            {
                subgrupo.idsubgrupo = Subgrupo.idsubgrupo;
                subgrupo.descricao = Subgrupo.descricao;
                subgrupo.idgrupo = Subgrupo.idgrupo;
                subgrupo.ativo = Subgrupo.ativo;
                db.SaveChanges();
            }
        }

        public void Excluir(int IdGrupo, int IdSubgrupo)
        {
            Context db = new Context();
            SubgrupoDto subgrupo = db.subgrupo.Where(p => p.idgrupo == IdGrupo).FirstOrDefault(p => p.idsubgrupo == IdSubgrupo);

            if (subgrupo != null)
            {
                db.subgrupo.Remove(subgrupo);
                db.SaveChanges();
            }
        }
        public bool ExisteSubgrupo(int IdGrupo, int IdSubgrupo)
        {
            Context db = new Context();
            SubgrupoDto subgrupo = db.subgrupo.Where(p => p.idgrupo == IdGrupo).FirstOrDefault(p => p.idsubgrupo == IdSubgrupo);

            if (subgrupo != null && subgrupo.idgrupo == IdGrupo && subgrupo.idsubgrupo == IdSubgrupo)
                return true;
            else
                return false;
        }
        public SubgrupoModel GetSubgrupo(int IdGrupo, int IdSubgrupo)
        {
            Context db = new Context();
            SubgrupoDto subgrupo = db.subgrupo.Where(p => p.idgrupo == IdGrupo).FirstOrDefault(p => p.idsubgrupo == IdSubgrupo);
            SubgrupoModel subgrupoModel = new SubgrupoModel();

            if (subgrupo != null && subgrupo.idgrupo == IdGrupo && subgrupo.idsubgrupo == IdSubgrupo)
            {
                subgrupoModel.idsubgrupo = subgrupo.idsubgrupo;
                subgrupoModel.descricao = subgrupo.descricao;
                subgrupoModel.idgrupo = subgrupo.idgrupo;
                subgrupoModel.ativo = subgrupo.ativo;

                return subgrupoModel;
            }
            else
                return null;
        }

        public List<SubgrupoModel> GetSubgrupoLista(int GrupoId)
        {
            Context db = new Context();
            List<SubgrupoModel> lista = (from subgrupo in db.subgrupo
                                         where subgrupo.idgrupo == GrupoId
                                         orderby subgrupo.idsubgrupo
                                         select new SubgrupoModel
                                         {
                                            idsubgrupo = subgrupo.idsubgrupo,
                                            descricao = subgrupo.descricao,
                                            idgrupo = subgrupo.idsubgrupo,
                                            ativo = subgrupo.ativo
                                          }).ToList();
            return lista;
        }

        public int GetProximoId(int GrupoId)
        {
            Context db = new Context();
                var subgrupo = db.subgrupo.Where(p => p.idgrupo == GrupoId).Max(p => p.idsubgrupo);

            if (subgrupo >= 0)
                return subgrupo + 1;
            else
                return 1;
        }
        public List<SubgrupoModel> GetSubgrupoPesquisaGrid(int GrupoId, string TextoPesquisa)
        {
            Context db = new Context();
            List<SubgrupoModel> lista = (from subgrupo in db.subgrupo
                                         where subgrupo.idgrupo == GrupoId
                                         orderby subgrupo.idsubgrupo
                                         select new SubgrupoModel
                                         {
                                             idsubgrupo = subgrupo.idsubgrupo,
                                             descricao = subgrupo.descricao,
                                             idgrupo = subgrupo.idsubgrupo,
                                             ativo = subgrupo.ativo
                                         }).ToList();

            return new List<SubgrupoModel>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }
    }
}
