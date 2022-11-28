using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace LaPizza.Views.Relatorios
{
    public partial class RelMarcas : LaPizza.Views.FormBaseCadastros
    {
        public RelMarcas()
        {
            InitializeComponent();
            this.Height = this.Height - 39;
            LimpaCampos();
            HabilitaAcao(TipoAcao.Confirmar, true);
        }
        public void LimpaCampos()
        {
            txtMarcaId.Text = "";
            txtMarcaDescricao.Text = "";
            cbPesquisarAtivos.SelectedIndex = 0;
            cbTipoOrdenacao.SelectedIndex = 0;
            HabilitaAcao(TipoAcao.Confirmar, true);
        }

        private List<MarcaDTO> GetMarcaLista()
        {
            Context db = new Context();
            List<MarcaDTO> lista = (from marca in db.marca
                                    orderby marca.idmarca
                                    select new MarcaDTO
                                    {
                                        idmarca = marca.idmarca,
                                        descricao = marca.descricao,
                                        ativa = marca.ativa
                                    }).ToList();

            if (txtMarcaId.Text != "")
                lista = new List<MarcaDTO>(lista.Where(p => p.idmarca == Convert.ToInt32(txtMarcaId.Text)));

            if (cbPesquisarAtivos.SelectedIndex == 1)
                lista = new List<MarcaDTO>(lista.Where(p => p.ativa == true));
            else if (cbPesquisarAtivos.SelectedIndex == 2)
                lista = new List<MarcaDTO>(lista.Where(p => p.ativa == false));

            if (cbTipoOrdenacao.SelectedIndex == 0)
                lista = new List<MarcaDTO>(lista.OrderBy(p => p.idmarca));
            else if (cbTipoOrdenacao.SelectedIndex == 1)
                lista = new List<MarcaDTO>(lista.OrderBy(p => p.descricao));

            return lista;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataTable dt = CollectionHelper.ConvertTo<MarcaDTO>(GetMarcaLista());

            using (var frm = new RelMarcasRV(dt))
                frm.ShowDialog();

            HabilitaAcao(TipoAcao.Confirmar, true);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
