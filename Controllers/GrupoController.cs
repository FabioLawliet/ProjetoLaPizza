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
        public void Adicionar(GrupoDB Grupo)
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

        public void Editar(GrupoDB Grupo)
        {
            Context db = new Context();
            GrupoDB grupo = db.grupo.FirstOrDefault(p => p.idgrupo == Grupo.idgrupo);

            if (grupo != null)
            {
                try
                {
                    grupo.idgrupo = Grupo.idgrupo;
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
            GrupoDB grupo = db.grupo.FirstOrDefault(p => p.idgrupo == Id);

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
            GrupoDB grupo = db.grupo.Where(p => p.idgrupo == Id).FirstOrDefault();

            if (grupo != null && grupo.idgrupo == Id)
                return true;
            else
                return false;
        }
        public GrupoDTO GetGrupo(int Id)
        {
            Context db = new Context();
            GrupoDB grupo = db.grupo.Where(p => p.idgrupo == Id).FirstOrDefault();
            GrupoDTO grupoModel = new GrupoDTO();

            if (grupo != null && grupo.idgrupo == Id)
            {
                grupoModel.idgrupo = grupo.idgrupo;
                grupoModel.descricao = grupo.descricao;
                grupoModel.ativo = grupo.ativo;

                return grupoModel;
            }
            else
                return null;          
        }

        public List<GrupoDTO> GetGrupoLista()
        {
            Context db = new Context();
            List<GrupoDTO> lista = (from grupo in db.grupo
                                      orderby grupo.idgrupo
                                      select new GrupoDTO
                                      {
                                          idgrupo = grupo.idgrupo,
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
                return db.grupo.Max(p => p.idgrupo) + 1;
            else
                return 1;
        }
        public List<GrupoDTO> GetGrupoPesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<GrupoDTO> lista = (from grupo in db.grupo
                                      orderby grupo.idgrupo
                                      select new GrupoDTO
                                      {
                                          idgrupo = grupo.idgrupo,
                                          descricao = grupo.descricao,
                                          ativo = grupo.ativo
                                      }).ToList();

            switch (ColunaPesquisa)
            {
                case "idgrupo":
                    return new List<GrupoDTO>(lista.Where(p => p.idgrupo.ToString() == TextoPesquisa));
                case "descricao":
                    return new List<GrupoDTO>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
