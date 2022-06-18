using LaPizza.Controllers;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormEstProduto : LaPizza.Views.FormBaseCadastros
    {
        public FormEstProduto()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);
        }

        private void HabilitarComponentesPnlPrincipal(bool Ativa)
        {
            if (Ativa)
            {
                txtProdutoDescricao.Enabled = true;
                cbAtivo.Enabled = true;
                cbAtivo.Checked = true;
                txtGrupoId.Enabled = true;
                txtMarcaId.Enabled = true;
                txtCodigoFabricante.Enabled = true;
                txtInfAdicionais.Enabled = true;
                txtUnidadeMedida.Enabled = true;
                txtQtdeEstMin.Enabled = true;
                txtQtdeEstIdeal.Enabled = true;
                txtQtdeEstMax.Enabled = true;
                txtPrecoAtual.Enabled = true;
            }
            else
            {
                txtProdutoId.Enabled = false;
                txtProdutoDescricao.Enabled = false;
                txtDataCadastro.Enabled = false;
                cbAtivo.Enabled = false;
                cbAtivo.Checked = true;
                txtGrupoId.Enabled = false;
                txtGrupoDescricao.Enabled = false;
                txtSubgrupoId.Enabled = false;
                txtSubgrupoDescricao.Enabled = false;
                txtMarcaId.Enabled = false;
                txtMarcaDescricao.Enabled = false;
                txtCodigoFabricante.Enabled = false;
                txtInfAdicionais.Enabled = false;
                txtSaldoEstoque.Enabled = false;
                txtUnidadeMedida.Enabled = false;
                txtUnidadeMedidaSigla.Enabled = false;
                txtQtdeEstMin.Enabled = false;
                txtQtdeEstIdeal.Enabled = false;
                txtQtdeEstMax.Enabled = false;
                txtPrecoAnterior.Enabled = false;
                txtPrecoAtual.Enabled = false;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);

            ProdutoController PControle = new ProdutoController();
            txtProdutoId.Text = PControle.GetProximoId().ToString();

            txtSaldoEstoque.Text = "0,00";
            txtQtdeEstMin.Text = "0,00";
            txtQtdeEstIdeal.Text = "0,00";
            txtQtdeEstMax.Text = "0,00";
            txtPrecoAnterior.Text = "0,00";
            txtPrecoAtual.Text = "0,00";

            if (txtProdutoDescricao.CanFocus)
            {
                txtProdutoDescricao.Focus();
                txtMarcaDescricao.Select(txtMarcaDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtProdutoId.Text = Pesq.PProduto.idproduto.ToString();
                txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                //txtDataCadastro.Text = Pesq.PProduto.dataCadastro.ToString();
                cbAtivo.Checked = Pesq.PProduto.ativo;
                txtGrupoId.Text = Pesq.PProduto.idgrupo.ToString();
                txtGrupoDescricao.Text = Pesq.PProduto.grupodescricao;
                txtSubgrupoId.Text = Pesq.PProduto.idsubgrupo.ToString();
                txtSubgrupoDescricao.Text = Pesq.PProduto.subgrupodescricao;
                txtMarcaId.Text = Pesq.PProduto.idmarca.ToString();
                txtMarcaDescricao.Text = Pesq.PProduto.marcadescricao;
                txtInfAdicionais.Text = Pesq.PProduto.infadicionais;
                txtCodigoFabricante.Text = Pesq.PProduto.codigofabricante;
                txtSaldoEstoque.Text = Pesq.PProduto.saldoestoque.ToString();
                txtUnidadeMedida.Text = Pesq.PProduto.idunidmedida.ToString();
                txtUnidadeMedidaSigla.Text = Pesq.PProduto.unidmedidasigla.ToString();
                txtQtdeEstMin.Text = Pesq.PProduto.qtdeestmin.ToString();
                txtQtdeEstIdeal.Text = Pesq.PProduto.qtdeestideal.ToString();
                txtQtdeEstMax.Text = Pesq.PProduto.qtdeestmax.ToString();
                txtPrecoAnterior.Text = Pesq.PProduto.precoanterior.ToString();
                txtPrecoAtual.Text = Pesq.PProduto.precoatual.ToString();

                HabilitarComponentesPnlPrincipal(true);
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (txtProdutoDescricao.CanFocus)
            {
                txtProdutoDescricao.Focus();
                txtProdutoDescricao.Select(txtMarcaDescricao.Text.Length, 0);
            }
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {

            FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtProdutoId.Text = Pesq.PProduto.idproduto.ToString();
                txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                //txtDataCadastro.Text = Pesq.PProduto.dataCadastro.ToString();
                cbAtivo.Checked = Pesq.PProduto.ativo;
                txtGrupoId.Text = Pesq.PProduto.idgrupo.ToString();
                txtGrupoDescricao.Text = Pesq.PProduto.grupodescricao;
                txtSubgrupoId.Text = Pesq.PProduto.idsubgrupo.ToString();
                txtSubgrupoDescricao.Text = Pesq.PProduto.subgrupodescricao;
                txtMarcaId.Text = Pesq.PProduto.idmarca.ToString();
                txtMarcaDescricao.Text = Pesq.PProduto.marcadescricao;
                txtInfAdicionais.Text = Pesq.PProduto.infadicionais;
                txtCodigoFabricante.Text = Pesq.PProduto.codigofabricante;
                txtSaldoEstoque.Text = Pesq.PProduto.saldoestoque.ToString();
                txtUnidadeMedida.Text = Pesq.PProduto.idunidmedida.ToString();
                txtUnidadeMedidaSigla.Text = Pesq.PProduto.unidmedidasigla.ToString();
                txtQtdeEstMin.Text = Pesq.PProduto.qtdeestmin.ToString();
                txtQtdeEstIdeal.Text = Pesq.PProduto.qtdeestideal.ToString();
                txtQtdeEstMax.Text = Pesq.PProduto.qtdeestmax.ToString();
                txtPrecoAnterior.Text = Pesq.PProduto.precoanterior.ToString();
                txtPrecoAtual.Text = Pesq.PProduto.precoatual.ToString();

                HabilitarComponentesPnlPrincipal(false);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnCancelar.CanFocus)
                btnCancelar.Focus();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
            var Result = Pesq.ShowDialog();

            if (Result == DialogResult.OK)
            {
                txtProdutoId.Text = Pesq.PProduto.idproduto.ToString();
                txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                //txtDataCadastro.Text = Pesq.PProduto.dataCadastro.ToString();
                cbAtivo.Checked = Pesq.PProduto.ativo;
                txtGrupoId.Text = Pesq.PProduto.idgrupo.ToString();
                txtGrupoDescricao.Text = Pesq.PProduto.grupodescricao;
                txtSubgrupoId.Text = Pesq.PProduto.idsubgrupo.ToString();
                txtSubgrupoDescricao.Text = Pesq.PProduto.subgrupodescricao;
                txtMarcaId.Text = Pesq.PProduto.idmarca.ToString();
                txtMarcaDescricao.Text = Pesq.PProduto.marcadescricao;
                txtInfAdicionais.Text = Pesq.PProduto.infadicionais;
                txtCodigoFabricante.Text = Pesq.PProduto.codigofabricante;
                txtSaldoEstoque.Text = Pesq.PProduto.saldoestoque.ToString();
                txtUnidadeMedida.Text = Pesq.PProduto.idunidmedida.ToString();
                txtUnidadeMedidaSigla.Text = Pesq.PProduto.unidmedidasigla.ToString();
                txtQtdeEstMin.Text = Pesq.PProduto.qtdeestmin.ToString();
                txtQtdeEstIdeal.Text = Pesq.PProduto.qtdeestideal.ToString();
                txtQtdeEstMax.Text = Pesq.PProduto.qtdeestmax.ToString();
                txtPrecoAnterior.Text = Pesq.PProduto.precoanterior.ToString();
                txtPrecoAtual.Text = Pesq.PProduto.precoatual.ToString();

                HabilitarComponentesPnlPrincipal(false);
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
            {
                cancelaOperacao();
                return;
            }

            if (btnConfirmar.CanFocus)
                btnConfirmar.Focus();
        }

        private void LimpaComponentes()
        {
            txtProdutoId.Text = string.Empty;
            txtProdutoDescricao.Text = string.Empty;
            txtDataCadastro.Text = string.Empty;
            cbAtivo.Checked = true;
            txtGrupoId.Text = string.Empty;
            txtGrupoDescricao.Text = string.Empty;
            txtSubgrupoId.Text = string.Empty;
            txtSubgrupoDescricao.Text = string.Empty;
            txtMarcaId.Text = string.Empty;
            txtMarcaDescricao.Text = string.Empty;
            txtCodigoFabricante.Text = string.Empty;
            txtInfAdicionais.Text = string.Empty;
            txtSaldoEstoque.Text = string.Empty;
            txtUnidadeMedida.Text = string.Empty;
            txtUnidadeMedidaSigla.Text = string.Empty;
            txtQtdeEstMin.Text = string.Empty;
            txtQtdeEstIdeal.Text = string.Empty;
            txtQtdeEstMax.Text = string.Empty;
            txtPrecoAnterior.Text = string.Empty;
            txtPrecoAtual.Text = string.Empty;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (TodosOsCamposPreenchidos())
            {
                ProdutoController Pcontrole = new ProdutoController();
                ProdutoDB Produto = new ProdutoDB();

                Produto.idproduto = Int32.Parse(txtProdutoId.Text);
                Produto.descricao = txtProdutoDescricao.Text;
                Produto.datacadastro = DateTime.Today.ToString();
                Produto.ativo = cbAtivo.Checked;
                Produto.idgrupo = Int32.Parse(txtGrupoId.Text);
                Produto.idsubgrupo = Int32.Parse(txtSubgrupoId.Text);
                Produto.idmarca = Int32.Parse(txtMarcaId.Text);
                Produto.idunidmedida = Int32.Parse(txtUnidadeMedida.Text);
                Produto.codigofabricante = txtCodigoFabricante.Text;
                Produto.infadicionais = txtInfAdicionais.Text;
                Produto.saldoestoque = Convert.ToDecimal(txtSaldoEstoque.Text);


                if (txtQtdeEstMin.Text == String.Empty)
                    Produto.qtdeestmin = 0;
                else
                    Produto.qtdeestmin = Convert.ToDecimal(txtQtdeEstMin.Text);

                if (txtQtdeEstIdeal.Text == String.Empty)
                    Produto.qtdeestideal = 0;
                else
                    Produto.qtdeestideal = Convert.ToDecimal(txtQtdeEstIdeal.Text);

                if (txtQtdeEstMax.Text == String.Empty)
                    Produto.qtdeestmax = 0;
                else
                    Produto.qtdeestmax = Convert.ToDecimal(txtQtdeEstMax.Text);

                Produto.precoatual = Convert.ToDecimal(txtPrecoAtual.Text);
                Produto.precoanterior = Produto.precoatual;

                if (MenuStatus == MStatus.Adicionando)
                    Pcontrole.Adicionar(Produto);
                else if (MenuStatus == MStatus.Editando)
                    Pcontrole.Editar(Produto);
                else if (MenuStatus == MStatus.Excluindo)
                    Pcontrole.Excluir(Produto.idproduto);

                LimpaComponentes();
                HabilitarComponentesPnlPrincipal(false);
                HabilitarAcoesIniciais();
            }
        }

        private bool TodosOsCamposPreenchidos()
        {
            bool todosPreenchidos = true;
            int idGrupo=0, idSubgrupo=0, idMarca=0;
            string auxMensagem = string.Empty;

            GrupoController grupoControle = new GrupoController();
            SubgrupoController subgrupoControle = new SubgrupoController();
            MarcaController marcaControle = new MarcaController();

            if (txtGrupoId.Text != string.Empty)
                idGrupo = int.Parse(txtGrupoId.Text);

            if (txtSubgrupoId.Text != string.Empty)
                idSubgrupo = int.Parse(txtSubgrupoId.Text);

            if (txtMarcaId.Text != string.Empty)
                idMarca = int.Parse(txtMarcaId.Text);

            if (txtProdutoDescricao.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMensagem += "* O campo descrição não foi preenchido corretamente! \n";
            }
                
            if (!grupoControle.ExisteGrupoId(idGrupo))
            {
                todosPreenchidos = false;
                auxMensagem += "* O campo grupo não foi preenchido corretamente! \n";   
            }

            if (!subgrupoControle.ExisteSubgrupo(idGrupo, idSubgrupo))
            {
                todosPreenchidos = false;
                auxMensagem += "* O campo subgrupo não foi preenchido corretamente! \n";
            }
                
            if (!marcaControle.ExisteMarca(idMarca))
            {
                todosPreenchidos = false;
                auxMensagem += "* O campo marca não foi preenchido corretamente! \n";
            }
                
            if (txtUnidadeMedida.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMensagem += "* O campo un. medida não foi preenchido corretamente! \n";
            }


            if (txtPrecoAtual.Text == string.Empty)
            {
                todosPreenchidos = false;
                auxMensagem += "* O campo preco atual não foi preenchido corretamente! \n";
            }

            if (auxMensagem != string.Empty)
                MessageBox.Show(auxMensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return todosPreenchidos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelaOperacao()
        {
            LimpaComponentes();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }

        private void txtProdutoDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtProdutoDescricao.Text != String.Empty && txtProdutoDescricao.Enabled == true)
                HabilitaAcao(TipoAcao.Confirmar, true);
            else
                HabilitaAcao(TipoAcao.Confirmar, false);
        }

        private void txtMarcaId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstMarcaPesquisa Pesq = new FormEstMarcaPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtMarcaId.Text = Pesq.PesqMarca.idmarca.ToString();
                    txtMarcaDescricao.Text = Pesq.PesqMarca.descricao;
                }
            }
        }

        private void txtMarcaId_TextChanged(object sender, EventArgs e)
        {
            if (txtMarcaId.Text != "")
            {
                MarcaController Controle = new MarcaController();
                MarcaDTO Marca = new MarcaDTO();

                var id = Int32.Parse(txtMarcaId.Text);

                if (Controle.ExisteMarca(id))
                {
                    Marca = Controle.GetMarca(id);
                    txtMarcaDescricao.Text = Marca.descricao;
                }
                else
                    txtMarcaDescricao.Text = String.Empty;
            }
            else
                txtMarcaDescricao.Text = String.Empty;

        }

        private void txtGrupoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstGrupoPesquisa Pesq = new FormEstGrupoPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtGrupoId.Text = Pesq.PesqGrupo.idgrupo.ToString();
                    txtGrupoDescricao.Text = Pesq.PesqGrupo.descricao;
                }
            }
        }

        private void txtGrupoId_TextChanged(object sender, EventArgs e)
        {
            if (txtGrupoId.Text != "")
            {
                GrupoController Controle = new GrupoController();

                var id = Int32.Parse(txtGrupoId.Text);

                if (Controle.ExisteGrupoId(id))
                    txtGrupoDescricao.Text = Controle.GetGrupo(id).descricao;
                else
                {
                    txtGrupoDescricao.Text = String.Empty;
                    txtSubgrupoId.Text = String.Empty;
                    txtSubgrupoDescricao.Text = String.Empty;
                }
            }
            else
            {
                txtGrupoDescricao.Text = String.Empty;
                txtSubgrupoId.Text = String.Empty;
                txtSubgrupoDescricao.Text = String.Empty;
            }

        }

        private void txtSubgrupoId_TextChanged(object sender, EventArgs e)
        {
            if (txtSubgrupoId.Text != "")
            {
                SubgrupoController controle = new SubgrupoController();

                var idGrupo = Int32.Parse(txtGrupoId.Text);
                var idSubgrupo = Int32.Parse(txtSubgrupoId.Text);

                if (controle.ExisteSubgrupo(idGrupo, idSubgrupo))
                {
                    txtSubgrupoDescricao.Text = controle.GetSubgrupo(idGrupo, idSubgrupo).descricao;
                }
                else
                    txtSubgrupoDescricao.Text = String.Empty;
            }
            else
                txtSubgrupoDescricao.Text = String.Empty;
        }

        private void txtSubgrupoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                var idGrupo = Int32.Parse(txtGrupoId.Text);

                FormEstSubgrupoPesquisa Pesq = new FormEstSubgrupoPesquisa(idGrupo);
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtSubgrupoId.Text = Pesq.PesqSubgrupo.idsubgrupo.ToString();
                    txtSubgrupoDescricao.Text = Pesq.PesqSubgrupo.descricao;
                }
            }
        }

        private void txtGrupoDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtGrupoDescricao.Text != String.Empty)
                txtSubgrupoId.Enabled = true;
            else
                txtSubgrupoId.Enabled = false;
        }

        private void txtUnidadeMedida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstUnidadeMedidaPesquisa Pesq = new FormEstUnidadeMedidaPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtUnidadeMedida.Text = Pesq.PesqUnidadeMedida.idunidmedida.ToString();
                    txtUnidadeMedidaSigla.Text = Pesq.PesqUnidadeMedida.sigla;
                }
            }
        }
    }
}
