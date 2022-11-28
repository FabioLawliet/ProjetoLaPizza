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

            if(txtNomeCliente.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.nomerazao == Convert.ToString(txtIdCliente.Text)));

            if(txtCpf.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.cpfcnpj == Convert.ToString(txtIdCliente.Text)));

            if(txtRg.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.rgie == Convert.ToString(txtIdCliente.Text)));

            if(txtBairro.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.bairro == Convert.ToString(txtIdCliente.Text)));

            if(txtCidade.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.cidadenome == Convert.ToString(txtIdCliente.Text)));

            if(txtEstado.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.estadosigla == Convert.ToString(txtIdCliente.Text)));

            if(txtCep.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.cep == Convert.ToString(txtIdCliente.Text)));

            return Lista;
        }

        private void txtIdCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormRecClientePesquisa Pesq = new FormRecClientePesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtIdCliente.Text = Pesq.PesqCliente.idcliente.ToString();
                    txtNomeCliente.Text = Pesq.PesqCliente.nomerazao;
                }
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text != "")
            {
                ClienteController Controle = new ClienteController();
                ClienteDTO Cliente = new ClienteDTO();

                var id = Int32.Parse(txtIdCliente.Text);

                if (Controle.ExisteCliente(id))
                {
                    Cliente = Controle.GetCliente(id);
                    txtNomeCliente.Text = Cliente.nomerazao;
                }
                else
                    txtNomeCliente.Text = String.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
