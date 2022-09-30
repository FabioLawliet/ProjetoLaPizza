using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Views.PesquisasAnaliticas
{
    public partial class PesqAnaliticaClientes : LaPizza.Views.FormBaseCadastros
    {
        public PesqAnaliticaClientes()
        {
            InitializeComponent();
            IniciaCampos();
        }

        private void IniciaCampos()
        {
            cbTipoOrdenacao.SelectedIndex = 0;
            cbPesquisarAtivos.SelectedIndex = 0;
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteId.Text != "")
            {
                ClienteController Controle = new ClienteController();
                ClienteDTO Cliente = new ClienteDTO();

                var id = Int32.Parse(txtClienteId.Text);

                if (Controle.ExisteCliente(id))
                {
                    Cliente = Controle.GetCliente(id);
                    txtNomeCliente.Text = Cliente.nomerazao;
                }
                else
                    txtNomeCliente.Text = String.Empty;
            }
        }

        private void txtClienteId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormRecClientePesquisa Pesq = new FormRecClientePesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtClienteId.Text = Pesq.PesqCliente.idcliente.ToString();
                    txtNomeCliente.Text = Pesq.PesqCliente.nomerazao;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text != String.Empty)
            {
                GridCliente.DataSource = GetClienteLista();

                if (GridCliente.RowCount <= 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum Cliente com os filtros informados!", "informação", MessageBoxButtons.OK);
                }
                else
                {
                    AjustaColunas();
                    GridCliente.Enabled = true;
                    BoxFiltro.Enabled = false;
                    btnPesquisar.BackColor = btnCancelar.BackColor;
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
            }
            else
            {
                GridCliente.DataSource = GetClienteCidadeLista(txtNomeCidade.Text);

                if (GridCliente.RowCount <= 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum Cliente com os filtros informados!", "informação", MessageBoxButtons.OK);
                }
                else
                {
                    AjustaColunas();
                    GridCliente.Enabled = true;
                    BoxFiltro.Enabled = false;
                    btnPesquisar.BackColor = btnCancelar.BackColor;
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
            }
        }

        private void AjustaColunas()
        {
            GridCliente.Columns["idcliente"].DisplayIndex = 0;
            GridCliente.Columns["nomerazao"].DisplayIndex = 1;
            GridCliente.Columns["rgie"].DisplayIndex = 2;
            GridCliente.Columns["cpfcnpj"].DisplayIndex = 3;
            GridCliente.Columns["endereco"].DisplayIndex = 4;
            GridCliente.Columns["numero"].DisplayIndex = 5;
            GridCliente.Columns["bairro"].DisplayIndex = 6;
            GridCliente.Columns["complemento"].DisplayIndex = 7;
            GridCliente.Columns["cep"].DisplayIndex = 8;
            GridCliente.Columns["cidadenome"].DisplayIndex = 9;
            GridCliente.Columns["estadosigla"].DisplayIndex = 10;
            GridCliente.Columns["idcidade"].DisplayIndex = 11;
            GridCliente.Columns["telefone"].DisplayIndex = 12;
            GridCliente.Columns["celular"].DisplayIndex = 13;
            GridCliente.Columns["email"].DisplayIndex = 14;
            GridCliente.Columns["ativo"].DisplayIndex = 15;
        }

        public List<ClienteDTO> GetClienteLista()
        {
            Context db = new Context();
            List<ClienteDTO> Lista = (from cliente in db.cliente
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

            if (txtClienteId.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.idcliente == Convert.ToInt32(txtClienteId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 0)
                Lista = new List<ClienteDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<ClienteDTO>(Lista.Where(p => p.ativo == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<ClienteDTO>(Lista.OrderBy(p => p.idcliente));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<ClienteDTO>(Lista.OrderBy(p => p.nomerazao));

            return Lista;
        }

        public List<ClienteDTO> GetClienteCidadeLista(string nome)
        {
            Context db = new Context();
            List<ClienteDTO> Lista = (from cliente in db.cliente
                                      join cidade in db.cidade on cliente.idcidade equals cidade.idcidade
                                      join estado in db.estado on cidade.idestado equals estado.idestado
                                      orderby cliente.idcliente
                                      where cidade.nome == nome
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

            if (txtClienteId.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.idcliente == Convert.ToInt32(txtClienteId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 0)
                Lista = new List<ClienteDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<ClienteDTO>(Lista.Where(p => p.ativo == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<ClienteDTO>(Lista.OrderBy(p => p.idcliente));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<ClienteDTO>(Lista.OrderBy(p => p.nomerazao));

            return Lista;
        }

        private void ClearAllComponentsForm()
        {
            txtClienteId.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtCidadeId.Text = string.Empty;
            txtNomeCidade.Text = string.Empty;
            IniciaCampos();
            GridCliente.DataSource = null;
        }

        private void txtCidadeId_TextChanged(object sender, EventArgs e)
        {
            if (txtCidadeId.Text != "")
            {
                CidadeController Controle = new CidadeController();
                CidadeDTO Cidade = new CidadeDTO();

                var id = Int32.Parse(txtCidadeId.Text);

                if (Controle.ExisteCidadeId(id))
                {
                    Cidade = Controle.GetCidade(id);
                    txtNomeCidade.Text = Cidade.nome;
                }
                else
                    txtNomeCidade.Text = String.Empty;
            }
        }

        private void txtCidadeId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormCidadePesquisa Pesq = new FormCidadePesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtCidadeId.Text = Pesq.PesqCidade.idcidade.ToString();
                    txtNomeCidade.Text = Pesq.PesqCidade.nome;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             ClearAllComponentsForm();
             BoxFiltro.Enabled = true;
             btnPesquisar.BackColor = btnSair.BackColor;
            if (txtClienteId.CanFocus)
            {
                txtClienteId.Focus();
            }
        }
    }
}
