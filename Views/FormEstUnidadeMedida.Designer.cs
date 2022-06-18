namespace LaPizza.Views
{
    partial class FormEstUnidadeMedida
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
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.txtUnidadeMedidaDescricao = new LaPizza.Controllers.LpText();
            this.txtUnidadeMedidaId = new LaPizza.Controllers.LpText();
            this.lbUnidadeMedidaDescricao = new System.Windows.Forms.Label();
            this.lbUnidadeMedidaId = new System.Windows.Forms.Label();
            this.txtUnidadeMedidaSigla = new LaPizza.Controllers.LpText();
            this.lbUnidadeMedidaSigla = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.pnlNomeRotina.SuspendLayout();
            this.pnlAcoesMenu.SuspendLayout();
            this.pnlAcoesRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lbUnidadeMedidaSigla);
            this.pnlPrincipal.Controls.Add(this.txtUnidadeMedidaSigla);
            this.pnlPrincipal.Controls.Add(this.cbAtivo);
            this.pnlPrincipal.Controls.Add(this.txtUnidadeMedidaDescricao);
            this.pnlPrincipal.Controls.Add(this.txtUnidadeMedidaId);
            this.pnlPrincipal.Controls.Add(this.lbUnidadeMedidaDescricao);
            this.pnlPrincipal.Controls.Add(this.lbUnidadeMedidaId);
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
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
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
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(421, 32);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbAtivo.Size = new System.Drawing.Size(56, 19);
            this.cbAtivo.TabIndex = 29;
            this.cbAtivo.Text = "Ativo?";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtUnidadeMedidaDescricao
            // 
            this.txtUnidadeMedidaDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeMedidaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedidaDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtUnidadeMedidaDescricao.Location = new System.Drawing.Point(79, 32);
            this.txtUnidadeMedidaDescricao.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtUnidadeMedidaDescricao.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtUnidadeMedidaDescricao.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtUnidadeMedidaDescricao.Name = "txtUnidadeMedidaDescricao";
            this.txtUnidadeMedidaDescricao.Size = new System.Drawing.Size(250, 20);
            this.txtUnidadeMedidaDescricao.TabIndex = 28;
            this.txtUnidadeMedidaDescricao.TextChanged += new System.EventHandler(this.txtUnidadeMedidaDescricao_TextChanged);
            // 
            // txtUnidadeMedidaId
            // 
            this.txtUnidadeMedidaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeMedidaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedidaId.ForeColor = System.Drawing.Color.Black;
            this.txtUnidadeMedidaId.Location = new System.Drawing.Point(10, 32);
            this.txtUnidadeMedidaId.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtUnidadeMedidaId.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtUnidadeMedidaId.LpTipo = LaPizza.Controllers.LpText.tipoCampo.Integer;
            this.txtUnidadeMedidaId.Name = "txtUnidadeMedidaId";
            this.txtUnidadeMedidaId.Size = new System.Drawing.Size(62, 20);
            this.txtUnidadeMedidaId.TabIndex = 27;
            // 
            // lbUnidadeMedidaDescricao
            // 
            this.lbUnidadeMedidaDescricao.AutoSize = true;
            this.lbUnidadeMedidaDescricao.Location = new System.Drawing.Point(76, 16);
            this.lbUnidadeMedidaDescricao.Name = "lbUnidadeMedidaDescricao";
            this.lbUnidadeMedidaDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbUnidadeMedidaDescricao.TabIndex = 26;
            this.lbUnidadeMedidaDescricao.Text = "Descrição";
            // 
            // lbUnidadeMedidaId
            // 
            this.lbUnidadeMedidaId.AutoSize = true;
            this.lbUnidadeMedidaId.Location = new System.Drawing.Point(7, 16);
            this.lbUnidadeMedidaId.Name = "lbUnidadeMedidaId";
            this.lbUnidadeMedidaId.Size = new System.Drawing.Size(16, 13);
            this.lbUnidadeMedidaId.TabIndex = 25;
            this.lbUnidadeMedidaId.Text = "Id";
            // 
            // txtUnidadeMedidaSigla
            // 
            this.txtUnidadeMedidaSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeMedidaSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedidaSigla.ForeColor = System.Drawing.Color.Black;
            this.txtUnidadeMedidaSigla.Location = new System.Drawing.Point(335, 32);
            this.txtUnidadeMedidaSigla.LpCorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtUnidadeMedidaSigla.LpCorPadrao = System.Drawing.SystemColors.Window;
            this.txtUnidadeMedidaSigla.LpTipo = LaPizza.Controllers.LpText.tipoCampo.String;
            this.txtUnidadeMedidaSigla.MaxLength = 3;
            this.txtUnidadeMedidaSigla.Name = "txtUnidadeMedidaSigla";
            this.txtUnidadeMedidaSigla.Size = new System.Drawing.Size(80, 20);
            this.txtUnidadeMedidaSigla.TabIndex = 30;
            // 
            // lbUnidadeMedidaSigla
            // 
            this.lbUnidadeMedidaSigla.AutoSize = true;
            this.lbUnidadeMedidaSigla.Location = new System.Drawing.Point(332, 16);
            this.lbUnidadeMedidaSigla.Name = "lbUnidadeMedidaSigla";
            this.lbUnidadeMedidaSigla.Size = new System.Drawing.Size(30, 13);
            this.lbUnidadeMedidaSigla.TabIndex = 31;
            this.lbUnidadeMedidaSigla.Text = "Sigla";
            // 
            // FormEstUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 188);
            this.Name = "FormEstUnidadeMedida";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlNomeRotina.ResumeLayout(false);
            this.pnlAcoesMenu.ResumeLayout(false);
            this.pnlAcoesMenu.PerformLayout();
            this.pnlAcoesRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUnidadeMedidaSigla;
        private Controllers.LpText txtUnidadeMedidaSigla;
        public System.Windows.Forms.CheckBox cbAtivo;
        private Controllers.LpText txtUnidadeMedidaDescricao;
        private Controllers.LpText txtUnidadeMedidaId;
        private System.Windows.Forms.Label lbUnidadeMedidaDescricao;
        private System.Windows.Forms.Label lbUnidadeMedidaId;
    }
}
