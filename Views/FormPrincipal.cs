using System;
using System.Windows.Forms;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Controllers;
using LaPizza.Views;
using System.Drawing;

namespace LaPizza
{
    public partial class FormPrincipal : Form
    {

        InteracaoMenu Menu = null;
        FormEstMarca FMarca = null;
        public FormPrincipal()
        {
            InitializeComponent();
            Menu = new InteracaoMenu();
            Menu.EscondeTodos(pnlMenuLateral.Controls);
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
                FMarca.Visible = true;
                //FMarca.Dock = DockStyle.Fill;
                pnlPrincipal.Controls.Add(FMarca);
            }
            else
            {
                FMarca.BringToFront();
            }
            
        }
    }
}
