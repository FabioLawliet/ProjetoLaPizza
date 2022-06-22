using System;
using System.Windows.Forms;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Controllers;
using LaPizza.Views;
using System.Linq;

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
        public FormPrincipal()
        {
            InitializeComponent();
            IntMenu = new InteracaoMenu();
            IntMenu.EscondeTodos(pnlMenuLateral.Controls);

            try //A primeira conexão com o banco é lenta, então está sendo realizada uma conexão por aqui e o usuário nem sabe que ela acontece.
            {
                Context db = new Context();
                var marca = db.marca.FirstOrDefault();
            }catch(Exception ex)
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
                CentralizaTela(FUnidMedida, btnEstUnidadeMedida.Text);
                FFornecedor = new FormRecFornecedor();
                FFornecedor.Text = btnFornCadastro.Text;
                FFornecedor.lbNomeRotina.Text = btnFornCadastro.Text;
                FFornecedor.Visible = false;
                FFornecedor.TopLevel = false;
                pnlPrincipal.Controls.Add(FFornecedor);
                FFornecedor.Left = (pnlPrincipal.Width - FFornecedor.Width) / 2;
                FFornecedor.Top = (pnlPrincipal.Height - FFornecedor.Height) / 2;
                FFornecedor.FormBorderStyle = FormBorderStyle.Sizable;
                FFornecedor.Visible = true;
                FFornecedor.BringToFront();
            }
            else
            {
                FUnidMedida.BringToFront();
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

    }
}
