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
            this.Height = this.Height - 39;
            LimpaCampos();
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        public void LimpaCampos()
        {
            txtIdCliente.Text = "";
            txtNomeCliente.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
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
                Lista = new List<ClienteDTO>(Lista.Where(p => p.idcliente == Convert.ToInt32(txtIdCliente.Text)));

            if(txtNomeCliente.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.nomerazao == Convert.ToString(txtNomeCliente.Text)));

            if(txtCpf.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.cpfcnpj == Convert.ToString(txtCpf.Text)));

            if(txtRg.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.rgie == Convert.ToString(txtRg.Text)));

            if(txtCidade.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.cidadenome == Convert.ToString(txtCidade.Text)));

            if(txtEstado.Text != "")
                Lista = new List<ClienteDTO>(Lista.Where(p => p.estadosigla == Convert.ToString(txtEstado.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<ClienteDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 2)
                Lista = new List<ClienteDTO>(Lista.Where(p => p.ativo == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<ClienteDTO>(Lista.OrderBy(p => p.idcliente));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<ClienteDTO>(Lista.OrderBy(p => p.nomerazao));

            MascaraTelefone(Lista);

            return Lista;
        }

        private string AplicarMascaraTelefone(string strNumero)
        {
            // por omissão tem 10 ou menos dígitos
            string strMascara = "{0:(00)0000-0000}";
            // converter o texto em número
            long lngNumero = Convert.ToInt64(strNumero);

            if (strNumero.Length == 11)
                strMascara = "{0:(00)00000-0000}";

            return string.Format(strMascara, lngNumero);
        }

        private List<ClienteDTO> MascaraTelefone(List<ClienteDTO> Lista)
        {
            foreach(ClienteDTO Item in Lista)
            {
                Item.celular = AplicarMascaraTelefone(Item.celular);
            }
            return Lista;
        }

        private void txtIdCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                HabilitaAcao(TipoAcao.Cancelar, true);
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
                HabilitaAcao(TipoAcao.Cancelar, true);
                DesabilitaCampos(false);
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
            else
            {
                DesabilitaCampos(true);
                txtNomeCliente.Text = String.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            DesabilitaCampos(true);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Context db = new Context();

            DataTable dt = CollectionHelper.ConvertTo<ClienteDTO>(GetClienteLista());

            using (var frm = new RelClienteRV(dt))
            {
                frm.ShowDialog();
            }

            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        public void DesabilitaCampos(bool Ativo)
        {
            if (Ativo)
            {
                txtNomeCliente.Enabled = false;
                txtCpf.Enabled = true;
                txtRg.Enabled = true;
                txtCidade.Enabled = true;
                txtEstado.Enabled = true;
            }
            else
            {
                txtNomeCliente.Enabled = false;
                txtCpf.Enabled = false;
                txtRg.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtRg.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCpf.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtRg.Enabled = false;
            txtCidade.Enabled = false;
            txtCpf.Enabled = false;
        }

        /*private void HabilitaDesabilitaCampos_Leave(object sender, EventArgs e)
        {
            if (((LpText)sender).Text != "")
            {
                if (txtIdCliente.Name != ((LpText)sender).Name)
                    txtIdCliente.Enabled = !((LpText)sender).Enabled;

                if (txtNomeCliente.Name != ((LpText)sender).Name)
                    txtNomeCliente.Enabled = !((LpText)sender).Enabled;

                if (txtCpf.Name != ((LpText)sender).Name)
                    txtCpf.Enabled = !((LpText)sender).Enabled;

                if (txtRg.Name != ((LpText)sender).Name)
                    txtRg.Enabled = !((LpText)sender).Enabled;

                if (txtCidade.Name != ((LpText)sender).Name)
                    txtCidade.Enabled = !((LpText)sender).Enabled;

                if (txtEstado.Name != ((LpText)sender).Name)
                    txtEstado.Enabled = !((LpText)sender).Enabled;
            }
            else
            {
                if (txtIdCliente.Name != ((LpText)sender).Name)
                    txtIdCliente.Enabled = ((LpText)sender).Enabled;

                if (txtNomeCliente.Name != ((LpText)sender).Name)
                    txtNomeCliente.Enabled = ((LpText)sender).Enabled;

                if (txtCpf.Name != ((LpText)sender).Name)
                    txtCpf.Enabled = ((LpText)sender).Enabled;

                if (txtRg.Name != ((LpText)sender).Name)
                    txtRg.Enabled = ((LpText)sender).Enabled;

                if (txtCidade.Name != ((LpText)sender).Name)
                    txtCidade.Enabled = ((LpText)sender).Enabled;

                if (txtEstado.Name != ((LpText)sender).Name)
                    txtEstado.Enabled = ((LpText)sender).Enabled;
            }

        }*/
    }
}
