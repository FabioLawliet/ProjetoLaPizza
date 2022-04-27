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
        FormEstControleEstoque FControleEstoque;
        public FormPrincipal()
        {
            InitializeComponent();
            IntMenu = new InteracaoMenu();
            IntMenu.EscondeTodos(pnlMenuLateral.Controls);
  
            //Essa parte abaixo não faz sentido algum.
            //Por algum motivo, a primeira conexão com o banco de dados deixa o projeto lento.
            //Estou fazendo aqui para não ficar lento ao executar alguma ação de uma rotina.
            Context db = new Context();
            //MarcaController controle = new MarcaController();
            //controle.ExisteMarca(1);
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
        // ------------------------------------------------------------
        // SUB MENU
        //-------------------------------------------------------------
        private void btnEstMarca_Click(object sender, EventArgs e)
        {
            
            if (FMarca == null || FMarca.IsDisposed)
            {
                FMarca = new FormEstMarca();
                FMarca.Text = btnEstMarca.Text;
                FMarca.lbNomeRotina.Text = btnEstMarca.Text;
                FMarca.TopLevel = false;
                FMarca.Visible = false;
                pnlPrincipal.Controls.Add(FMarca);
                FMarca.Left = (pnlPrincipal.Width - FMarca.Width) / 2;
                FMarca.Top = (pnlPrincipal.Height - FMarca.Height) / 2;
                FMarca.Visible = true;
                FMarca.BringToFront();
            }
            else
            {
                FMarca.BringToFront();
            }
            
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            //FMarca.Left = (pnlPrincipal.Width - FMarca.Width) / 2;
            //FMarca.Top = (pnlPrincipal.Height - FMarca.Height) / 2;
        }

        private void btnEstProduto_Click(object sender, EventArgs e)
        {

            if (FProduto == null || FProduto.IsDisposed)
            {
                FProduto = new FormEstProduto();
                FProduto.Text = btnEstProduto.Text;
                FProduto.lbNomeRotina.Text = btnEstProduto.Text;
                FProduto.Visible = false;
                FProduto.TopLevel = false;
                pnlPrincipal.Controls.Add(FProduto);
                FProduto.Left = (pnlPrincipal.Width - FProduto.Width) / 2;
                FProduto.Top = (pnlPrincipal.Height - FProduto.Height) / 2;
                FProduto.FormBorderStyle = FormBorderStyle.Sizable;
                FProduto.Visible = true;
                FProduto.BringToFront();
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
                FGrupo.Text = btnEstGrupo.Text;
                FGrupo.lbNomeRotina.Text = btnEstGrupo.Text;
                FGrupo.Visible = false;
                FGrupo.TopLevel = false;
                pnlPrincipal.Controls.Add(FGrupo);
                FGrupo.Left = (pnlPrincipal.Width - FGrupo.Width) / 2;
                FGrupo.Top = (pnlPrincipal.Height - FGrupo.Height) / 2;
                FGrupo.FormBorderStyle = FormBorderStyle.Sizable;
                FGrupo.Visible = true;
                FGrupo.BringToFront();
            }
            else
            {
                FGrupo.BringToFront();
            }

        }

        private void btnEstControle_Click(object sender, EventArgs e)
        {
            if (FControleEstoque == null || FControleEstoque.IsDisposed)
            {
                FControleEstoque = new FormEstControleEstoque();
                FControleEstoque.Text = btnEstControle.Text;
                FControleEstoque.lbNomeRotina.Text = btnEstControle.Text;
                FControleEstoque.Visible = false;
                FControleEstoque.TopLevel = false;
                pnlPrincipal.Controls.Add(FControleEstoque);
                FControleEstoque.Left = (pnlPrincipal.Width - FControleEstoque.Width) / 2;
                FControleEstoque.Top = (pnlPrincipal.Height - FControleEstoque.Height) / 2;
                FControleEstoque.FormBorderStyle = FormBorderStyle.Sizable;
                FControleEstoque.Visible = true;
                FControleEstoque.BringToFront();
            }
            else
            {
                FControleEstoque.BringToFront();
            }

        }
    }
}
