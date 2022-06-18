using LaPizza.Models;
using LaPizza.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class UsuarioController
    {
        public UsuarioController() { }

        public void AdicionarUsuario(UsuarioDto usuario)
        {
            Context context = new Context();
            context.usuario.Add(usuario);
            context.SaveChanges();
        }
        public void EditarUsuario(UsuarioDto usuario)
        {
            Context context = new Context();
            UsuarioDto u = context.usuario.FirstOrDefault(x => x.id == usuario.id);
            if (usuario != null)
            {
                u.id = usuario.id;
                u.nome = usuario.nome;
                u.usuario = usuario.usuario;
                u.senha = usuario.senha;
                u.ativo = usuario.ativo;
                context.SaveChanges();
            }
        }
        public void Excluir(int Id)
        {
            Context context = new Context();
            UsuarioDto usuario = context.usuario.FirstOrDefault(x => x.id == Id);

            if (usuario != null)
            {
                context.usuario.Remove(usuario);
                context.SaveChanges();
            }
        }
        public List<UsuarioModel> GetUsuarioPesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<UsuarioModel> lista = (from usuario in db.usuario
                                        orderby usuario.id
                                        select new UsuarioModel
                                        {
                                            id = usuario.id,
                                            nome = usuario.nome,
                                            usuario = usuario.usuario,
                                            senha = usuario.senha,
                                            ativo = usuario.ativo
                                        }).ToList();

            return new List<UsuarioModel>(lista.Where(p => p.nome.ToUpper().Contains(TextoPesquisa.ToUpper())));

        }
        public bool UsuarioJaExiste(string Texto)
        {
            Context context = new Context();
            UsuarioDto usuario = context.usuario.FirstOrDefault(x => x.usuario == Texto);
            if (usuario != null)
            {
                MessageBox.Show("Usuário já existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<UsuarioModel> GetUsuarioLista()
        {
            Context db = new Context();
            return (from usuario in db.usuario
                    orderby usuario.id
                    select new UsuarioModel
                    {
                        id = usuario.id,
                        nome = usuario.nome,
                        usuario = usuario.usuario,
                        senha = usuario.senha,
                        ativo = usuario.ativo
                    }).ToList();
        }
        public UsuarioModel GetUsuario(int Id)
        {
            Context db = new Context();
            UsuarioDto usu = db.usuario.Where(p => p.id == Id).FirstOrDefault();
            UsuarioModel usuarioModel = new UsuarioModel();

            if (usu != null)
            {
                usuarioModel.id = usu.id;
                usuarioModel.nome = usu.nome;
                usuarioModel.usuario = usu.usuario;
                usuarioModel.senha = usu.senha;
                usuarioModel.ativo = usu.ativo;

                return usuarioModel;
            }
            else
                return null;
        }
        public int GetProximoId()
        {
            Context db = new Context();
            var usuario = db.usuario.FirstOrDefault();

            if (usuario != null)
                return db.usuario.Max(p => p.id) + 1;
            else
                return 1;
        }
        public int ValidaLogin(string usuario, string senha)
        {
            Context context = new Context();
            UsuarioDto Usuario = context.usuario.FirstOrDefault(x => x.usuario == usuario
                                                                && x.senha == senha);
            // 1 - Retorno correto
            if (Usuario != null)
                return 1;
            // 2 - Usuario não preenchido
            if (usuario == "")
                return 2;
            //3 - Senha não preenchida
            if (senha == "")
                return 3;
            // 4 - Usuario ou senha errados
            else if (Usuario == null)
                return 4;

            return 1;
        }
    }
}
