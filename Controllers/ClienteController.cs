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

        public void Adicionar(ClienteDB Cliente)
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
                return db.cliente.Max(p => p.idcliente) + 1;
        }

        public bool ExisteClienteCpf(string Cpfcnpj)
        {
            Context db = new Context();
            ClienteDB cliente = db.cliente.Where(p => p.cpfcnpj == Cpfcnpj).FirstOrDefault();

            if (cliente != null && cliente.cpfcnpj == Cpfcnpj)
                return true;
            else
                return false;
        }

        public void Editar(ClienteDB Cliente)
        {
            Context db = new Context();
            ClienteDB cliente = db.cliente.FirstOrDefault(p => p.idcliente == Cliente.idcliente);

            if (cliente != null)
            {
                try
                {
                    cliente.idcliente = Cliente.idcliente;
                    cliente.nomerazao = Cliente.nomerazao;
                    cliente.cpfcnpj = Cliente.cpfcnpj;
                    cliente.rgie = Cliente.rgie;
                    cliente.email = Cliente.email;
                    cliente.telefone = Cliente.telefone;
                    cliente.endereco = Cliente.endereco;
                    cliente.complemento = Cliente.complemento;
                    cliente.numero = Cliente.numero;
                    cliente.idcidade = Cliente.idcidade;
                    cliente.bairro = Cliente.bairro;
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
            ClienteDB cliente = db.cliente.FirstOrDefault(p => p.idcliente == Id);

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
            var cliente = db.cliente.Where(p => p.idcliente == Id).FirstOrDefault();

            if (cliente != null && cliente.idcliente == Id)
                return true;
            else
                return false;
        }

        public ClienteDTO GetCliente(int Id)
        {
            Context db = new Context();
            List<ClienteDTO> lista = (from cliente in db.cliente
                                      join cidade in db.cidade on cliente.idcidade equals cidade.idcidade
                                      join estado in db.estado on cidade.idestado equals estado.idestado
                                      where cliente.idcliente == Id
                                      select new ClienteDTO
                                      {
                                          idcliente = cliente.idcliente,
                                          nomerazao = cliente.nomerazao,
                                          cpfcnpj = cliente.cpfcnpj,
                                          rgie = cliente.rgie,
                                          email = cliente.email,
                                          endereco = cliente.endereco,
                                          numero = cliente.numero,
                                          bairro = cliente.bairro,
                                          complemento = cliente.complemento,
                                          idcidade = cliente.idcidade,
                                          cidadenome = cidade.nome,
                                          estadosigla = estado.sigla,
                                          cep = cliente.cep,
                                          telefone = cliente.telefone,
                                          celular = cliente.celular,
                                          ativo = cliente.ativo,
                                      }).ToList();
            return lista[0];
        }

        public List<ClienteDTO> GetClienteLista()
        {
            Context db = new Context();
            List<ClienteDTO> lista = (from cliente in db.cliente
                                      join cidade in db.cidade on cliente.idcidade equals cidade.idcidade
                                      join estado in db.estado on cidade.idestado equals estado.idestado
                                      orderby cliente.idcliente
                                      select new ClienteDTO
                                      {
                                          idcliente = cliente.idcliente,
                                          nomerazao = cliente.nomerazao,
                                          cpfcnpj = cliente.cpfcnpj,
                                          rgie = cliente.rgie,
                                          email = cliente.email,
                                          endereco = cliente.endereco,
                                          numero = cliente.numero,
                                          bairro = cliente.bairro,
                                          complemento = cliente.complemento,
                                          idcidade = cliente.idcidade,
                                          cidadenome = cidade.nome,
                                          estadosigla = estado.sigla,
                                          cep = cliente.cep,
                                          telefone = cliente.telefone,
                                          celular = cliente.celular,
                                          ativo = cliente.ativo,
                                      }).ToList();
            return lista;
        }

        public List<ClienteDTO> GetClientePesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<ClienteDTO> lista = (from cliente in db.cliente
                                      join cidade in db.cidade on cliente.idcidade equals cidade.idcidade
                                      join estado in db.estado on cidade.idestado equals estado.idestado
                                      orderby cliente.idcliente
                                      select new ClienteDTO
                                      {
                                            idcliente = cliente.idcliente,
                                            nomerazao = cliente.nomerazao,
                                            cpfcnpj = cliente.cpfcnpj,
                                            rgie = cliente.rgie,
                                            email = cliente.email,
                                            endereco = cliente.endereco,
                                            numero = cliente.numero,
                                            bairro = cliente.bairro,
                                            complemento = cliente.complemento,
                                            idcidade = cliente.idcidade,
                                            cidadenome = cidade.nome,
                                            estadosigla = estado.sigla,
                                            cep = cliente.cep,
                                            telefone = cliente.telefone,
                                            celular = cliente.celular,
                                            ativo = cliente.ativo,
                                        }).ToList();

            return new List<ClienteDTO>(lista.Where(p => p.nomerazao.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }

        public bool ExisteNomeCliente(string Nome)
        {
            Context db = new Context();
            var cliente = db.cliente.Where(p => p.nomerazao == Nome).FirstOrDefault();

            if (cliente != null && cliente.nomerazao == Nome)
                return true;
            else
                return false;
        }
    }
}
