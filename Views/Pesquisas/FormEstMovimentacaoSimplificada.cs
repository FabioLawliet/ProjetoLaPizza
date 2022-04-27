using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormEstMovimentacaoSimplificada : LaPizza.Views.FormBasePesquisa
    {
        public ControleEstoqueModel PMovimentacaoSimplificada;
        public FormEstMovimentacaoSimplificada()
        {
            InitializeComponent();
            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregarListaGrid()
        {
            Context db = new Context();
            ControleEstoqueController Controle = new ControleEstoqueController();
            List<ControleEstoqueModel> Lista = Controle.GetControleEstoqueLista();

            dbGridPesquisa.DataSource = Lista;

            dbGridPesquisa.Columns["id"].DisplayIndex = 0;
            dbGridPesquisa.Columns["id"].Width = 50;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].Width = 250;

            dbGridPesquisa.Columns["datamovimentacao"].DisplayIndex = 2;
            dbGridPesquisa.Columns["datamovimentacao"].Width = 100;

            dbGridPesquisa.Columns["usuariomovimentacao"].DisplayIndex = 3;
            dbGridPesquisa.Columns["usuariomovimentacao"].Width = 100;

            this.Width = 555;
            dbGridPesquisa.Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            ControleEstoqueController Controle = new ControleEstoqueController();
            ControleEstoqueModel ControleEstoque = new ControleEstoqueModel();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PMovimentacaoSimplificada = Controle.GetControleEstoque(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
