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
    public partial class FormEstMovimentacaoSimplificadaPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public MovimentoEstoqueDTO PMovimentacaoSimplificada;
        public FormEstMovimentacaoSimplificadaPesquisa()
        {
            InitializeComponent();
            CarregarListaGrid();
            txtPesquisa.Focus();
        }

        public void CarregarListaGrid()
        {
            MovimentoEstoqueController controle = new MovimentoEstoqueController();
            List<MovimentoEstoqueDTO> Lista = controle.GetMovimentoLista();

            dbGridPesquisa.DataSource = Lista;

            dbGridPesquisa.Columns["idmovimentoestoque"].DisplayIndex = 0;
            dbGridPesquisa.Columns["idmovimentoestoque"].HeaderText = "Id";
            dbGridPesquisa.Columns["idmovimentoestoque"].Width = 50;

            dbGridPesquisa.Columns["descricao"].DisplayIndex = 1;
            dbGridPesquisa.Columns["descricao"].HeaderText = "Descrição Movimento";
            dbGridPesquisa.Columns["descricao"].Width = 244;

            dbGridPesquisa.Columns["datamovimento"].DisplayIndex = 2;
            dbGridPesquisa.Columns["datamovimento"].HeaderText = "Data Mov.";
            dbGridPesquisa.Columns["datamovimento"].Width = 75;

            dbGridPesquisa.Columns["usuariomovimento"].DisplayIndex = 3;
            dbGridPesquisa.Columns["usuariomovimento"].HeaderText = "Usuário Mov.";
            dbGridPesquisa.Columns["usuariomovimento"].Width = 85;

            dbGridPesquisa.Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MovimentoEstoqueController controle = new MovimentoEstoqueController();

            int id = (Int32)dbGridPesquisa.CurrentRow.Cells[0].Value;
            PMovimentacaoSimplificada = controle.GetMovimento(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
