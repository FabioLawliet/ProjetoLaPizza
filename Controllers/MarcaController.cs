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

        public void Adicionar(MarcaDB Marca)
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

        public void Editar(MarcaDB Marca)
        {
            Context db = new Context();
            MarcaDB marca = db.marca.FirstOrDefault(p => p.idmarca == Marca.idmarca);

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
            MarcaDB marca = db.marca.FirstOrDefault(p => p.idmarca == Id);

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
            var marca = db.marca.Where(p => p.idmarca == Id).FirstOrDefault();

            if (marca != null && marca.idmarca == Id)
                return true;
            else
                return false;
        }

        public MarcaDTO GetMarca(int Id)
        {
            Context db = new Context();
            MarcaDB marca = db.marca.Where(p => p.idmarca == Id).FirstOrDefault();
            MarcaDTO marcaModel = new MarcaDTO();

            if (marca != null)
            {
                marcaModel.idmarca = marca.idmarca;
                marcaModel.descricao = marca.descricao;
                marcaModel.ativa = marca.ativa;

                return marcaModel;
            }
            else
                return null;            
        }

        public List<MarcaDTO> GetMarcaLista()
        {
            Context db = new Context();
            List<MarcaDTO> lista = (from marca in db.marca
                                      orderby marca.idmarca
                                      select new MarcaDTO
                                      {
                                          idmarca = marca.idmarca,
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
                return db.marca.Max(p => p.idmarca) + 1;
            else
                return 1;
        }
        public List<MarcaDTO> GetMarcaPesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<MarcaDTO> lista = (from marca in db.marca
                                    orderby marca.idmarca
                                    select new MarcaDTO
                                    {
                                        idmarca = marca.idmarca,
                                        descricao = marca.descricao,
                                        ativa = marca.ativa
                                    }).ToList();

            switch (ColunaPesquisa)
            {
                case "idmarca":
                    return new List<MarcaDTO>(lista.Where(p => p.idmarca.ToString() == TextoPesquisa));
                case "descricao":
                    return new List<MarcaDTO>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
