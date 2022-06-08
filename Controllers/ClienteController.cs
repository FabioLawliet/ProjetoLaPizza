using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class ClienteController
    {

        public void Adicionar(ClienteDto Cliente)
        {
            Context db = new Context();
            try
            {
                db.cliente.Add(Cliente);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar Cliente, feche o cadastro e tente novamente! \n\n" + ex.Message,
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var cliente = db.cliente.FirstOrDefault();

            if (cliente is null)
                return 1;
            else
                return db.cliente.Max(p => p.id) + 1;
        }

        public bool ExisteClienteCpf(string Cpfcnpj)
        {
            Context db = new Context();
            ClienteDto cliente = db.cliente.Where(p => p.cpfcnpj == Cpfcnpj).FirstOrDefault();

            if (cliente != null && cliente.cpfcnpj == Cpfcnpj)
                return true;
            else
                return false;
        }

        public void Editar(ClienteDto Cliente)
        {
            Context db = new Context();
            ClienteDto cliente = db.cliente.FirstOrDefault(p => p.id == Cliente.id);

            if (cliente != null)
            {
                try
                {
                    cliente.id = Cliente.id;
                    cliente.nome = Cliente.nome;
                    cliente.sobrenome = Cliente.sobrenome;
                    cliente.cpfcnpj = Cliente.cpfcnpj;
                    cliente.rg = Cliente.rg;
                    cliente.email = Cliente.email;
                    cliente.telefone = Cliente.telefone;
                    cliente.endereco = Cliente.endereco;
                    cliente.numero = Cliente.numero;
                    cliente.cidade = Cliente.cidade;
                    cliente.bairro = Cliente.bairro;
                    cliente.estado = Cliente.estado;
                    cliente.ativo = Cliente.ativo;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar o cliente, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            ClienteDto cliente = db.cliente.FirstOrDefault(p => p.id == Id);

            if (cliente != null)
            {
                try
                {
                    db.cliente.Remove(cliente);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o cliente, provavelmente existem movimentações no banco de dados para este cliente e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ExisteCliente(int Id)
        {
            Context db = new Context();
            var cliente = db.cliente.Where(p => p.id == Id).FirstOrDefault();

            if (cliente != null && cliente.id == Id)
                return true;
            else
                return false;
        }

        public ClienteModel GetCliente(int Id)
        {
            Context db = new Context();
            ClienteDto cliente = db.cliente.Where(p => p.id == Id).FirstOrDefault();
            ClienteModel clienteModel = new ClienteModel();

            if (cliente != null)
            {
                clienteModel.id = cliente.id;
                clienteModel.nome = cliente.nome;
                clienteModel.sobrenome = cliente.sobrenome;
                clienteModel.cpfcnpj = cliente.cpfcnpj;
                clienteModel.rg = cliente.rg;
                clienteModel.email = cliente.email;
                clienteModel.telefone = cliente.telefone;
                clienteModel.endereco = cliente.endereco;
                clienteModel.numero = cliente.numero;
                clienteModel.cidade = cliente.cidade;
                clienteModel.bairro = cliente.bairro;
                clienteModel.estado = cliente.estado;
                clienteModel.ativo = cliente.ativo;

                return clienteModel;
            }
            else
                return null;
        }

        public List<ClienteModel> GetClienteLista()
        {
            Context db = new Context();
            List<ClienteModel> lista = (from cliente in db.cliente
                                        orderby cliente.id
                                        select new ClienteModel
                                        {
                                            id = cliente.id,
                                            nome = cliente.nome,
                                            sobrenome = cliente.sobrenome,
                                            cpfcnpj = cliente.cpfcnpj,
                                            rg = cliente.rg,
                                            email = cliente.email,
                                            telefone = cliente.telefone,
                                            endereco = cliente.endereco,
                                            numero = cliente.numero,
                                            cidade = cliente.cidade,
                                            bairro = cliente.bairro,
                                            estado = cliente.estado,
                                            ativo = cliente.ativo,
                                        }).ToList();
            return lista;
        }

        public List<ClienteModel> GetClientePesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<ClienteModel> lista = (from cliente in db.cliente
                                        orderby cliente.id
                                        select new ClienteModel
                                        {
                                            id = cliente.id,
                                            nome = cliente.nome,
                                            sobrenome = cliente.sobrenome,
                                            cpfcnpj = cliente.cpfcnpj,
                                            rg = cliente.rg,
                                            email = cliente.email,
                                            telefone = cliente.telefone,
                                            endereco = cliente.endereco,
                                            numero = cliente.numero,
                                            cidade = cliente.cidade,
                                            bairro = cliente.bairro,
                                            estado = cliente.estado,
                                            ativo = cliente.ativo,
                                        }).ToList();

            return new List<ClienteModel>(lista.Where(p => p.nome.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }
    }
}
