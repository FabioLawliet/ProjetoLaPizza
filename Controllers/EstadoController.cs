using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class EstadoController
    {
        public void Adicionar(EstadoDB Estado)
        {
            Context db = new Context();
            try
            {
                db.estado.Add(Estado);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar a marca, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Editar(EstadoDB Estado)
        {
            Context db = new Context();
            EstadoDB estado = db.estado.FirstOrDefault(p => p.idestado == Estado.idestado);

            if (estado != null)
            {
                try
                {
                    estado.nome = Estado.nome;
                    estado.sigla = Estado.sigla;
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
            EstadoDB estado = db.estado.FirstOrDefault(p => p.idestado == Id);

            if (estado != null)
            {
                try
                {
                    db.estado.Remove(estado);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir a marca, provavelmente existem movimentações no banco de dados para esta marca e ela não poderá ser excluída! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ExisteEstado(int Id)
        {
            Context db = new Context();
            var estado = db.estado.Where(p => p.idestado == Id).FirstOrDefault();

            if (estado != null && estado.idestado == Id)
                return true;
            else
                return false;
        }

        public EstadoDTO GetEstado(int Id)
        {
            Context db = new Context();
            EstadoDB estado = db.estado.Where(p => p.idestado == Id).FirstOrDefault();
            EstadoDTO estadoModel = new EstadoDTO();

            if (estado != null)
            {
                estadoModel.idestado = estado.idestado;
                estadoModel.nome = estado.nome;
                estadoModel.sigla = estado.sigla;

                return estadoModel;
            }
            else
                return null;
        }

        public List<EstadoDTO> GetEstadoLista()
        {
            Context db = new Context();
            List<EstadoDTO> lista = (from estado in db.estado
                                    orderby estado.idestado
                                    select new EstadoDTO
                                    {
                                        idestado = estado.idestado,
                                        nome = estado.nome,
                                        sigla = estado.sigla
                                    }).ToList();
            return lista;
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var estado = db.estado.FirstOrDefault();

            if (estado != null)
                return db.estado.Max(p => p.idestado) + 1;
            else
                return 1;
        }

        public List<EstadoDTO> GetEstadoPesquisaGrid(string TextoPesquisa, string ColunaPesquisa)
        {
            Context db = new Context();
            List<EstadoDTO> lista = (from estado in db.estado
                                    orderby estado.idestado
                                    select new EstadoDTO
                                    {
                                        idestado = estado.idestado,
                                        nome = estado.nome,
                                        sigla = estado.sigla
                                    }).ToList();

            switch (ColunaPesquisa)
            {
                case "idestado":
                    return new List<EstadoDTO>(lista.Where(p => p.idestado.ToString() == TextoPesquisa));
                case "nome":
                    return new List<EstadoDTO>(lista.Where(p => p.nome.ToUpper().Contains(TextoPesquisa.ToUpper())));
                default:
                    return lista;
            }
        }
    }
}
