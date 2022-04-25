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

        InteracaoMenu Menu;
        FormEstProduto FProduto;
        FormEstMarca FMarca;
        FormEstGrupo FGrupo;
        public FormPrincipal()
        {
            InitializeComponent();
            Menu = new InteracaoMenu();
            Menu.EscondeTodos(pnlMenuLateral.Controls);
  
            //Essa parte abaixo não faz sentido algum.
            //Por algum motivo, a primeira conexão com o banco de dados deixa o projeto lento.
            //Estou fazendo aqui para não ficar lento ao executar alguma ação de uma rotina.
            Context db = new Context();
            MarcaDto marcaDto = db.marca.Where(m => m.id == 0).FirstOrDefault();
        }

        // ------------------------------------------------------------
        // MENU 
        //-------------------------------------------------------------
        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            Menu.MostraOuEsconde(pnlSubMenuCliente);
        }

        private void btnMenuVenda_Click(object sender, EventArgs e)
        {
            Menu.MostraOuEsconde(pnlSubMenuVenda);
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            Menu.MostraOuEsconde(pnlSubMenuEstoque);
        }

        private void btnMenuFornecedor_Click(object sender, EventArgs e)
        {
            Menu.MostraOuEsconde(pnlSubMenuFornecedor);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            Menu.MostraOuEsconde(pnlSubMenuUsuario);
        }

        private void btnMenuGeral_Click(object sender, EventArgs e)
        {
            Menu.MostraOuEsconde(pnlSubMenuGeral);
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
                FProduto.BringToFront();
            }

        }
    }
}
