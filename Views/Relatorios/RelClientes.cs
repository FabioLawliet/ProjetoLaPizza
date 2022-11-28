using LaPizza.Controllers;
using LaPizza.DAO;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Views.Relatorios
{
    public partial class RelClientes : LaPizza.Views.FormBaseCadastros
    {
        public RelClientes()
        {
            InitializeComponent();
            HabilitaAcao(TipoAcao.Confirmar, true);

        }
    }
}
