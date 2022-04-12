namespace LaPizza.Views
{
    partial class FormEstMarcaPesquisa
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
            this.pnlAcoesRodape.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 393);
            this.pnlAcoesRodape.Size = new System.Drawing.Size(458, 40);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(308, 5);
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(383, 5);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Size = new System.Drawing.Size(458, 60);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Size = new System.Drawing.Size(438, 20);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // FormEstMarcaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(458, 493);
            this.Name = "FormEstMarcaPesquisa";
            this.Text = "Pesquisa de Marca";
            this.pnlAcoesRodape.ResumeLayout(false);
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
