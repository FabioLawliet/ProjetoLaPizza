using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    internal class FornecedorController
    {
        public void Adicionar(FornecedorDB Fornecedor)
        {
            Context db = new Context();
            try
            {
                db.fornecedor.Add(Fornecedor);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar Fornecedor, feche o cadastro e tente novamente! \n\n" + ex.Message,
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var fornecedor = db.fornecedor.FirstOrDefault();

            if (fornecedor is null)
                return 1;
            else
                return db.fornecedor.Max(p => p.idfornecedor) + 1;
        }

        public bool ExisteFornecedor(int Id)
        {
            Context db = new Context();
            var fornecedor = db.fornecedor.Where(p => p.idfornecedor == Id).FirstOrDefault();

            if (fornecedor != null && fornecedor.idfornecedor == Id)
                return true;
            else
                return false;
        }

        public bool ExisteFonecedorCnpjCpf(string Cnpjcpf)
        {
            Context db = new Context();
            FornecedorDB fornecedor = db.fornecedor.Where(p => p.cpfcnpj == Cnpjcpf).FirstOrDefault();

            if (fornecedor != null && fornecedor.cpfcnpj == Cnpjcpf)
                return true;
            else
                return false;
        }

        public void Editar(FornecedorDB Fornecedor)
        {
            Context db = new Context();
            FornecedorDB fornecedor = db.fornecedor.FirstOrDefault(p => p.idfornecedor == Fornecedor.idfornecedor);

            if (fornecedor != null)
            {
                try
                {
                    fornecedor.idfornecedor = Fornecedor.idfornecedor;
                    fornecedor.nomerazao = Fornecedor.nomerazao;
                    fornecedor.cpfcnpj = Fornecedor.cpfcnpj;
                    fornecedor.rgie = Fornecedor.rgie;
                    fornecedor.email = Fornecedor.email;
                    fornecedor.endereco = Fornecedor.endereco;
                    fornecedor.numero = Fornecedor.numero;
                    fornecedor.bairro = Fornecedor.bairro;
                    fornecedor.complemento = Fornecedor.complemento;
                    fornecedor.idcidade = fornecedor.idcidade;
                    fornecedor.cep = fornecedor.cep;
                    fornecedor.telefone = Fornecedor.telefone;
                    fornecedor.celular = Fornecedor.celular;
                    fornecedor.ativo = Fornecedor.ativo;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar o fornecedor, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Excluir(int Id)
        {
            Context db = new Context();
            FornecedorDB fornecedor = db.fornecedor.FirstOrDefault(p => p.idfornecedor == Id);

            if (fornecedor != null)
            {
                try
                {
                    db.fornecedor.Remove(fornecedor);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o fornecedor, provavelmente existem movimentações no banco de dados para este cliente e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public FornecedorDTO GetFornecedor(int Id)
        {
            Context db = new Context();
            List<FornecedorDTO> lista = (from fornecedor in db.fornecedor
                                        join cidade in db.cidade on fornecedor.idcidade equals cidade.idcidade
                                        join estado in db.estado on cidade.idcidade equals estado.idestado
                                         where fornecedor.idfornecedor == Id
                                      orderby fornecedor.idfornecedor
                                      select new FornecedorDTO
                                      {
                                          idfornecedor = fornecedor.idfornecedor,
                                          nomerazao = fornecedor.nomerazao,
                                          cpfcnpj = fornecedor.cpfcnpj,
                                          rgie = fornecedor.rgie,
                                          email = fornecedor.email,
                                          endereco = fornecedor.endereco,
                                          numero = fornecedor.numero,
                                          bairro = fornecedor.bairro,
                                          complemento = fornecedor.complemento,
                                          idcidade = fornecedor.idcidade,
                                          cidadenome = cidade.nome,
                                          estadosigla = estado.sigla,
                                          cep = fornecedor.cep,
                                          telefone = fornecedor.telefone,
                                          celular = fornecedor.celular,
                                          ativo = fornecedor.ativo,
                                      }).ToList();
            return lista[0];
        }

        public List<FornecedorDTO> GetFornecedorLista()
        {
            Context db = new Context();
            List<FornecedorDTO> lista = (from fornecedor in db.fornecedor
                                         join cidade in db.cidade on fornecedor.idcidade equals cidade.idcidade
                                         join estado in db.estado on cidade.idestado equals estado.idestado
                                         orderby fornecedor.idfornecedor
                                         select new FornecedorDTO
                                         {
                                             idfornecedor = fornecedor.idfornecedor,
                                             nomerazao = fornecedor.nomerazao,
                                             cpfcnpj = fornecedor.cpfcnpj,
                                             rgie = fornecedor.rgie,
                                             email = fornecedor.email,
                                             endereco = fornecedor.endereco,
                                             numero = fornecedor.numero,
                                             bairro = fornecedor.bairro,
                                             complemento = fornecedor.complemento,
                                             idcidade = fornecedor.idcidade,
                                             cidadenome = cidade.nome,
                                             estadosigla = estado.sigla,
                                             cep = fornecedor.cep,
                                             telefone = fornecedor.telefone,
                                             celular = fornecedor.celular,
                                             ativo = fornecedor.ativo,
                                         }).ToList();
            return lista;
        }

        public List<FornecedorDTO> GetFornecedorPesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<FornecedorDTO> lista = (from fornecedor in db.fornecedor
                                         join cidade in db.cidade on fornecedor.idcidade equals cidade.idcidade
                                         join estado in db.estado on cidade.idestado equals estado.idestado
                                         orderby fornecedor.idfornecedor
                                         select new FornecedorDTO
                                         {
                                             idfornecedor = fornecedor.idfornecedor,
                                             nomerazao = fornecedor.nomerazao,
                                             cpfcnpj = fornecedor.cpfcnpj,
                                             rgie = fornecedor.rgie,
                                             email = fornecedor.email,
                                             endereco = fornecedor.endereco,
                                             numero = fornecedor.numero,
                                             bairro = fornecedor.bairro,
                                             complemento = fornecedor.complemento,
                                             idcidade = fornecedor.idcidade,
                                             cidadenome = cidade.nome,
                                             estadosigla = estado.sigla,
                                             cep = fornecedor.cep,
                                             telefone = fornecedor.telefone,
                                             celular = fornecedor.celular,
                                             ativo = fornecedor.ativo,
                                          }).ToList();

            return new List<FornecedorDTO>(lista.Where(p => p.nomerazao.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }
    }
}
