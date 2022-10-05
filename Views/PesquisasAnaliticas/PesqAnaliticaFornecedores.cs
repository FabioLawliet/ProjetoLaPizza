using LaPizza.Controllers;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LaPizza.DAO;

namespace LaPizza.Views.PesquisasAnaliticas
{
    public partial class PesqAnaliticaFornecedores : LaPizza.Views.FormBaseCadastros
    {
        public PesqAnaliticaFornecedores()
        {
            InitializeComponent();
            IniciaCampos();
        }

        private void IniciaCampos()
        {
            cbTipoOrdenacao.SelectedIndex = 0;
            cbPesquisarAtivos.SelectedIndex = 0;
        }

        private void txtFornecedorId_TextChanged(object sender, EventArgs e)
        {
            if (txtFornecedorId.Text != "")
            {
                FornecedorController Controle = new FornecedorController();
                FornecedorDTO Fornecedor = new FornecedorDTO();

                var id = Int32.Parse(txtFornecedorId.Text);

                if (Controle.ExisteFornecedor(id))
                {
                    Fornecedor = Controle.GetFornecedor(id);
                    txtNomeFornecedor.Text = Fornecedor.nomerazao;
                }
                else
                    txtNomeFornecedor.Text = String.Empty;
            }
        }

        private void txtFornecedorId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormRecFornecedorPesquisa Pesq = new FormRecFornecedorPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtFornecedorId.Text = Pesq.PesqFornecedor.idfornecedor.ToString();
                    txtNomeFornecedor.Text = Pesq.PesqFornecedor.nomerazao;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtFornecedorId.Text != String.Empty && txtCidadeId.Text == String.Empty)
            {
                GridFornecedor.DataSource = GetFornecedorLista();

                if (GridFornecedor.RowCount <= 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum Fornecedor com os filtros informados!", "informação", MessageBoxButtons.OK);
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
                else
                {
                    AjustaColunas();
                    GridFornecedor.Enabled = true;
                    BoxFiltro.Enabled = false;
                    btnPesquisar.BackColor = btnCancelar.BackColor;
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
            }
            if(txtCidadeId.Text != String.Empty && txtFornecedorId.Text == String.Empty)
            {
                GridFornecedor.DataSource = GetFornecedorCidadeLista(txtNomeCidade.Text);

                if (GridFornecedor.RowCount <= 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum Fornecedor com os filtros informados!", "informação", MessageBoxButtons.OK);
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
                else
                {
                    AjustaColunas();
                    GridFornecedor.Enabled = true;
                    BoxFiltro.Enabled = false;
                    btnPesquisar.BackColor = btnCancelar.BackColor;
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
            }
            else
            {
                GridFornecedor.DataSource = GetFornecedorLista();

                if (GridFornecedor.RowCount <= 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum Fornecedor com os filtros informados!", "informação", MessageBoxButtons.OK);
                }
                else
                {
                    AjustaColunas();
                    GridFornecedor.Enabled = true;
                    BoxFiltro.Enabled = false;
                    btnPesquisar.BackColor = btnCancelar.BackColor;
                    HabilitaAcao(TipoAcao.Cancelar, true);
                }
            }
        }

        private void AjustaColunas()
        {
            GridFornecedor.Columns["idfornecedor"].DisplayIndex = 0;
            GridFornecedor.Columns["nomerazao"].DisplayIndex = 1;
            GridFornecedor.Columns["rgie"].DisplayIndex = 2;
            GridFornecedor.Columns["cpfcnpj"].DisplayIndex = 3;
            GridFornecedor.Columns["endereco"].DisplayIndex = 4;
            GridFornecedor.Columns["numero"].DisplayIndex = 5;
            GridFornecedor.Columns["bairro"].DisplayIndex = 6;
            GridFornecedor.Columns["complemento"].DisplayIndex = 7;
            GridFornecedor.Columns["cep"].DisplayIndex = 8;
            GridFornecedor.Columns["cidadenome"].DisplayIndex = 9;
            GridFornecedor.Columns["estadosigla"].DisplayIndex = 10;
            GridFornecedor.Columns["idcidade"].DisplayIndex = 11;
            GridFornecedor.Columns["telefone"].DisplayIndex = 12;
            GridFornecedor.Columns["celular"].DisplayIndex = 13;
            GridFornecedor.Columns["email"].DisplayIndex = 14;
            GridFornecedor.Columns["ativo"].DisplayIndex = 15;
        }

        public List<FornecedorDTO> GetFornecedorLista()
        {
            Context db = new Context();
            List<FornecedorDTO> Lista = (from fornecedor in db.fornecedor
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

            if (txtFornecedorId.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.idfornecedor == Convert.ToInt32(txtFornecedorId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 0)
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.ativo == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<FornecedorDTO>(Lista.OrderBy(p => p.idfornecedor));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<FornecedorDTO>(Lista.OrderBy(p => p.nomerazao));

            return Lista;
        }

        public List<FornecedorDTO> GetFornecedorCidadeLista(string nome)
        {
            Context db = new Context();
            List<FornecedorDTO> Lista = (from fornecedor in db.fornecedor
                                         join cidade in db.cidade on fornecedor.idcidade equals cidade.idcidade
                                         join estado in db.estado on cidade.idestado equals estado.idestado
                                         orderby fornecedor.idfornecedor
                                         where cidade.nome == nome
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

            if (txtFornecedorId.Text != "")
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.idfornecedor == Convert.ToInt32(txtFornecedorId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 0)
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<FornecedorDTO>(Lista.Where(p => p.ativo == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<FornecedorDTO>(Lista.OrderBy(p => p.idfornecedor));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<FornecedorDTO>(Lista.OrderBy(p => p.nomerazao));

            return Lista;
        }

        private void ClearAllComponentsForm()
        {
            txtFornecedorId.Text = string.Empty;
            txtNomeFornecedor.Text = string.Empty;
            txtCidadeId.Text = string.Empty;
            txtNomeCidade.Text = string.Empty;
            IniciaCampos();
            GridFornecedor.DataSource = null;
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
            txtFornecedorId.Enabled = true;
            txtCidadeId.Enabled = true;
            btnPesquisar.BackColor = btnSair.BackColor;
            if (txtFornecedorId.CanFocus)
            {
                txtFornecedorId.Focus();
            }
        }

        private void txtFornecedorId_Leave(object sender, EventArgs e)
        {
            if(txtFornecedorId.Text != "")
            {
                txtCidadeId.Enabled = false;
            }
            else
            {
                txtCidadeId.Enabled = true;
            }
        }

        private void txtCidadeId_Leave(object sender, EventArgs e)
        {
            if (txtCidadeId.Text != "")
            {
                txtFornecedorId.Enabled = false;
            }
            else
            {
                txtFornecedorId.Enabled = true;
            }
        }
    }
}
