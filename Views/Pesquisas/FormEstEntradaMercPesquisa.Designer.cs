
namespace LaPizza.Views.Pesquisas
{
    partial class FormEstEntradaMercPesquisa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbCancelar = new System.Windows.Forms.RadioButton();
            this.rbEfetivar = new System.Windows.Forms.RadioButton();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 370);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.label2);
            this.pnlPesquisa.Controls.Add(this.label1);
            this.pnlPesquisa.Controls.Add(this.dateFim);
            this.pnlPesquisa.Controls.Add(this.dateInicio);
            this.pnlPesquisa.Controls.Add(this.gbStatus);
            this.pnlPesquisa.Size = new System.Drawing.Size(454, 81);
            this.pnlPesquisa.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.pnlPesquisa.Controls.SetChildIndex(this.lbPesquisa, 0);
            this.pnlPesquisa.Controls.SetChildIndex(this.gbStatus, 0);
            this.pnlPesquisa.Controls.SetChildIndex(this.dateInicio, 0);
            this.pnlPesquisa.Controls.SetChildIndex(this.dateFim, 0);
            this.pnlPesquisa.Controls.SetChildIndex(this.label1, 0);
            this.pnlPesquisa.Controls.SetChildIndex(this.label2, 0);
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.Location = new System.Drawing.Point(-3, 0);
            this.lbPesquisa.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(0, 3);
            this.txtPesquisa.Size = new System.Drawing.Size(61, 20);
            this.txtPesquisa.Visible = false;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbPendente);
            this.gbStatus.Controls.Add(this.rbCancelar);
            this.gbStatus.Controls.Add(this.rbEfetivar);
            this.gbStatus.Location = new System.Drawing.Point(106, 0);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(239, 35);
            this.gbStatus.TabIndex = 8;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Location = new System.Drawing.Point(158, 13);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(76, 17);
            this.rbPendente.TabIndex = 2;
            this.rbPendente.Text = "Pendentes";
            this.rbPendente.UseVisualStyleBackColor = true;
            this.rbPendente.Click += new System.EventHandler(this.rbPendente_Click);
            // 
            // rbCancelar
            // 
            this.rbCancelar.AutoSize = true;
            this.rbCancelar.Location = new System.Drawing.Point(82, 13);
            this.rbCancelar.Name = "rbCancelar";
            this.rbCancelar.Size = new System.Drawing.Size(81, 17);
            this.rbCancelar.TabIndex = 1;
            this.rbCancelar.Text = "Canceladas";
            this.rbCancelar.UseVisualStyleBackColor = true;
            this.rbCancelar.Click += new System.EventHandler(this.rbCancelar_Click);
            // 
            // rbEfetivar
            // 
            this.rbEfetivar.AutoSize = true;
            this.rbEfetivar.Location = new System.Drawing.Point(6, 13);
            this.rbEfetivar.Name = "rbEfetivar";
            this.rbEfetivar.Size = new System.Drawing.Size(75, 17);
            this.rbEfetivar.TabIndex = 0;
            this.rbEfetivar.Text = "Efetivadas";
            this.rbEfetivar.UseVisualStyleBackColor = true;
            this.rbEfetivar.Click += new System.EventHandler(this.rbEfetivar_Click);
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(106, 55);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(81, 20);
            this.dateInicio.TabIndex = 9;
            this.dateInicio.ValueChanged += new System.EventHandler(this.dateInicio_ValueChanged);
            // 
            // dateFim
            // 
            this.dateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFim.Location = new System.Drawing.Point(259, 55);
            this.dateFim.Name = "dateFim";
            this.dateFim.Size = new System.Drawing.Size(81, 20);
            this.dateFim.TabIndex = 10;
            this.dateFim.ValueChanged += new System.EventHandler(this.dateFim_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(256, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Até:";
            // 
            // FormEstEntradaMercPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(454, 491);
            this.Name = "FormEstEntradaMercPesquisa";
            this.Text = "Pesquisa Entrada de Mercadoria";
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFim;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.GroupBox gbStatus;
        public System.Windows.Forms.RadioButton rbPendente;
        public System.Windows.Forms.RadioButton rbCancelar;
        public System.Windows.Forms.RadioButton rbEfetivar;
    }
}
