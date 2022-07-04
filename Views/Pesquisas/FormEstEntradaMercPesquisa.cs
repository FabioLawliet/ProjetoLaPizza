using LaPizza.Controllers;
using LaPizza.Models;
using System;
using LaPizza.Views.Pesquisas;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static LaPizza.Views.FormEntMercadoria;

namespace LaPizza.Views.Pesquisas
{
    public partial class FormEstEntradaMercPesquisa : LaPizza.Views.FormBasePesquisa
    {
        public EntradaMercadoriaDTO FEntradaDTO;
        public EntradaMercadoriaDB FEntradaDB;
        public FornecedorDTO FFornecedor;
        public FormEstEntradaMercPesquisa()
        {
            InitializeComponent();
            dateInicio.Value = DateTime.Now.AddDays(-30);
            dateFim.Value = DateTime.Now;
            CarregaLista();            
        }
        public void VerificaStatus(string status)
        {
            if(status == "Editando")
            {
                rbEfetivar.Enabled = false;
                rbCancelar.Enabled = false;
                rbPendente.Checked = true;
            }
            if(status == "Excluindo")
            {
                rbEfetivar.Checked = true;
                rbCancelar.Enabled = false;
                rbPendente.Enabled = false;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EntradaMercadoriaController entradaController = new EntradaMercadoriaController();
            FornecedorController fornecedorController = new FornecedorController();
            int idEntrada = (int)dbGridPesquisa.CurrentRow.Cells[0].Value;            
            int idFornecedor = (int)dbGridPesquisa.CurrentRow.Cells[1].Value;

            //Objeto entrada somente para visualização dos itens etc.
            FEntradaDTO = entradaController.GetEntradaDTO(idEntrada);
            //Objeto entrada para edição
            FEntradaDB = entradaController.GetEntradaDB(idEntrada);
            //Objeto Fornecedor
            FFornecedor = fornecedorController.GetFornecedor(idFornecedor);
            Close();           
        }
        private void CarregaLista()
        {
            EntradaMercadoriaController entrada = new EntradaMercadoriaController();
            var lista = entrada.ListaEntradaMercadoria();
            dbGridPesquisa.DataSource = null;
            dbGridPesquisa.DataSource = lista;
            AjeitaCampos();
            if (dbGridPesquisa.RowCount > 0)
            {
                btnConfirmar.Enabled = true;                
            }        
            else
                btnConfirmar.Enabled = false;           
        }
        private void CarregaListaFiltrada()
        {
            EntradaMercadoriaController entrada = new EntradaMercadoriaController();
            string status = "";          
            if (rbEfetivar.Checked)
                status = "EFE";
            else if (rbPendente.Checked)
                status = "PEN";
            else if (rbCancelar.Checked)
                status = "CAN";
            var lista = entrada.ListaEntradaMercadoriaFiltrada(dateInicio.Value.Date, dateFim.Value.Date, status);
            dbGridPesquisa.DataSource = null;
            dbGridPesquisa.DataSource = lista;
            AjeitaCampos();
            if (dbGridPesquisa.RowCount > 0)
            {
                btnConfirmar.Enabled = true;                
            }
            else
                btnConfirmar.Enabled = false;
        }
        private void AjeitaCampos()
        {
            dbGridPesquisa.Columns["identradamerc"].HeaderText = "Cód. Entrada";
            dbGridPesquisa.Columns["idfornecedor"].HeaderText = "Cód. Fornecedor";
            dbGridPesquisa.Columns["status"].HeaderText = "Status";
            dbGridPesquisa.Columns["dataabertura"].HeaderText = "Data Abertura";
            dbGridPesquisa.Columns["dataconclusao"].HeaderText = "Data Conclusão";
        }
        private void rbEfetivar_Click(object sender, EventArgs e)
        {
            CarregaListaFiltrada();
        }

        private void rbCancelar_Click(object sender, EventArgs e)
        {
            CarregaListaFiltrada();
        }

        private void rbPendente_Click(object sender, EventArgs e)
        {
            CarregaListaFiltrada();
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            CarregaListaFiltrada();
        }

        private void dateFim_ValueChanged(object sender, EventArgs e)
        {
            CarregaListaFiltrada();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
