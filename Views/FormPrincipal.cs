using System;
using System.Windows.Forms;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Controllers;
using LaPizza.Views;
using System.Linq;
using LaPizza.Views.PesquisasAnaliticas;
using LaPizza.Views.Relatorios;

namespace LaPizza
{
    public partial class FormPrincipal : Form
    {

        InteracaoMenu IntMenu;
        FormEstProduto FProduto;
        FormEstMarca FMarca;
        FormEstGrupo FGrupo;
        FormEstUnidadeMedida FUnidMedida;
        FormEstMovimentacaoSimplificada FMovimentacaoSimp;
        FormEstSubgrupo FSubgrupo;
        FormRecCliente FCliente;
        FormUsrUsuario FUsuario;
        FormVenPedidoVenda FPedidoVenda;
        FormEntMercadoria FEntMercadoria;
        FormRecFornecedor FFornecedor;
        FormEstado FEstado;
        FormCidade FCidade;
        FormVenFormaPagamento FFormaPagamento;
        PesqAnaliticaProdutos FPesqAnaProdutos;
        PesqAnaliticaPedidos FPesqAnaPedidos;
        PesqAnaliticaClientes FPesqAnaCliente;
        PesqAnaliticaFornecedores FPesqAnaFornecedores;
        RelMarcas FRelMarcas;
        RelProdutos FRelProdutos;
        RelClientes RelClientes;

