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
                MessageBox.Show("Houve um problema ao cadastrar Cliente, feche o cadastro e tente novamente! \n\n" + ex.Message,
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
                return db.fornecedor.Max(p => p.id) + 1;
        }

        public bool ExisteFonecedorCnpjCpf(string Cnpjcpf)
        {
            Context db = new Context();
            FornecedorDB fornecedor = db.fornecedor.Where(p => p.cnpjcpf == Cnpjcpf).FirstOrDefault();

            if (fornecedor != null && fornecedor.cnpjcpf == Cnpjcpf)
                return true;
            else
                return false;
        }

        public void Editar(FornecedorDB Fornecedor)
        {
            Context db = new Context();
            FornecedorDB fornecedor = db.fornecedor.FirstOrDefault(p => p.id == Fornecedor.id);

            if (fornecedor != null)
            {
                try
                {
                    fornecedor.id = Fornecedor.id;
                    fornecedor.razaosocial = Fornecedor.razaosocial;
                    fornecedor.nomefantasia = Fornecedor.nomefantasia;
                    fornecedor.cnpjcpf = Fornecedor.cnpjcpf;
                    fornecedor.inscricaoestadual = Fornecedor.inscricaoestadual;
                    fornecedor.endereco = Fornecedor.endereco;
                    fornecedor.numero = Fornecedor.numero;
                    fornecedor.bairro = Fornecedor.bairro;
                    fornecedor.cidade = Fornecedor.cidade;
                    fornecedor.estado = Fornecedor.estado;
                    fornecedor.telefone = Fornecedor.telefone;
                    fornecedor.email = Fornecedor.email;
                    fornecedor.ativo = Fornecedor.ativo;
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
            FornecedorDB fornecedor = db.fornecedor.FirstOrDefault(p => p.id == Id);

            if (fornecedor != null)
            {
                try
                {
                    db.fornecedor.Remove(fornecedor);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível excluir o cliente, provavelmente existem movimentações no banco de dados para este cliente e ele não poderá ser excluído! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public FornecedorDTO GetFornecedor(int Id)
        {
            Context db = new Context();
            FornecedorDB fornecedor = db.fornecedor.Where(p => p.id == Id).FirstOrDefault();
            FornecedorDTO fornecedorModel = new FornecedorDTO();

            if (fornecedor != null)
            {

                fornecedorModel.id = fornecedor.id;
                fornecedorModel.razaosocial = fornecedor.razaosocial;
                fornecedorModel.nomefantasia = fornecedor.nomefantasia;
                fornecedorModel.cnpjcpf = fornecedor.cnpjcpf;
                fornecedorModel.inscricaoestadual = fornecedor.inscricaoestadual;
                fornecedorModel.endereco = fornecedor.endereco;
                fornecedorModel.numero = fornecedor.numero;
                fornecedorModel.bairro = fornecedor.bairro;
                fornecedorModel.cidade = fornecedor.cidade;
                fornecedorModel.estado = fornecedor.estado;
                fornecedorModel.telefone = fornecedor.telefone;
                fornecedorModel.email = fornecedor.email;
                fornecedorModel.ativo = fornecedor.ativo;

            
                return fornecedorModel;
            }
            else
                return null;
        }

        public List<FornecedorDTO> GetFornecedorLista()
        {
            Context db = new Context();
            List<FornecedorDTO> lista = (from fornecedor in db.fornecedor
                                           orderby fornecedor.id
                                        select new FornecedorDTO
                                        {
                                            id = fornecedor.id,
                                            razaosocial = fornecedor.razaosocial,
                                            nomefantasia = fornecedor.nomefantasia,
                                            cnpjcpf = fornecedor.cnpjcpf,
                                            inscricaoestadual = fornecedor.inscricaoestadual,
                                            endereco = fornecedor.endereco,
                                            numero = fornecedor.numero,
                                            bairro = fornecedor.bairro,
                                            cidade = fornecedor.cidade,
                                            estado = fornecedor.estado,
                                            telefone = fornecedor.telefone,
                                            email = fornecedor.email,
                                            ativo = fornecedor.ativo,
                                        }).ToList();
            return lista;
        }

        public List<FornecedorDTO> GetFornecedorPesquisaGrid(string TextoPesquisa)
        {
            Context db = new Context();
            List<FornecedorDTO> lista = (from fornecedor in db.fornecedor
                                           orderby fornecedor.id
                                        select new FornecedorDTO
                                        {
                                            id = fornecedor.id,
                                            razaosocial = fornecedor.razaosocial,
                                            nomefantasia = fornecedor.nomefantasia,
                                            cnpjcpf = fornecedor.cnpjcpf,
                                            inscricaoestadual = fornecedor.inscricaoestadual,
                                            endereco = fornecedor.endereco,
                                            numero = fornecedor.numero,
                                            bairro = fornecedor.bairro,
                                            cidade = fornecedor.cidade,
                                            estado = fornecedor.estado,
                                            telefone = fornecedor.telefone,
                                            email = fornecedor.email,
                                            ativo = fornecedor.ativo,
                                        }).ToList();

            return new List<FornecedorDTO>(lista.Where(p => p.razaosocial.ToUpper().Contains(TextoPesquisa.ToUpper())));
        }
    }
}
