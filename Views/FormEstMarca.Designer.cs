namespace LaPizza.Views
{
    partial class FormEstMarca
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtMarcaId = new LaPizza.Controllers.LpText();
            this.txtMarcaDescricao = new LaPizza.Controllers.LpText();
            this.cbAtiva = new System.Windows.Forms.CheckBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.cbAtiva);
            this.pnlPrincipal.Controls.Add(this.txtMarcaDescricao);
            this.pnlPrincipal.Controls.Add(this.txtMarcaId);
            this.pnlPrincipal.Controls.Add(this.lbDescricao);
            this.pnlPrincipal.Controls.Add(this.lbId);
            this.pnlPrincipal.Size = new System.Drawing.Size(484, 69);
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Click += new System.EventHandler(this.btnAcaoAdicionar_Click);
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Click += new System.EventHandler(this.btnAcaoEditar_Click);
            // 
            // btnAcaoConsultar
            // 
            this.btnAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.btnAcaoConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoConsultar.Click += new System.EventHandler(this.btnAcaoConsultar_Click);
            // 
            // pnlAcoesRodape
            // 
            this.pnlAcoesRodape.Location = new System.Drawing.Point(0, 148);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Click += new System.EventHandler(this.btnAcaoExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(9, 15);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(78, 15);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtMarcaId
            // 
            this.txtMarcaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaId.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaId.Location = new System.Drawing.Point(12, 31);
            this.txtMarcaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(62, 20);
            this.txtMarcaId.TabIndex = 4;
            // 
            // txtMarcaDescricao
            // 
            this.txtMarcaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarcaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaDescricao.Location = new System.Drawing.Point(81, 31);
            this.txtMarcaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtMarcaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtMarcaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtMarcaDescricao.Name = "txtMarcaDescricao";
            this.txtMarcaDescricao.Size = new System.Drawing.Size(336, 20);
            this.txtMarcaDescricao.TabIndex = 6;
            this.txtMarcaDescricao.TextChanged += new System.EventHandler(this.txtMarcaDescricao_TextChanged);
            // 
            // cbAtiva
            // 
            this.cbAtiva.AutoSize = true;
            this.cbAtiva.Location = new System.Drawing.Point(423, 31);
            this.cbAtiva.Name = "cbAtiva";
            this.cbAtiva.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtiva.Size = new System.Drawing.Size(56, 19);
            this.cbAtiva.TabIndex = 19;
            this.cbAtiva.Text = "Ativa?";
            this.cbAtiva.UseVisualStyleBackColor = true;
            // 
            // FormEstMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(484, 188);
            this.Name = "FormEstMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Marca";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbId;
        private Controllers.LpText txtMarcaDescricao;
        private Controllers.LpText txtMarcaId;
        public System.Windows.Forms.CheckBox cbAtiva;
    }
}
