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
    public partial class RelFornecedor : LaPizza.Views.FormBaseCadastros
    {
        public RelFornecedor()
        {
            InitializeComponent();
            this.Height = this.Height - 39;
            LimpaCampos();
            HabilitaAcao(TipoAcao.Confirmar, true);
        }
        public void LimpaCampos()
        {
            txtIdFornecedor.Text = "";
            txtNomeFornecedor.Text = "";
            txtCnpj.Text = "";
            txtIe.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            HabilitaAcao(TipoAcao.Confirmar, true);
        }
        public List<FornecedorDTO> GetFornecedorLista()
        {
            Context db = new Context();
            List<FornecedorDTO> Lista = (from fornecedor in db.fornecedor
                                         join cidade in db.cidade on fornecedor.idcidade equals cidade.idcidade
                                      join estado in db.estado on cidade.idestado equals estado.idestado
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
            if (txtIdFornecedor.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.idfornecedor == Convert.ToInt32(txtIdFornecedor.Text)));

            if (txtNomeFornecedor.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.nomerazao == Convert.ToString(txtNomeFornecedor.Text)));

            if (txtCnpj.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.cpfcnpj == Convert.ToString(txtCnpj.Text)));

            if (txtIe.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.rgie == Convert.ToString(txtIe.Text)));

            if (txtCidade.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.cidadenome == Convert.ToString(txtCidade.Text)));

            if (txtEstado.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.estadosigla == Convert.ToString(txtEstado.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 2)
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.ativo == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<FornecedorDTO>(Lista.OrderBy(p => p.idfornecedor));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<FornecedorDTO>(Lista.OrderBy(p => p.nomerazao));

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
        private List<FornecedorDTO> MascaraTelefone(List<FornecedorDTO> Lista)
        {
            foreach (FornecedorDTO Item in Lista)
            {
                Item.celular = AplicarMascaraTelefone(Item.celular);
            }
            return Lista;
        }

        private void txtIdFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                HabilitaAcao(TipoAcao.Cancelar, true);
                FormRecFornecedorPesquisa Pesq = new FormRecFornecedorPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtIdFornecedor.Text = Pesq.PesqFornecedor.idfornecedor.ToString();
                    txtNomeFornecedor.Text = Pesq.PesqFornecedor.nomerazao;
                }
            }
        }

        private void txtIdFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text != "")
            {
                HabilitaAcao(TipoAcao.Cancelar, true);
                DesabilitaCampos(false);
                FornecedorController Controle = new FornecedorController();
                FornecedorDTO Fornecedor = new FornecedorDTO();

                var id = Int32.Parse(txtIdFornecedor.Text);

                if (Controle.ExisteFornecedor(id))
                {
                    Fornecedor = Controle.GetFornecedor(id);
                    txtNomeFornecedor.Text = Fornecedor.nomerazao;
                }
                else
                    txtNomeFornecedor.Text = String.Empty;
            }
            else
            {
                DesabilitaCampos(true);
                txtNomeFornecedor.Text = String.Empty;
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

            DataTable dt = CollectionHelper.ConvertTo<FornecedorDTO>(GetFornecedorLista());

            using (var frm = new RelFornecedoresRV(dt))
            {
                frm.ShowDialog();
            }

            HabilitaAcao(TipoAcao.Confirmar, true);
        }
        public void DesabilitaCampos(bool Ativo)
        {
            if (Ativo)
            {
                txtNomeFornecedor.Enabled = false;
                txtCnpj.Enabled = true;
                txtIe.Enabled = true;
                txtCidade.Enabled = true;
                txtEstado.Enabled = true;
            }
            else
            {
                txtNomeFornecedor.Enabled = false;
                txtCnpj.Enabled = false;
                txtIe.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
            }
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdFornecedor.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtIe.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void txtIe_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdFornecedor.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtCnpj.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdFornecedor.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtIe.Enabled = false;
            txtCnpj.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            HabilitaAcao(TipoAcao.Cancelar, true);
            txtIdFornecedor.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtIe.Enabled = false;
            txtCidade.Enabled = false;
            txtCnpj.Enabled = false;
        }
    }
}
