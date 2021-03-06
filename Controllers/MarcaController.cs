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

        public void Adicionar(MarcaDto Marca)
        {
            Context db = new Context();
            try
            {
                db.marca.Add(Marca);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar a marca, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(MarcaDto Marca)
        {
            Context db = new Context();
            MarcaDto marca = db.marca.FirstOrDefault(p => p.id == Marca.id);

            if (marca != null)
            {
                try
                {
                    marca.descricao = Marca.descricao;
                    marca.ativa = Marca.ativa;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar a marca, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            MarcaDto marca = db.marca.FirstOrDefault(p => p.id == Id);

            if (marca != null)
            {
                try
                {
                    db.marca.Remove(marca);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir a marca, provavelmente existem movimentações no banco de dados para esta marca e ela não poderá ser excluída! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ExisteMarca(int Id)
        {
            Context db = new Context();
            var marca = db.marca.Where(p => p.id == Id).FirstOrDefault();

            if (marca != null && marca.id == Id)
                return true;
            else
                return false;
        }

        public MarcaModel GetMarca(int Id)
        {
            Context db = new Context();
            MarcaDto marca = db.marca.Where(p => p.id == Id).FirstOrDefault();
            MarcaModel marcaModel = new MarcaModel();

            if (marca != null)
            {
                marcaModel.id = marca.id;
                marcaModel.descricao = marca.descricao;
                marcaModel.ativa = marca.ativa;

                return marcaModel;
            }
            else
                return null;            
        }

        public List<MarcaModel> GetMarcaLista()
        {
            Context db = new Context();
            List<MarcaModel> lista = (from marca in db.marca
                                      orderby marca.id
                                      select new MarcaModel
                                      {
                                          id = marca.id,
                                          descricao = marca.descricao,
                                          ativa = marca.ativa
                                      }).ToList();
            return lista;
        }

        public int GetProximoId()
        {
            Context db = new Context();
             var marca = db.marca.FirstOrDefault();

            if (marca != null)
                return db.marca.Max(p => p.id) + 1;
            else
                return 1;
        }
        public List<MarcaModel> GetMarcaPesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<MarcaModel> lista = (from marca in db.marca
                                      orderby marca.id
                                      select new MarcaModel
                                      {
                                          id = marca.id,
                                          descricao = marca.descricao,
                                          ativa = marca.ativa
                                      }).ToList();

            return new List<MarcaModel>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }
    }
}
