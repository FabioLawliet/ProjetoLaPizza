using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPizza.Views.Relatorios
{
    public partial class RelProdutosRV : Form
    {
        public RelProdutosRV()
        {
            InitializeComponent();
        }

        private void RelProdutosRV_Load(object sender, EventArgs e)
        {
            {
                this.reportViewer.RefreshReport();
            }
        }
    }
}
