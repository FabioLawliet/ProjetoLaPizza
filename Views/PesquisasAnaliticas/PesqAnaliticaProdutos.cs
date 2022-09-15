using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Views.PesquisasAnaliticas
{
    public partial class PesqAnaliticaProdutos : LaPizza.Views.FormBaseCadastros
    {
        public PesqAnaliticaProdutos()
        {
            InitializeComponent();
        }

        private void IniciaCampos()
        {
            cbTipoOrdenacao.SelectedIndex = 0;
            cbPesquisarAtivos.SelectedIndex = 0;
            cbSaldoEstoque.SelectedIndex = 0;
            cbMovimentacoes.SelectedIndex = 0;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GridProdutos.DataSource = GetProdutoLista();
            GridProdutos.Enabled = true;
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
                                          //dataCadastro = produto.datacadastro.ToString(),
                                          ativo = produto.ativo,
                                          idgrupo = produto.idgrupo,
                                          grupodescricao = grupo.descricao,
                                          idsubgrupo = produto.idsubgrupo,
                                          subgrupodescricao = subgrupo.descricao,
                                          idmarca = produto.idmarca,
                                          marcadescricao = marca.descricao,
                                          codigofabricante = produto.codigofabricante,
                                          infadicionais = produto.infadicionais,
                                          saldoestoque = produto.saldoestoque,
                                          idunidmedida = produto.idunidmedida,
                                          unidmedidasigla = unidade.sigla,
                                          qtdeestmin = produto.qtdeestmin,
                                          qtdeestideal = produto.qtdeestideal,
                                          qtdeestmax = produto.qtdeestmax,
                                          precoanterior = produto.precoanterior,
                                          precoatual = produto.precoatual
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

            if (cbSaldoEstoque.SelectedIndex == 0)
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.saldoestoque > 0));
            else if (cbSaldoEstoque.SelectedIndex == 1)
                Lista = new List<ProdutoDTO>(Lista.Where(p => p.saldoestoque <= 0));

            return Lista;
        }
    }
}
