using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class UnidadeMedidaController
    {
        public void Adicionar(UnidadeMedidaDB UnidadeMedida)
        {
            Context db = new Context();
            try
            {
                db.unidademedida.Add(UnidadeMedida);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar a unidade de medida, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(UnidadeMedidaDB UnidadeMedida)
        {
            Context db = new Context();
            UnidadeMedidaDB unidade = db.unidademedida.FirstOrDefault(p => p.idunidmedida == UnidadeMedida.idunidmedida);

            if (unidade != null)
            {
                try
                {
                    unidade.idunidmedida = UnidadeMedida.idunidmedida;
                    unidade.descricao = UnidadeMedida.descricao;
                    unidade.sigla = UnidadeMedida.sigla;
                    unidade.ativa = UnidadeMedida.ativa;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar a unidade de medida, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            UnidadeMedidaDB unidade = db.unidademedida.FirstOrDefault(p => p.idunidmedida == Id);

            if (unidade != null)
            {
                try
                {
                    db.unidademedida.Remove(unidade);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir a unidade de medida, provavelmente existem movimentações no banco de dados para esta unidade de medida e ela não poderá ser excluída! \n\n" + ex.Message, 
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public bool ExisteUnidadeMedidaId(int Id)
        {
            Context db = new Context();
            UnidadeMedidaDB unidade = db.unidademedida.Where(p => p.idunidmedida == Id).FirstOrDefault();

            if (unidade != null && unidade.idunidmedida == Id)
                return true;
            else
                return false;
        }
        public UnidadeMedidaDTO GetUnidadeMedida(int Id)
        {
            Context db = new Context();
            UnidadeMedidaDB unidade = db.unidademedida.Where(p => p.idunidmedida == Id).FirstOrDefault();
            UnidadeMedidaDTO unidadeDTO = new UnidadeMedidaDTO();

            if (unidade != null && unidade.idunidmedida == Id)
            {
                unidadeDTO.idunidmedida = unidade.idunidmedida;
                unidadeDTO.descricao = unidade.descricao;
                unidadeDTO.sigla = unidade.sigla;
                unidadeDTO.ativa = unidade.ativa;

                return unidadeDTO;
            }
            else
                return null;          
        }

        public List<UnidadeMedidaDTO> GetUnidadeMedidaLista()
        {
            Context db = new Context();
            List<UnidadeMedidaDTO> lista = (from unidademedida in db.unidademedida
                                            orderby unidademedida.idunidmedida
                                            select new UnidadeMedidaDTO
                                              {
                                                  idunidmedida = unidademedida.idunidmedida,
                                                  descricao = unidademedida.descricao,
                                                  sigla = unidademedida.sigla,
                                                  ativa = unidademedida.ativa
                                              }).ToList();
            return lista;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var unidade = db.unidademedida.FirstOrDefault();

            if (unidade != null)
                return db.unidademedida.Max(p => p.idunidmedida) + 1;
            else
                return 1;
        }
        public List<UnidadeMedidaDTO> GetUnidadeMedidaPesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<UnidadeMedidaDTO> lista = (from unidademedida in db.unidademedida
                                            orderby unidademedida.idunidmedida
                                            select new UnidadeMedidaDTO
                                            {
                                                idunidmedida = unidademedida.idunidmedida,
                                                descricao = unidademedida.descricao,
                                                sigla = unidademedida.sigla,
                                                ativa = unidademedida.ativa
                                            }).ToList();

            switch (ColunaPesquisa)
            {
                case "idunidmedida":
                    return new List<UnidadeMedidaDTO>(lista.Where(p => p.idunidmedida.ToString() == TextoPesquisa));
                case "descricao":
                    return new List<UnidadeMedidaDTO>(lista.Where(p => p.descricao.ToUpper().Contains(TextoPesquisa.ToUpper())));
                case "sigla":
                    return new List<UnidadeMedidaDTO>(lista.Where(p => p.sigla.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
