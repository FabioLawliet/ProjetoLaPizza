using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Views.Relatorios
{
    public partial class RelClientes : LaPizza.Views.FormBaseCadastros
    {
        public RelClientes()
        {
            InitializeComponent();
            LimpaCampos();
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        public void LimpaCampos()
        {
            txtNomeCliente.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCep.Text = "";
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        public List<ClienteDTO> GetClienteLista()
        {
            Context db = new Context();
            List<ClienteDTO> Lista = (from cliente in db.cliente
                                      join cidade in db.cidade on cliente.idcidade equals cidade.idcidade
                                      join estado in db.estado on cidade.idestado equals estado.idestado
                                      
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
            if(txtIdCliente.Text != "")
            {
                Lista = new List<ClienteDTO>(Lista.Where(p => p.idcliente == Convert.ToInt32(txtIdCliente.Text)));
                return Lista;
            }

            if(txtBairro.)

            return Lista;
        }
    }
}
