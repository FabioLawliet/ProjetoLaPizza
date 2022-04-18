using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class MarcaController
    {

        public void AdicionarMarca(MarcaDto Marca)
        {
            Context db = new Context();
            db.marca.Add(Marca);
            db.SaveChanges();
        }

        public void EditarMarca(MarcaDto Marca)
        {
            Context db = new Context();
            MarcaDto mar = db.marca.FirstOrDefault(m => m.id == Marca.id);
            mar.descricao = Marca.descricao;
            mar.ativa = Marca.ativa;
            db.SaveChanges();
        }

        public void ExcluirMarca(int Id)
        {
            Context db = new Context();
            MarcaDto marca = db.marca.FirstOrDefault(m => m.id == Id);
            try
            {
                db.marca.Remove(marca);
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

        public MarcaModel GetMarca(int Id)
        {
            Context db = new Context();
            MarcaDto marcaDto = db.marca.Where(m => m.id == Id).FirstOrDefault();

            MarcaModel marcaModel = new MarcaModel();
            marcaModel.id = marcaDto.id;
            marcaModel.descricao = marcaDto.descricao;
            marcaModel.ativa = marcaDto.ativa;

            return marcaModel;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            List<MarcaModel> ListMarca = (from m in db.marca
                                           where m.id > 0
                                           select new MarcaModel
                                           {
                                               id = m.id,
                                               descricao = m.descricao,
                                               ativa = m.ativa
                                           }).ToList();

             if (ListMarca.Count() > 0)
                 return (int)db.marca.Max(m => m.id);
             else
                 return 0;
        }


        public List<MarcaModel> GetListMarca()
        {
            Context db = new Context();
            List<MarcaModel> ListMarca = (from m in db.marca
                                          where m.id > 0
                                          orderby m.id
                                          select new MarcaModel
                                          {
                                              id = m.id,
                                              descricao = m.descricao,
                                              ativa = m.ativa
                                          }).ToList();

            return new List<MarcaModel>(ListMarca);
        }

        public List<MarcaModel> GetListMarcaPesquisa(string descricao)
        {
            Context db = new Context();
            List<MarcaModel> ListMarca = (from m in db.marca
                                          orderby m.id
                                          select new MarcaModel
                                          {
                                              id = m.id,
                                              descricao = m.descricao,
                                              ativa = m.ativa
                                          }).ToList();

            return new List<MarcaModel>(ListMarca.Where(p => p.descricao.Contains(descricao)));
        }

        public bool ExisteMarca(int Id)
        {
            Context db = new Context();
            var marca = db.marca.Where(m => m.id == Id).FirstOrDefault();

            if (marca is null)
                return false;
            else
                return true;
            
        }
    }
}
