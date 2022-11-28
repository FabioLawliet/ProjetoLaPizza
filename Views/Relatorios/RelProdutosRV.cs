﻿using System;
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
        DataTable dt = new DataTable();
        public RelProdutosRV(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void RelProdutosRV_Load(object sender, EventArgs e)
        {
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(new
                Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer.RefreshReport();
        }
    }
}