        public FormPrincipal()
        {
            InitializeComponent();
            IntMenu = new InteracaoMenu();
            IntMenu.EscondeTodos(pnlMenuLateral.Controls);

            try //A primeira conexão com o banco é lenta, então está sendo realizada uma conexão por aqui e o usuário nem sabe que ela acontece.
            {
                Context db = new Context();
                var marca = db.marca.FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao se conectar com o banco de dados! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // ------------------------------------------------------------
        // MENU 
        //-------------------------------------------------------------
        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            IntMenu.MostraOuEsconde(pnlSubMenuCliente);
        }

        private void btnMenuVenda_Click(object sender, EventArgs e)
        {
            IntMenu.MostraOuEsconde(pnlSubMenuVenda);
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            IntMenu.MostraOuEsconde(pnlSubMenuEstoque);
        }

        private void btnMenuFornecedor_Click(object sender, EventArgs e)
        {
            IntMenu.MostraOuEsconde(pnlSubMenuFornecedor);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            IntMenu.MostraOuEsconde(pnlSubMenuUsuario);
        }

        private void btnMenuGeral_Click(object sender, EventArgs e)
        {
            IntMenu.MostraOuEsconde(pnlSubMenuGeral);
        }

        private void CentralizaTela(Form Formulario, string TextRotina)
        {
            Formulario.Text = TextRotina;
            Formulario.Visible = false;
            Formulario.TopLevel = false;
            pnlPrincipal.Controls.Add(Formulario);
            Formulario.Left = (pnlPrincipal.Width - Formulario.Width) / 2;
            Formulario.Top = (pnlPrincipal.Height - Formulario.Height) / 2;
            Formulario.FormBorderStyle = FormBorderStyle.Sizable;
            Formulario.Visible = true;
            Formulario.BringToFront();

        }
        // ------------------------------------------------------------
        // SUB MENU
        //-------------------------------------------------------------
        private void btnEstMarca_Click(object sender, EventArgs e)
        {
            if (FMarca == null || FMarca.IsDisposed)
            {
                FMarca = new FormEstMarca();
                CentralizaTela(FMarca, btnEstMarca.Text);
            }
            else
            {
                FMarca.BringToFront();
            }
        }
        private void btnEstProduto_Click(object sender, EventArgs e)
        {
            if (FProduto == null || FProduto.IsDisposed)
            {
                FProduto = new FormEstProduto();
                CentralizaTela(FProduto, btnEstProduto.Text);
            }
            else
            {
                FProduto.BringToFront();
            }
        }

        private void btnEstGrupo_Click(object sender, EventArgs e)
        {
            if (FGrupo == null || FGrupo.IsDisposed)
            {
                FGrupo = new FormEstGrupo();
                CentralizaTela(FGrupo, btnEstGrupo.Text);
            }
            else
            {
                FGrupo.BringToFront();
            }
        }

        private void btnEstControle_Click(object sender, EventArgs e)
        {
            if (FMovimentacaoSimp == null || FMovimentacaoSimp.IsDisposed)
            {
                FMovimentacaoSimp = new FormEstMovimentacaoSimplificada();
                CentralizaTela(FMovimentacaoSimp, btnEstMovimentacaoSimplificada.Text);
            }
            else
            {
                FMovimentacaoSimp.BringToFront();
            }
        }

        private void btnEstSubGrupo_Click(object sender, EventArgs e)
        {
            if (FSubgrupo == null || FSubgrupo.IsDisposed)
            {
                FSubgrupo = new FormEstSubgrupo();
                CentralizaTela(FSubgrupo, btnEstSubGrupo.Text);
            }
            else
            {
                FSubgrupo.BringToFront();
            }
        }

        private void btnUsuCadastro_Click(object sender, EventArgs e)
        {
            if (FUsuario == null || FUsuario.IsDisposed)
            {
                FUsuario = new FormUsrUsuario();
                CentralizaTela(FUsuario, btnUsuCadastro.Text);
            }
            else
            {
                FUsuario.BringToFront();
            }
        }


        private void btnCliCadastro_Click(object sender, EventArgs e)
        {
            if (FCliente == null || FCliente.IsDisposed)
            {
                FCliente = new FormRecCliente();
                CentralizaTela(FCliente, btnCliCadastro.Text);
            }
            else
            {
                FCliente.BringToFront();
            }
        }

        private void btnEstUnidadeMedida_Click(object sender, EventArgs e)
        {
            if (FUnidMedida == null || FUnidMedida.IsDisposed)
            {
                FUnidMedida = new FormEstUnidadeMedida();
                CentralizaTela(FUnidMedida, btnEstUnidadeMedida.Text);
            }
            else
            {
                FCliente.BringToFront();
            }

        }
        private void btnFornCadastro_Click(object sender, EventArgs e)
        {
            if (FFornecedor == null || FFornecedor.IsDisposed)
            {
                FFornecedor = new FormRecFornecedor();
                CentralizaTela(FFornecedor, btnFornCadastro.Text);
            }
            else
            {
                FCliente.BringToFront();
                FFornecedor.BringToFront();
            }
        }

        private void btnVenPedido_Click(object sender, EventArgs e)
        {
            if (FPedidoVenda == null || FPedidoVenda.IsDisposed)
            {
                FPedidoVenda = new FormVenPedidoVenda();
                CentralizaTela(FPedidoVenda, btnVenPedido.Text);
            }
            else
            {
                FPedidoVenda.BringToFront();
            }
        }

        private void btnEstEntradaMerc_Click(object sender, EventArgs e)
        {
            if (FEntMercadoria == null || FEntMercadoria.IsDisposed)
            {
                FEntMercadoria = new FormEntMercadoria();
                CentralizaTela(FEntMercadoria, btnEstEntradaMerc.Text);
            }
            else
            {
                FEntMercadoria.BringToFront();
            }
        }

        private void btnGerEstado_Click(object sender, EventArgs e)
        {
            if (FEstado == null || FEstado.IsDisposed)
            {
                FEstado = new FormEstado();
                CentralizaTela(FEstado, btnGerEstado.Text);
            }
            else
            {
                FEstado.BringToFront();
            }
        }

        private void btnGerCidade_Click(object sender, EventArgs e)
        {
            if (FCidade == null || FCidade.IsDisposed)
            {
                FCidade = new FormCidade();
                CentralizaTela(FCidade, btnGerCidade.Text);
            }
        }
        private void btnVenFormaPagamento_Click(object sender, EventArgs e)
        {
            if (FFormaPagamento == null || FFormaPagamento.IsDisposed)
            {
                FFormaPagamento = new FormVenFormaPagamento();
                CentralizaTela(FFormaPagamento, btnVenFormaPagamento.Text);
            }
            else
            {
                FFormaPagamento.BringToFront();
            }
        }

        private void btnPesqProdutos_Click(object sender, EventArgs e)
        {
            if (FPesqAnaProdutos == null || FPesqAnaProdutos.IsDisposed)
            {
                FPesqAnaProdutos = new PesqAnaliticaProdutos();
                CentralizaTela(FPesqAnaProdutos, btnPesqProdutos.Text);
            }
            else
            {
                FPesqAnaProdutos.BringToFront();
            }
        }

        private void btnPesqPedidos_Click(object sender, EventArgs e)
        {
            if (FPesqAnaPedidos == null || FPesqAnaPedidos.IsDisposed)
            {
                FPesqAnaPedidos = new PesqAnaliticaPedidos();
                CentralizaTela(FPesqAnaPedidos, btnPesqPedidos.Text);
            }
            else
            {
                FPesqAnaPedidos.BringToFront();
            }
        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {
            if (FPesqAnaCliente == null || FPesqAnaCliente.IsDisposed)
            {
                FPesqAnaCliente = new PesqAnaliticaClientes();
                CentralizaTela(FPesqAnaCliente, btnPesqCliente.Text);
            }
            else
            {
                FPesqAnaCliente.BringToFront();
            }
        }

        private void btnPesqFornecedor_Click(object sender, EventArgs e)
        {
            if (FPesqAnaFornecedores == null || FPesqAnaFornecedores.IsDisposed)
            {
                FPesqAnaFornecedores = new PesqAnaliticaFornecedores();
                CentralizaTela(FPesqAnaFornecedores, btnPesqFornecedor.Text);
            }
            else
            {
                FPesqAnaFornecedores.BringToFront();
            }
        }

        private void btnRelProdutos_Click(object sender, EventArgs e)
        {
            if (FRelProdutos == null || FRelProdutos.IsDisposed)
            {
                FRelProdutos = new RelProdutos();
                CentralizaTela(FRelProdutos, btnRelProdutos.Text);
            }
            else
            {
                FRelProdutos.BringToFront();
            }
        }

        private void btnRelMarcas_Click(object sender, EventArgs e)
        {
            if (FRelMarcas == null || FRelMarcas.IsDisposed)
            {
                FRelMarcas = new RelMarcas();
                CentralizaTela(FRelMarcas, btnRelMarcas.Text);
            }
            else
            {
                FRelMarcas.BringToFront();
            }
        }

        private void btnRelClientes_Click(object sender, EventArgs e)
        {
            if (RelClientes == null || RelClientes.IsDisposed)
            {
                RelClientes = new RelClientes();
                CentralizaTela(RelClientes, RelClientes.Text);
            }
            else
            {
                FRelProdutos.BringToFront();
            }
        }
    }
}
