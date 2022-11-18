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
    public partial class RelProdutos : LaPizza.Views.FormBaseCadastros
    {
        public RelProdutos()
        {
            InitializeComponent();
            LimpaCampos();
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        private void habilitaBotoes()
        {
            bool Editado = false;

            if (txtProdutoId.Text != "")
                Editado = true;

            if (txtGrupoId.Text != "")
                Editado = true;

            if (txtMarcaId.Text != "")
                Editado = true;

            HabilitaAcao(TipoAcao.Cancelar, Editado);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Context db = new Context();

            DataTable dt = CollectionHelper.ConvertTo<ProdutoDTO>(GetProdutoLista());

            using (var frm = new RelProdutosRV(dt))
            {
                frm.ShowDialog();
            }

            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        public void LimpaCampos()
        {
            txtProdutoId.Text = "";
            txtProdutoDescricao.Text = "";
            txtGrupoId.Text = "";
            txtGrupoDescricao.Text = "";
            txtSubgrupoId.Text = "";
            txtSubgrupoDescricao.Text = "";
            txtMarcaId.Text = "";
            txtMarcaDescricao.Text = "";
            cbPesquisarAtivos.SelectedIndex = 0;
            cbTipoOrdenacao.SelectedIndex = 0;
            HabilitaAcao(TipoAcao.Confirmar, true);
        }
        public List<ProdutoDTO> GetProdutoLista()
        {
            Context db = new Context();
            List<ProdutoDTO> Lista = (from produto in db.produto
                                      join marca in db.marca on produto.idmarca equals marca.idmarca
                                      join grupo in db.grupo on produto.idgrupo equals grupo.idgrupo
                                      join unidade in db.unidademedida on produto.idunidmedida equals unidade.idunidmedida
                                      join subgrupo in db.subgrupo on new { produto.idsubgrupo, produto.idgrupo }
                                                               equals new { subgrupo.idsubgrupo, subgrupo.idgrupo }

                                      orderby produto.idproduto
                                      select new ProdutoDTO
                                      {
                                          idproduto = produto.idproduto,
                                          descricao = produto.descricao,
                                          idunidmedida = produto.idunidmedida,
                                          unidmedidasigla = unidade.sigla,
                                          saldoestoque = produto.saldoestoque,
                                          precoatual = produto.precoatual,
                                          precoanterior = produto.precoanterior,
                                          infadicionais = produto.infadicionais,
                                          idmarca = produto.idmarca,
                                          marcadescricao = marca.descricao,
                                          idgrupo = produto.idgrupo,
                                          grupodescricao = grupo.descricao,
                                          idsubgrupo = produto.idsubgrupo,
                                          subgrupodescricao = subgrupo.descricao,
                                          codigofabricante = produto.codigofabricante,
                                          qtdeestmin = produto.qtdeestmin,
                                          qtdeestideal = produto.qtdeestideal,
                                          qtdeestmax = produto.qtdeestmax,
                                          datacadastro = produto.datacadastro,
                                          ativo = produto.ativo
                                      }).ToList();
            if (txtProdutoId.Text != "")
            {
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idproduto == Convert.ToInt32(txtProdutoId.Text)));
                return Lista;
            }

            if (txtMarcaId.Text != "")
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idmarca == Convert.ToInt32(txtMarcaId.Text)));

            if (txtGrupoId.Text != "")
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idgrupo == Convert.ToInt32(txtGrupoId.Text)));

            if (txtSubgrupoId.Text != "")
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idsubgrupo == Convert.ToInt32(txtSubgrupoId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 1)
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 2)
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.ativo == false));

//            if (cbSaldoEstoque.SelectedIndex == 0)
//                Lista = new List<ProdutoDTO>(Lista.Where(p => p.saldoestoque > 0));
//            else if (cbSaldoEstoque.SelectedIndex == 1)
//                Lista = new List<ProdutoDTO>(Lista.Where(p => p.saldoestoque <= 0));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                Lista = new List<ProdutoDTO>(Lista.OrderBy(p => p.idproduto));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                Lista = new List<ProdutoDTO>(Lista.OrderBy(p => p.descricao));

            return Lista;
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

        private void txtProdutoId_TextChanged(object sender, EventArgs e)
        {
            if (txtProdutoId.Text != "")
            {
                ProdutoController Controle = new ProdutoController();
                ProdutoDTO Produto = new ProdutoDTO();

                var id = Int32.Parse(txtProdutoId.Text);

                if (Controle.ExisteProduto(id))
                {
                    Produto = Controle.GetProduto(id);
                    txtProdutoId.Text = Produto.idproduto.ToString();
                    txtProdutoDescricao.Text = Produto.descricao;
                }
                else
                    txtProdutoDescricao.Text = String.Empty;
            }
            else
                txtProdutoDescricao.Text = String.Empty;

            if (txtProdutoId.Text != "")
            {
                txtMarcaId.Enabled = false;
                txtMarcaId.Text = "";
                txtGrupoId.Enabled = false;
                txtGrupoId.Text = "";
                txtSubgrupoId.Enabled = false;
                txtSubgrupoId.Text = "";
                cbPesquisarAtivos.Enabled = false;
                cbTipoOrdenacao.Enabled = false;
            }
            else
            {
                txtMarcaId.Enabled = true;
                txtGrupoId.Enabled = true;
                cbPesquisarAtivos.Enabled = true;
                cbTipoOrdenacao.Enabled = true;
            }
        }

        private void txtProdutoId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F2)
            {
                FormEstProdutoPesquisa Pesq = new FormEstProdutoPesquisa();
                var Result = Pesq.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    txtProdutoId.Text = Pesq.PProduto.idproduto.ToString();
                    txtProdutoDescricao.Text = Pesq.PProduto.descricao;
                }
            }
        }

        private void txtGrupoDescricao_TextChanged_1(object sender, EventArgs e)
        {
            if (txtGrupoDescricao.Text != String.Empty)
                txtSubgrupoId.Enabled = true;
            else
                txtSubgrupoId.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LeaveGenerico(object sender, EventArgs e)
        {
            habilitaBotoes();
        }
    }
}
