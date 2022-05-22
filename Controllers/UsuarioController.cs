﻿using LaPizza.Models;
using LaPizza.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}