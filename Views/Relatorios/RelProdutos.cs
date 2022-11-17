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
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            ProdutoController ctr = new ProdutoController();

            DataTable dt = CollectionHelper.ConvertTo<ProdutoDTO>(ctr.GetProdutoLista());

            using (var frm = new RelProdutosRV(dt))
            {
                frm.ShowDialog();
            }
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

            if (txtMarcaId.Text != "")
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idmarca == Convert.ToInt32(txtMarcaId.Text)));

            if (txtGrupoId.Text != "")
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idgrupo == Convert.ToInt32(txtGrupoId.Text)));

            if (txtSubgrupoId.Text != "")
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.idsubgrupo == Convert.ToInt32(txtSubgrupoId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 0)
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.ativo == true));
            else if (cbPesquisarAtivos.SelectedIndex == 1)
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
    }
}
